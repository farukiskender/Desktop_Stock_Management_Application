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
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Stok Kartları");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Yeni Stok Ekle");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Kritik Seviye Ürünler");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Stok Hareketleri");
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Stok Yönetimi", new System.Windows.Forms.TreeNode[] {
            treeNode27,
            treeNode28,
            treeNode29,
            treeNode30});
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Müşteri Listesi");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("Tedarikçi Listesi");
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("Yeni Cari Kart");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("Cari Hesaplar", new System.Windows.Forms.TreeNode[] {
            treeNode32,
            treeNode33,
            treeNode34});
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("Hızlı Satış");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("Satış Geçmişi");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("İade İşlemleri");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("Satış İşlemleri", new System.Windows.Forms.TreeNode[] {
            treeNode36,
            treeNode37,
            treeNode38});
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("Depo Listesi");
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("Depolar Arası Transfer");
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("Sayım Giriş");
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("Depo & Transfer", new System.Windows.Forms.TreeNode[] {
            treeNode40,
            treeNode41,
            treeNode42});
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("Günlük Kasa Durumu");
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("Gelir/Gider Ekle");
            System.Windows.Forms.TreeNode treeNode46 = new System.Windows.Forms.TreeNode("Kasa & Finans", new System.Windows.Forms.TreeNode[] {
            treeNode44,
            treeNode45});
            System.Windows.Forms.TreeNode treeNode47 = new System.Windows.Forms.TreeNode("Genel Durum Özeti");
            System.Windows.Forms.TreeNode treeNode48 = new System.Windows.Forms.TreeNode("Kar/Zarar Analizi");
            System.Windows.Forms.TreeNode treeNode49 = new System.Windows.Forms.TreeNode("Raporlar", new System.Windows.Forms.TreeNode[] {
            treeNode47,
            treeNode48});
            System.Windows.Forms.TreeNode treeNode50 = new System.Windows.Forms.TreeNode("Kullanıcılar");
            System.Windows.Forms.TreeNode treeNode51 = new System.Windows.Forms.TreeNode("Veritabanı Yedekle");
            System.Windows.Forms.TreeNode treeNode52 = new System.Windows.Forms.TreeNode("Ayarlar", new System.Windows.Forms.TreeNode[] {
            treeNode50,
            treeNode51});
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
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode27.Name = "Node_StokListesi";
            treeNode27.Text = "Stok Kartları";
            treeNode28.Name = "Node_StokEkle";
            treeNode28.Tag = "StokTanimlari";
            treeNode28.Text = "Yeni Stok Ekle";
            treeNode29.Name = "Node_KritikStok";
            treeNode29.Text = "Kritik Seviye Ürünler";
            treeNode30.Name = "Node_StokHareket";
            treeNode30.Text = "Stok Hareketleri";
            treeNode31.Name = "Root_Stok";
            treeNode31.Text = "Stok Yönetimi";
            treeNode32.Name = "Node_Musteriler";
            treeNode32.Text = "Müşteri Listesi";
            treeNode33.Name = "Node_Tedarikciler";
            treeNode33.Text = "Tedarikçi Listesi";
            treeNode34.Name = "Node_CariEkle";
            treeNode34.Text = "Yeni Cari Kart";
            treeNode35.Name = "Root_Cari";
            treeNode35.Text = "Cari Hesaplar";
            treeNode36.Name = "Node_Pos";
            treeNode36.Text = "Hızlı Satış";
            treeNode37.Name = "Node_SatisGecmisi";
            treeNode37.Text = "Satış Geçmişi";
            treeNode38.Name = "Node_Iade";
            treeNode38.Text = "İade İşlemleri";
            treeNode39.Name = "Root_Satis";
            treeNode39.Text = "Satış İşlemleri";
            treeNode40.Name = "Node_Depolar";
            treeNode40.Text = "Depo Listesi";
            treeNode41.Name = "Node_Transfer";
            treeNode41.Text = "Depolar Arası Transfer";
            treeNode42.Name = "Node_Sayim";
            treeNode42.Text = "Sayım Giriş";
            treeNode43.Name = "Root_Depo";
            treeNode43.Text = "Depo & Transfer";
            treeNode44.Name = "Node_KasaDurum";
            treeNode44.Text = "Günlük Kasa Durumu";
            treeNode45.Name = "Node_GelirGider";
            treeNode45.Text = "Gelir/Gider Ekle";
            treeNode46.Name = "Root_Finans";
            treeNode46.Text = "Kasa & Finans";
            treeNode47.Name = "Node_OzetRapor";
            treeNode47.Text = "Genel Durum Özeti";
            treeNode48.Name = "Node_KarZarar";
            treeNode48.Text = "Kar/Zarar Analizi";
            treeNode49.Name = "Root_Rapor";
            treeNode49.Text = "Raporlar";
            treeNode50.Name = "Node_Kullanicilar";
            treeNode50.Text = "Kullanıcılar";
            treeNode51.Name = "Node_Yedek";
            treeNode51.Text = "Veritabanı Yedekle";
            treeNode52.Name = "Root_Ayarlar";
            treeNode52.Text = "Ayarlar";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode31,
            treeNode35,
            treeNode39,
            treeNode43,
            treeNode46,
            treeNode49,
            treeNode52});
            this.treeView1.Size = new System.Drawing.Size(331, 771);
            this.treeView1.TabIndex = 0;
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

