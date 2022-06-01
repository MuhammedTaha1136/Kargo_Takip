using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace kargo_takip
{
    public partial class Giris_ekranı : Form
    {
        metot mtt = new metot();
        public Giris_ekranı()
        {
            InitializeComponent();
        }
        
        
        MySqlConnection baglanti = new MySqlConnection(
            "Server=localhost;Database=kargo_takip;Uid=root;Pwd=36_1107_34"
            );


        private void Giris_ekranı_Load(object sender, EventArgs e)
        {
            /*
            string Constr = "Server=localhost;Database=kargo_takip;Uid=root;Pwd=36_1107_34";
            using (var baglan = new MySqlConnection(Constr))
            {
                using (var command= new MySqlCommand("SELECT Tc_kimlik_no FROM uye_olusturma ORDER BY Tc_kimlik_no ASC ",baglan))
                {
                    try
                    {
                        command.Connection.Open();
                        MySqlDataReader dr = command.ExecuteReader();
                        while (dr.Read())
                        {
                            comboBox1.Items.Add(dr["Tc_kimlik_no"].ToString());
                        }
                        comboBox1.SelectedIndex = 0;
                    }
                    catch (Exception hata)
                    {

                        MessageBox.Show(hata.Message);
                    }
                }
            }
            */

            gbxÜye_olma.Visible = false;
            gbxBilgiler.Visible = false;
            gbxUyeGuncelle.Visible = false;
            gbxÜye_listele.Visible = false;

            uyegetir();
            
            try
            {
                baglanti.Open();
               
            }
            catch (Exception bilgi)
            {

                MessageBox.Show("Hata meydana geldi. Hata :" + bilgi.Message.ToString());
            }
          
        }
        void uyegetir()
        {
            using (var baglan = new MySqlConnection(uye_list))
            {
                using (var adap = new MySqlDataAdapter("SELECT * FROM uye_olusturma", baglan))
                {
                    try
                    {
                        baglan.Open();
                        DataTable dt = new DataTable();
                        adap.Fill(dt);
                        dgvUyeListele.DataSource = dt;
                        dgvUyeListele.Columns[0].HeaderText = "TC Kimlik Bilgiler";
                        dgvUyeListele.Columns[1].HeaderText = "İsim";
                        dgvUyeListele.Columns[2].HeaderText = "Soyisim";
                        dgvUyeListele.Columns[3].HeaderText = "Parola";

                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }
        }
        private void btnUyelik_tamamla_Click(object sender, EventArgs e)
        {
            
            try
            {
                MySqlCommand command = new MySqlCommand();
                command.CommandText = "insert into uye_olusturma(Tc_Kimlik_Bilgiler, İsim, Soyisim, Parola) " +
                    "values('" + mstTc_no.Text + "','" + txtAd.Text + "','" + txtSoyad.Text + "','" + txtŞifre.Text + "')";

                command.Connection = baglanti;
                command.ExecuteNonQuery();


            }
            catch (Exception )
            {
                //MessageBox.Show("Hata meydana geldi. Hata :" + hata.Message.ToString(), "sdad",
                                // MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (txtŞifre_Tekrar.Text == "" || txtAd.Text == "" || txtSoyad.Text == "")
            {
                MessageBox.Show("Boş bilgiler var", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtŞifre.Text != txtŞifre_Tekrar.Text)
            {
                MessageBox.Show("Hatalı bilgiler var", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                MessageBox.Show("Üyeliğiniz başarılı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gbxÜye_olma.Visible = false;

                mstTc_no.Clear();
                txtAd.Clear();
                txtSoyad.Clear();
                txtŞifre.Clear();
                txtŞifre_Tekrar.Clear();
            }

        }

        
        private void btnGiris_Click(object sender, EventArgs e)
        {
            gbxÜye_olma.Visible = false;
            gbxBilgiler.Location = new Point(x:17,y: 16);
            if (mtt.Kullanici_Kontrol(mstTc_no_login.Text.ToString(),txtParola.Text)==1)
            {
                gbxBilgiler.Visible = true;
                

                MySqlCommand komut = new MySqlCommand("select * from uye_olusturma where Tc_Kimlik_Bilgiler like '" + mstTc_no_login.Text + "'", baglanti);
                MySqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    lblTc_kimlik.Text = read["Tc_Kimlik_Bilgiler"].ToString();
                    lblParola_bilgi.Text = read["Parola"].ToString();
                    lblİsim.Text = read["İsim"].ToString();
                    lblSoyisim.Text = read["Soyisim"].ToString();
                }
                baglanti.Close();

                lblTc.Visible = false;
                lblParola.Visible = false;
                mstTc_no_login.Visible = false;
                txtParola.Visible = false;
                chcGöster_Gizle.Visible = false;
                btnGiris.Visible = false;
                label2.Visible = false;
                btnUye_ol.Visible = false;

            }
            else
            {
                MessageBox.Show("Girdiğiniz bilgiler Hatalı", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void main_form()
        {
           
        }

        private void chcGöster_Gizle_CheckedChanged(object sender, EventArgs e)
        {
            #region checkBox ile parolayı göster gizle işlemini yaptık.
            if (chcGöster_Gizle.CheckState == CheckState.Checked)
            {
                txtParola.UseSystemPasswordChar = true;
                chcGöster_Gizle.Text = "Gizle";
            }
            else if (chcGöster_Gizle.CheckState == CheckState.Unchecked)
            {
                txtParola.UseSystemPasswordChar = false;
                chcGöster_Gizle.Text = "Göster";
            }
            #endregion
        }

        private void chcGöster_Gizle2_CheckedChanged(object sender, EventArgs e)
        {
            #region checkBox2 ile parolayı göster gizle işlemini yaptık.
            if (chcGöster_Gizle2.CheckState == CheckState.Checked)
            {
                txtŞifre.UseSystemPasswordChar = true;
                chcGöster_Gizle2.Text = "Gizle";
            }
            else if (chcGöster_Gizle2.CheckState == CheckState.Unchecked)
            {
                txtŞifre.UseSystemPasswordChar = false;
                chcGöster_Gizle2.Text = "Göster";
            }
            #endregion
        }

        private void btnUye_ol_Click(object sender, EventArgs e)
        {
            gbxÜye_olma.Visible=true;
        }

        private void Giris_ekranı_Shown(object sender, EventArgs e)
        {
            mstTc_no_login.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            gbxÜye_olma.Visible = false;
        }

        string uye_list = "Server=localhost;Database=kargo_takip;Uid=root;Pwd=36_1107_34";

        private void button1_Click(object sender, EventArgs e)
        {
            btnUyelikGuncelle.Enabled = false;
            MessageBox.Show("Lütfen listelenen üyelerden " + "\n" + 
                            "kendi hesabınızı seçip güncelleyiniz. ","Bilgilendirme",
                             MessageBoxButtons.OK,MessageBoxIcon.Information);
            uyegetir();

            gbxÜye_listele.Location = new Point(x:17, y:200);
            gbxÜye_listele.Size = new Size(height: 240, width: 360);

            gbxUyeGuncelle.Location = new Point(x: 385, y: 200);  
            gbxUyeGuncelle.Visible = true;
            gbxÜye_listele.Visible = true;
            mstGuncelTC.Enabled = false;

        }


        //int Tc_Kimlik_Bilgiler = 0;

        private void dgvUyeListele_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtGuncelİsim.Text = dgvUyeListele.CurrentRow.Cells[1].Value.ToString();
            txtGuncelSoyisim.Text = dgvUyeListele.CurrentRow.Cells[2].Value.ToString();
            mstGuncelTC.Text = dgvUyeListele.CurrentRow.Cells[0].Value.ToString();
            txtGuncelParola.Text = dgvUyeListele.CurrentRow.Cells[3].Value.ToString();

        }

        private void dgvUyeListele_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        MySqlCommand cmd;
        private void button2_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();
            cmd = new MySqlCommand("Update uye_olusturma set İsim='" + txtGuncelİsim.Text + "', Soyisim='" +
                txtGuncelSoyisim.Text + "', Tc_Kimlik_Bilgiler='" +
                mstGuncelTC.Text + "', Parola='" +
                txtGuncelParola.Text + "' where Tc_Kimlik_Bilgiler='" +
                mstGuncelTC.Text + "'" , baglanti);
            cmd.ExecuteNonQuery();

            int sonuc = cmd.ExecuteNonQuery();
            if (sonuc != 0)
            {
                uyegetir();
                MessageBox.Show("Üyeliğiniz güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtGuncelİsim.Clear();
                txtGuncelSoyisim.Clear();
                txtGuncelParola.Clear();
                mstGuncelTC.Clear();

                baglanti.Close();
            }
            else
            {
                MessageBox.Show("Üyeliğiniz güncellenemedi !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                baglanti.Close();

            }


            /*
            MySqlCommand cmdGuncelle = new MySqlCommand();
            cmdGuncelle.Connection = baglanti;

            cmdGuncelle.CommandText =
                "update uye_olusturma set İsim='" +
                txtGuncelİsim.Text + "', Soyisim='" +
                txtGuncelSoyisim.Text + "', Tc_Kimlik_Bilgiler='" +
                txtGuncelTc.Text + "', Parola='" +
                txtGuncelParola.Text + "' where Tc_Kimlik_Bilgiler='" +
                Tc_Kimlik_Bilgiler
                + "'";

            int sonuc = cmdGuncelle.ExecuteNonQuery();
            if (sonuc != 0)
            {
                uyegetir();
                MessageBox.Show("Veri güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Veri güncellenemedi !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            */
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();
            cmd = new MySqlCommand("Delete from uye_olusturma where İsim='" + txtGuncelİsim.Text + "'", baglanti);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Üye Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            uyegetir();
            


            baglanti.Close();
        }
    }
}
