namespace Masaüstü_Stok_Yönetim_Uygulaması
{
    partial class StokTanimlari
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
            this.LB_product_name = new System.Windows.Forms.Label();
            this.TB_product_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LB_product_name
            // 
            this.LB_product_name.AutoSize = true;
            this.LB_product_name.Location = new System.Drawing.Point(25, 99);
            this.LB_product_name.Name = "LB_product_name";
            this.LB_product_name.Size = new System.Drawing.Size(58, 16);
            this.LB_product_name.TabIndex = 0;
            this.LB_product_name.Text = "Ürün Adı";
            // 
            // TB_product_name
            // 
            this.TB_product_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_product_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_product_name.Location = new System.Drawing.Point(28, 118);
            this.TB_product_name.Name = "TB_product_name";
            this.TB_product_name.Size = new System.Drawing.Size(356, 22);
            this.TB_product_name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(435, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ürün Adı";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(905, 82);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.ErrorImage = global::Masaüstü_Stok_Yönetim_Uygulaması.Properties.Resources.box_add_64dp_E3E3E3_FILL0_wght400_GRAD0_opsz48;
            this.pictureBox1.ImageLocation = "\\images\\box_add_64dp_E3E3E3_FILL0_wght400_GRAD0_opsz48.png";
            this.pictureBox1.Location = new System.Drawing.Point(76, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 58);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(126, 9);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.label2.Size = new System.Drawing.Size(295, 61);
            this.label2.TabIndex = 4;
            this.label2.Text = "Stok Tanımları";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // StokTanimlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 525);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_product_name);
            this.Controls.Add(this.LB_product_name);
            this.Name = "StokTanimlari";
            this.Text = "Stok Tanımları";
            this.Load += new System.EventHandler(this.YeniStokWindow_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_product_name;
        private System.Windows.Forms.TextBox TB_product_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}