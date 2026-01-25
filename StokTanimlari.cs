using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if (cb_birim.Text == "Koli" || cb_birim.Text=="KOLİ" || cb_birim.Text=="koli")
            {
                lbl_koli_adedi.Visible = true;
                tb_koli_adedi.Visible = true;
            }
            else
            {
                lbl_koli_adedi.Visible = false;
                tb_koli_adedi.Visible = false;
            }
        }
        private void rb_kritik_seviye_takip_CheckedChanged(object sender, EventArgs e)
        {
            if(rb_kritik_stok_uyari.Checked)
            {
                lbl_kritik_stok_seviyesi.Visible = true;
                tb_kritik_stok_seviyesi.Visible = true;
            }
            else
            {
                lbl_kritik_stok_seviyesi.Visible = false;
                tb_kritik_stok_seviyesi.Visible = false;
            }
        }

        private void rb_seri_no_takip_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
