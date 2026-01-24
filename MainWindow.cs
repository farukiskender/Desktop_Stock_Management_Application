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
    public partial class AnaSayfa : Form
    {
        private void FormAc(string FormAdi)
        {
            foreach (Form acikForm in this.MdiChildren)
            {
                if (acikForm.Name == FormAdi)
                {
                    acikForm.BringToFront();
                    return;
                }
            }
            Form YeniForm = null;

            switch (FormAdi)
            {
                case "StokTanimlari":
                    YeniForm = new StokTanimlari();
                    break;

                default:
                    MessageBox.Show("Form Sayfası Bulunamadı:" + FormAdi);
                    return;
            }
            if (YeniForm != null)
            {
                YeniForm.Name = FormAdi;
                YeniForm.WindowState = FormWindowState.Normal;
                YeniForm.Show();
            }

        }


        public AnaSayfa()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lvMasaustu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Tag==null || e.Node.Tag.ToString()=="")
            {
                return; 
            }
            string StokTanimlari = e.Node.Tag.ToString();

            FormAc(StokTanimlari);
        }
    }
}
