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
            StokKodunuHazirla();
            BirimleriGetir();
            AnaGruplariGetir();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_TextUpdate(object sender, EventArgs e)
        {
            if (cb_product_unit.Text == "Koli")
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
        private void btn_clear_click(object sender, EventArgs e)
        {
            FormuTemizle();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_product_name.Text) || cb_product_group.Items == null)
            {
                MessageBox.Show("Lütfen Ürün Adı, Ürün Grubu ve Birim alanlarını doldurunuz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = SqlHelper.BaglantiGetir())
            {
                conn.Open();

                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    string sqlUrun = @"INSERT INTO product 
                               (p_stock_keeping_unit, p_name, p_barcode, unit_id, p_group_id, p_subgroup_id, 
                                p_brand_name, p_model_name, p_description, p_critical_stock_level, 
                                user_id, p_status, p_record_date) 
                               VALUES 
                               (@SKU, @Ad, @Barkod, @Birim, @Grup, @AltGrup, 
                                @Marka, @Model, @Aciklama, @Kritik, 
                                @User, 1, GETDATE());
                               SELECT SCOPE_IDENTITY();";

                    SqlCommand cmdUrun = new SqlCommand(sqlUrun, conn, transaction);

                    cmdUrun.Parameters.AddWithValue("@SKU", tb_producte_code.Text);
                    cmdUrun.Parameters.AddWithValue("@Ad", tb_product_name.Text);
                    cmdUrun.Parameters.AddWithValue("@Barkod", tb_product_barkode.Text);
                    cmdUrun.Parameters.AddWithValue("@Birim", cb_product_unit.SelectedValue);
                    cmdUrun.Parameters.AddWithValue("@Grup", cb_product_group.Items);

                    if (cb_product_subgorup.Items != null)
                        cmdUrun.Parameters.AddWithValue("@AltGrup", cb_product_subgorup.Items);
                    else
                        cmdUrun.Parameters.AddWithValue("@AltGrup", DBNull.Value);

                    cmdUrun.Parameters.AddWithValue("@Marka", tb_brand_name.Text);
                    cmdUrun.Parameters.AddWithValue("@Model", tb_model_name.Text);
                    cmdUrun.Parameters.AddWithValue("@Aciklama", rtb_product_description.Text);
                    cmdUrun.Parameters.AddWithValue("@Kritik", tb_critical_stock_level.Text);
                    cmdUrun.Parameters.AddWithValue("@User", 1);

                    int yeniUrunID = Convert.ToInt32(cmdUrun.ExecuteScalar());

                    string sqlFiyat = @"INSERT INTO pricing 
                                (p_id, p_purchase_price, p_sales_price, p_taxrate, p_currency) 
                                VALUES 
                                (@UrunID, @Alis, @Satis, @Kdv, @ParaBirimi)";

                    SqlCommand cmdFiyat = new SqlCommand(sqlFiyat, conn, transaction);

                    cmdFiyat.Parameters.AddWithValue("@UrunID", yeniUrunID);
                    cmdFiyat.Parameters.AddWithValue("@Alis", tb_purchase_price.Text);
                    cmdFiyat.Parameters.AddWithValue("@Satis", tb_sales_price.Text);
                    cmdFiyat.Parameters.AddWithValue("@Kdv", tb_taxrate.Text);
                    cmdFiyat.Parameters.AddWithValue("@ParaBirimi", "TL");

                    cmdFiyat.ExecuteNonQuery();

                    transaction.Commit();

                    MessageBox.Show("Ürün ve fiyat bilgileri başarıyla kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FormuTemizle();
                }
                catch (Exception ex)
                {
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
        }




        private void btnTest_Click_1(object sender, EventArgs e)
        {
            // Rastgele bir stok kodu üretelim ki her basışta "Bu kod zaten var" hatası almayalım.
            string randomSuffix = DateTime.Now.ToString("mmss"); // Saniye ve salise
            string testStokKodu = "TEST-URUN-" + randomSuffix;

            using (System.Data.SqlClient.SqlConnection conn = SqlHelper.BaglantiGetir())
            {
                conn.Open();
                System.Data.SqlClient.SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // --- 1. ADIM: ÜRÜNÜ EKLE (ID'ler Hep 1) ---
                    string sqlUrun = @"INSERT INTO product 
                               (p_stock_keeping_unit, p_name, p_barcode, unit_id, p_group_id, p_subgroup_id, 
                                p_brand_name, p_model_name, p_description, p_critical_stock_level, 
                                user_id, p_status, p_record_date) 
                               VALUES 
                               (@SKU, 'Otomatik Test Ürünü', '123456789', 1, 1, 1, 
                                'TestMarka', 'TestModel', 'Bu veri kod tarafından otomatik test amaçlı eklendi.', 10, 
                                1, 1, GETDATE());
                               SELECT SCOPE_IDENTITY();";

                    System.Data.SqlClient.SqlCommand cmdUrun = new System.Data.SqlClient.SqlCommand(sqlUrun, conn, transaction);
                    cmdUrun.Parameters.AddWithValue("@SKU", testStokKodu);

                    // Eklenen ürünün ID'sini alıyoruz
                    int yeniUrunID = Convert.ToInt32(cmdUrun.ExecuteScalar());

                    // --- 2. ADIM: FİYATI EKLE ---
                    string sqlFiyat = @"INSERT INTO pricing 
                                (p_id, p_purchase_price, p_sales_price, p_taxrate, p_currency) 
                                VALUES 
                                (@UrunID, 100.00, 150.50, 18, 'TL')";

                    System.Data.SqlClient.SqlCommand cmdFiyat = new System.Data.SqlClient.SqlCommand(sqlFiyat, conn, transaction);
                    cmdFiyat.Parameters.AddWithValue("@UrunID", yeniUrunID);

                    cmdFiyat.ExecuteNonQuery();

                    // Hata yoksa onayla
                    transaction.Commit();

                    MessageBox.Show("BAŞARILI!\n\n" +
                                    "Eklenen Ürün ID: " + yeniUrunID + "\n" +
                                    "Stok Kodu: " + testStokKodu + "\n" +
                                    "Grup/AltGrup/Birim ID: 1\n" +
                                    "Fiyat: 100 TL / 150.50 TL",
                                    "Tam Veri Testi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("HATA OLUŞTU:\n" + ex.Message, "Test Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }


        void BirimleriGetir()
        {
            using (SqlConnection conn = SqlHelper.BaglantiGetir())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT unit_id, unit_name FROM unit", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cb_product_unit.DisplayMember = "unit_name"; // Ekranda görünecek isim
                    cb_product_unit.ValueMember = "unit_id";     // Arka plandaki ID
                    cb_product_unit.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Birimler getirilemedi: " + ex.Message);
                }
            }
        }

        void AnaGruplariGetir()
        {
            using (SqlConnection conn = SqlHelper.BaglantiGetir())
            {
                try
                {
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT p_group_id, p_group_name FROM product_group", conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    cb_product_group.DisplayMember = "p_group_name";
                    cb_product_group.ValueMember = "p_group_id";
                    cb_product_group.DataSource = dt;

                    // İlk açılışta hiçbiri seçili gelmesin (İsteğe bağlı)
                    // cmbUrunGrubu.SelectedIndex = -1; 
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gruplar getirilemedi: " + ex.Message);
                }
            }
        }

        void StokKodunuHazirla()
        {
            using (SqlConnection conn = SqlHelper.BaglantiGetir())
            {
                conn.Open();
                // Şirket ayarlarından öneki çekiyoruz
                SqlCommand cmd = new SqlCommand("SELECT TOP 1 stock_prefix_code FROM company_settings", conn);
                object sonuc = cmd.ExecuteScalar();

                if (sonuc != null)
                {
                    tb_producte_code.Text = sonuc.ToString(); // Örn: SRK-
                }
            }
        }

        private void cb_product_group_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Eğer seçim boşsa işlem yapma
            if (cb_product_group.SelectedValue == null) return;

            // C# Bazen ilk açılışta ID yerine tüm satırı (DataRowView) getirebilir,
            // bu yüzden "Seçilen şey gerçekten bir sayı mı?" diye kontrol ediyoruz.
            if (int.TryParse(cb_product_group.SelectedValue.ToString(), out int secilenGrupID))
            {
                using (SqlConnection conn = SqlHelper.BaglantiGetir())
                {
                    try
                    {
                        conn.Open();
                        // Sadece seçilen Ana Gruba ait alt grupları getiriyoruz
                        string sorgu = "SELECT p_subgroup_id, p_subgroup_name FROM product_subgroup WHERE p_group_id = @GrupID";

                        SqlDataAdapter da = new SqlDataAdapter(sorgu, conn);
                        da.SelectCommand.Parameters.AddWithValue("@GrupID", secilenGrupID);

                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        cb_product_subgorup.DisplayMember = "p_subgroup_name";
                        cb_product_subgorup.ValueMember = "p_subgroup_id";
                        cb_product_subgorup.DataSource = dt;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Alt gruplar getirilemedi: " + ex.Message);
                    }
                }
            }
        }
    }
}

