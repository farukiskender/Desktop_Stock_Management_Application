using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Masaüstü_Stok_Yönetim_Uygulaması
{
    public partial class a : Form
    {
        public a()
        {
            InitializeComponent();
        }

        private void YeniStokWindow_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_TextUpdate(object sender, EventArgs e)
        {
            if (cb_product_unit.Text == "Koli" || cb_product_unit.Text == "KOLİ" || cb_product_unit.Text == "koli")
            {
                lbl_koli_adedi.Visible = true;
                tb_number_of_packages.Visible = true;
            }
            else
            {
                lbl_koli_adedi.Visible = false;
                tb_number_of_packages.Visible = false;
            }
        }
        private void rb_kritik_seviye_takip_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_kritik_stok_uyari.Checked)
            {
                tb_critical_stock_level.Visible = true;
            }
            else
            {
                tb_critical_stock_level.Visible = false;
            }
        }

        private void rb_seri_no_takip_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            // 1. ADIM: BASİT KONTROLLER
            // Kullanıcı Ürün Adını veya Grubunu boş bıraktıysa uyarı verip çıkıyoruz.
            if (string.IsNullOrEmpty(tb_product_name.Text) || tb_product_group.Text == null)
            {
                MessageBox.Show("Lütfen Ürün Adı, Ürün Grubu ve Birim alanlarını doldurunuz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. ADIM: VERİTABANI BAĞLANTISI VE TRANSACTION BAŞLATMA
            using (SqlConnection conn = SqlHelper.BaglantiGetir())
            {
                conn.Open();

                // Transaction: İşlemlerden biri hata verirse hepsini geri almak için.
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // --- A) ÜRÜN KARTINI EKLEME (Product Tablosu) ---

                    string sqlUrun = @"INSERT INTO product 
                               (p_stock_keeping_unit, p_name, p_barcode, unit_id, p_group_id, p_subgroup_id, 
                                p_brand_name, p_model_name, p_description, p_critical_stock_level, 
                                user_id, p_status, p_record_date) 
                               VALUES 
                               (@SKU, @Ad, @Barkod, @Birim, @Grup, @AltGrup, 
                                @Marka, @Model, @Aciklama, @Kritik, 
                                @User, 1, GETDATE());
                               SELECT SCOPE_IDENTITY();";
                    // Not: SELECT SCOPE_IDENTITY() komutu, eklenen ürünün yeni ID'sini bize geri verir.

                    SqlCommand cmdUrun = new SqlCommand(sqlUrun, conn, transaction);

                    // Parametreleri formdan alıp SQL'e gönderiyoruz:
                    cmdUrun.Parameters.AddWithValue("@SKU", tb_producte_code.Text);      // Stok Kodu
                    cmdUrun.Parameters.AddWithValue("@Ad", tb_product_name.Text);        // Ürün Adı
                    cmdUrun.Parameters.AddWithValue("@Barkod", tb_product_barkode.Text);     // Barkod
                    cmdUrun.Parameters.AddWithValue("@Birim", cb_product_unit.SelectedValue); // Birim ID'si
                    cmdUrun.Parameters.AddWithValue("@Grup", tb_product_group.Text); // Grup ID'si

                    // Alt Grup seçilmediyse veritabanına NULL gönder:
                    if (tb_product_subgorup.Text != null)
                        cmdUrun.Parameters.AddWithValue("@AltGrup", tb_product_subgorup.Text);
                    else
                        cmdUrun.Parameters.AddWithValue("@AltGrup", DBNull.Value);

                    cmdUrun.Parameters.AddWithValue("@Marka", tb_brand_name.Text);
                    cmdUrun.Parameters.AddWithValue("@Model", tb_model_name.Text);
                    cmdUrun.Parameters.AddWithValue("@Aciklama", rtb_product_description.Text);
                    cmdUrun.Parameters.AddWithValue("@Kritik", tb_critical_stock_level.Text); // NumericUpDown'dan gelen sayı
                    cmdUrun.Parameters.AddWithValue("@User", 1); // Şimdilik varsayılan kullanıcı ID'si 1

                    // Komutu çalıştır ve Yeni Ürün ID'sini al (decimal döner, int'e çeviririz)
                    int yeniUrunID = Convert.ToInt32(cmdUrun.ExecuteScalar());


                    // --- B) FİYAT BİLGİSİNİ EKLEME (Pricing Tablosu) ---

                    string sqlFiyat = @"INSERT INTO pricing 
                                (p_id, p_purchase_price, p_sales_price, p_taxrate, p_currency) 
                                VALUES 
                                (@UrunID, @Alis, @Satis, @Kdv, @ParaBirimi)";

                    SqlCommand cmdFiyat = new SqlCommand(sqlFiyat, conn, transaction);

                    cmdFiyat.Parameters.AddWithValue("@UrunID", yeniUrunID); // Az önce aldığımız ID'yi buraya veriyoruz
                    cmdFiyat.Parameters.AddWithValue("@Alis", tb_purchase_price.Text);
                    cmdFiyat.Parameters.AddWithValue("@Satis", tb_sales_price.Text);
                    cmdFiyat.Parameters.AddWithValue("@Kdv", tb_taxrate.Text);
                    cmdFiyat.Parameters.AddWithValue("@ParaBirimi", "TL"); // Şimdilik sabit TL, istersen ComboBox'tan alabilirsin.

                    cmdFiyat.ExecuteNonQuery();

                    // --- C) MUTLU SON: İŞLEMİ ONAYLA ---
                    transaction.Commit();

                    MessageBox.Show("Ürün ve fiyat bilgileri başarıyla kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Formu temizle ki yeni kayıt yapılabilsin
                    FormuTemizle();
                }
                catch (Exception ex)
                {
                    // Hata olursa yapılan her şeyi geri al (Rollback)
                    transaction.Rollback();
                    MessageBox.Show("Kayıt sırasında bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void FormuTemizle()
        {
            tb_product_name.Text = "";
            tb_product_barkode.Text = "";
            tb_brand_name.Text = "";
            tb_model_name.Text = "";
            rtb_product_description.Text = "";
            tb_purchase_price.Text = "0";
            tb_sales_price.Text = "0";
            // Stok kodunu tekrar çekmek gerekebilir (Eğer otomatik artıyorsa)
        }
    }
}

