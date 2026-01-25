namespace Masaüstü_Stok_Yönetim_Uygulaması
{
    partial class StokKartlari
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StokKartlari));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_stokkartlari = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbl_stokkartlari);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1262, 82);
            this.panel1.TabIndex = 4;
            // 
            // lbl_stokkartlari
            // 
            this.lbl_stokkartlari.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_stokkartlari.BackColor = System.Drawing.Color.Transparent;
            this.lbl_stokkartlari.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_stokkartlari.Location = new System.Drawing.Point(134, 9);
            this.lbl_stokkartlari.Name = "lbl_stokkartlari";
            this.lbl_stokkartlari.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lbl_stokkartlari.Size = new System.Drawing.Size(295, 61);
            this.lbl_stokkartlari.TabIndex = 4;
            this.lbl_stokkartlari.Text = "Stok Kartları";
            this.lbl_stokkartlari.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_stokkartlari.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.ErrorImage = global::Masaüstü_Stok_Yönetim_Uygulaması.Properties.Resources.box_add_64dp_E3E3E3_FILL0_wght400_GRAD0_opsz48;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImageLocation = "/images/view_list_64dp_000000_FILL0_wght400_GRAD0_opsz48.png";
            this.pictureBox1.Location = new System.Drawing.Point(76, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 58);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // StokKartlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "StokKartlari";
            this.Text = "Stok Kartları";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_stokkartlari;
    }
}