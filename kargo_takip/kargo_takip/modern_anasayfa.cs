using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kargo_takip
{
    public partial class modern_anasayfa : Form
    {
        public modern_anasayfa()
        {
            InitializeComponent();
        }
        
        private void moveImageBox(object sender)
        {
            Guna2Button b = (Guna2Button)sender;
            pcbDegisim.Location = new Point(b.Location.X + 136, b.Location.Y - 30);
            pcbDegisim.SendToBack();
        }
        private void guna2Button1_CheckedChanged(object sender, EventArgs e)
        {
            moveImageBox(sender);

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            pnlİslem.Controls.Clear();
            Giris_ekranı yeni_giris = new Giris_ekranı();
            yeni_giris.TopLevel = false;
            pnlİslem.Controls.Add(yeni_giris);
            yeni_giris.Show();
            yeni_giris.Dock = DockStyle.Fill;
            yeni_giris.BringToFront();

            lblUstYazi.Text = "ÜYE GİRİŞ";
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            pnlİslem.Controls.Clear();
            kargo_ekle kargo_ekle = new kargo_ekle();
            kargo_ekle.TopLevel = false;
            pnlİslem.Controls.Add(kargo_ekle);
            kargo_ekle.Show();
            kargo_ekle.Dock = DockStyle.Fill;
            kargo_ekle.BringToFront();

            lblUstYazi.Text = "KARGO EKLE";
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            pnlİslem.Controls.Clear();
            Kargo_Takip kar_takip = new Kargo_Takip();
            kar_takip.TopLevel = false;
            pnlİslem.Controls.Add(kar_takip);
            kar_takip.Show();
            kar_takip.Dock = DockStyle.Fill;
            kar_takip.BringToFront();

            lblUstYazi.Text = "KARGO TAKİP";
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            kontrol denetim = new kontrol();
            denetim.ShowDialog();

            pnlİslem.Controls.Clear();
            üye_listele üye_list = new üye_listele();
            üye_list.TopLevel = false;
            pnlİslem.Controls.Add(üye_list);
            üye_list.Show();
            üye_list.Dock = DockStyle.Fill;
            üye_list.BringToFront();

            lblUstYazi.Text = "LİSTELEME İŞLEMLERİ";

        }

        private void modern_anasayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult EXİT = new DialogResult();
            EXİT = MessageBox.Show("Programı kapatmak istiyormusunuz?",
                                    "ÇIKIŞ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (EXİT == DialogResult.Yes)
            {
                Application.Exit();

            }
            if (EXİT == DialogResult.No)
            {
                e.Cancel = true;
                
            }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            pnlİslem.Controls.Clear();
            Ayarlar ayar = new Ayarlar();
            ayar.TopLevel = false;
            pnlİslem.Controls.Add(ayar);
            ayar.Show();
            ayar.Dock = DockStyle.Fill;
            ayar.BringToFront();

            lblUstYazi.Text = "AYARLAR";
        }
    }
}
