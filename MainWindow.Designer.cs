namespace Masaüstü_Stok_Yönetim_Uygulaması
{
    partial class AnaSayfa
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Stok Kartları");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Yeni Stok Ekle");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Kritik Seviye Ürünler");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Stok Hareketleri");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Stok Yönetimi", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Müşteri Listesi");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Tedarikçi Listesi");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Yeni Cari Kart");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Cari Hesaplar", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Hızlı Satış");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Satış Geçmişi");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("İade İşlemleri");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Satış İşlemleri", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11,
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Depo Listesi");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Depolar Arası Transfer");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Sayım Giriş");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Depo & Transfer", new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode15,
            treeNode16});
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Günlük Kasa Durumu");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Gelir/Gider Ekle");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Kasa & Finans", new System.Windows.Forms.TreeNode[] {
            treeNode18,
            treeNode19});
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Genel Durum Özeti");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Kar/Zarar Analizi");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Raporlar", new System.Windows.Forms.TreeNode[] {
            treeNode21,
            treeNode22});
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Kullanıcılar");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Veritabanı Yedekle");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Ayarlar", new System.Windows.Forms.TreeNode[] {
            treeNode24,
            treeNode25});
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.lvMasaustu = new System.Windows.Forms.ListView();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lvMasaustu);
            this.splitContainer1.Size = new System.Drawing.Size(1285, 771);
            this.splitContainer1.SplitterDistance = 331;
            this.splitContainer1.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node_StokListesi";
            treeNode1.Tag = "StokKartlari";
            treeNode1.Text = "Stok Kartları";
            treeNode2.Name = "Node_StokEkle";
            treeNode2.Tag = "StokTanimlari";
            treeNode2.Text = "Yeni Stok Ekle";
            treeNode3.Name = "Node_KritikStok";
            treeNode3.Tag = "KritikSeviyeUrunler";
            treeNode3.Text = "Kritik Seviye Ürünler";
            treeNode4.Name = "Node_StokHareket";
            treeNode4.Tag = "StokHareketleri";
            treeNode4.Text = "Stok Hareketleri";
            treeNode5.Name = "Root_Stok";
            treeNode5.Text = "Stok Yönetimi";
            treeNode6.Name = "Node_Musteriler";
            treeNode6.Text = "Müşteri Listesi";
            treeNode7.Name = "Node_Tedarikciler";
            treeNode7.Text = "Tedarikçi Listesi";
            treeNode8.Name = "Node_CariEkle";
            treeNode8.Text = "Yeni Cari Kart";
            treeNode9.Name = "Root_Cari";
            treeNode9.Text = "Cari Hesaplar";
            treeNode10.Name = "Node_Pos";
            treeNode10.Text = "Hızlı Satış";
            treeNode11.Name = "Node_SatisGecmisi";
            treeNode11.Text = "Satış Geçmişi";
            treeNode12.Name = "Node_Iade";
            treeNode12.Text = "İade İşlemleri";
            treeNode13.Name = "Root_Satis";
            treeNode13.Text = "Satış İşlemleri";
            treeNode14.Name = "Node_Depolar";
            treeNode14.Text = "Depo Listesi";
            treeNode15.Name = "Node_Transfer";
            treeNode15.Text = "Depolar Arası Transfer";
            treeNode16.Name = "Node_Sayim";
            treeNode16.Text = "Sayım Giriş";
            treeNode17.Name = "Root_Depo";
            treeNode17.Text = "Depo & Transfer";
            treeNode18.Name = "Node_KasaDurum";
            treeNode18.Text = "Günlük Kasa Durumu";
            treeNode19.Name = "Node_GelirGider";
            treeNode19.Text = "Gelir/Gider Ekle";
            treeNode20.Name = "Root_Finans";
            treeNode20.Text = "Kasa & Finans";
            treeNode21.Name = "Node_OzetRapor";
            treeNode21.Text = "Genel Durum Özeti";
            treeNode22.Name = "Node_KarZarar";
            treeNode22.Text = "Kar/Zarar Analizi";
            treeNode23.Name = "Root_Rapor";
            treeNode23.Text = "Raporlar";
            treeNode24.Name = "Node_Kullanicilar";
            treeNode24.Text = "Kullanıcılar";
            treeNode25.Name = "Node_Yedek";
            treeNode25.Text = "Veritabanı Yedekle";
            treeNode26.Name = "Root_Ayarlar";
            treeNode26.Text = "Ayarlar";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode9,
            treeNode13,
            treeNode17,
            treeNode20,
            treeNode23,
            treeNode26});
            this.treeView1.Size = new System.Drawing.Size(331, 771);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            // 
            // lvMasaustu
            // 
            this.lvMasaustu.AllowDrop = true;
            this.lvMasaustu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvMasaustu.HideSelection = false;
            this.lvMasaustu.Location = new System.Drawing.Point(0, 0);
            this.lvMasaustu.MultiSelect = false;
            this.lvMasaustu.Name = "lvMasaustu";
            this.lvMasaustu.Size = new System.Drawing.Size(950, 771);
            this.lvMasaustu.TabIndex = 0;
            this.lvMasaustu.UseCompatibleStateImageBehavior = false;
            this.lvMasaustu.SelectedIndexChanged += new System.EventHandler(this.lvMasaustu_SelectedIndexChanged);
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList1.ImageSize = new System.Drawing.Size(64, 64);
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 771);
            this.Controls.Add(this.splitContainer1);
            this.IsMdiContainer = true;
            this.Name = "AnaSayfa";
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListView lvMasaustu;
        private System.Windows.Forms.ImageList ımageList1;
    }
}

