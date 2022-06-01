using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace kargo_takip
{
    public partial class Ana_giriş : Form
    {
        metot mtt = new metot();

        public Ana_giriş()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (mtt.giris_kontrol(cmbGiris.SelectedItem.ToString(), txtGiris_Parola.Text) == 1)
            {
                MessageBox.Show("Giriş Başarılı", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                modern_anasayfa modern = new modern_anasayfa();
                modern.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Parola Hatalı", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }

        private void Ana_giriş_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void chcGöster_Gizle_CheckedChanged(object sender, EventArgs e)
        {
            if (chcGöster_Gizle.CheckState == CheckState.Checked)
            {
                txtGiris_Parola.UseSystemPasswordChar = true;
                chcGöster_Gizle.Text = "Gizle";
            }
            else if (chcGöster_Gizle.CheckState == CheckState.Unchecked)
            {
                txtGiris_Parola.UseSystemPasswordChar = false;
                chcGöster_Gizle.Text = "Göster";
            }
        }

        private void Ana_giriş_Load(object sender, EventArgs e)
        {
            string Constr = "Server=localhost;Database=kargo_takip;Uid=root;Pwd=36_1107_34";
            using (var baglan = new MySqlConnection(Constr))
            {
                using (var command = new MySqlCommand("SELECT personel_isim FROM personel_olusturma ORDER BY personel_isim ASC ", baglan))
                {
                    try
                    {
                        command.Connection.Open();
                        MySqlDataReader dr = command.ExecuteReader();
                        while (dr.Read())
                        {
                            cmbGiris.Items.Add(dr["personel_isim"].ToString());
                        }
                        cmbGiris.SelectedIndex = 0;
                    }
                    catch (Exception hata)
                    {

                        MessageBox.Show(hata.Message);
                    }
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
