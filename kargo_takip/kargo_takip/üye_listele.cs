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
using MySql.Data.MySqlClient;

namespace kargo_takip
{
    public partial class üye_listele : Form
    {
        metot mtt = new metot();
        public üye_listele()
        {
            InitializeComponent();
        }
      
        MySqlConnection baglanti = new MySqlConnection(
            "Server=localhost;Database=kargo_takip;Uid=root;Pwd=36_1107_34"
            );

        string dbcontrol = "Server=localhost;Database=kargo_takip;Uid=root;Pwd=36_1107_34";
        private void üye_listele_Load(object sender, EventArgs e)
        {
            baglanti.Open();

            #region Oluşturulan üyeleri listeledik
            using (var baglan = new MySqlConnection(dbcontrol))
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
#endregion

            #region Eklenen kargoları listeledik
            using (var baglan = new MySqlConnection(dbcontrol))
            {
                using (var adap = new MySqlDataAdapter("SELECT * FROM kargo_ekleme", baglan))
                {
                    try
                    {
                        baglan.Open();
                        DataTable dt = new DataTable();
                        adap.Fill(dt);
                        dgvKargo_listele.DataSource = dt;
                        dgvKargo_listele.Columns[0].HeaderText = "Fatura no  ";
                        dgvKargo_listele.Columns[1].HeaderText = "Ürün";
                        dgvKargo_listele.Columns[2].HeaderText = "Adet";
                        dgvKargo_listele.Columns[3].HeaderText = "Gönderilen İl";
                        dgvKargo_listele.Columns[4].HeaderText = "Alınacak İl";
                        dgvKargo_listele.Columns[5].HeaderText = "Gönderen TC";
                        dgvKargo_listele.Columns[6].HeaderText = "Gönderen Adı";
                        dgvKargo_listele.Columns[7].HeaderText = "Gönderen Soyadı";
                        dgvKargo_listele.Columns[8].HeaderText = "Alıcı TC";
                        dgvKargo_listele.Columns[9].HeaderText = "Alıcı Adı";
                        dgvKargo_listele.Columns[10].HeaderText = "Alıcı Soyadı";

                    }
                    catch (Exception)
                    {
                        throw;
                      
                    }
                }
            }
            #endregion
            
            personelGetir();

            gbxPersonel_ekle.Visible = false;
            gbxÜye_listele.Visible = false;
            gbxKargo_Listele.Visible = false;
            gbxPersonel_List.Visible = false;
            gbxPersonelGuncelle.Visible = false;
            
        }

        private void btnpersonel_kayıt_Click(object sender, EventArgs e)
        {

            #region Yeni personel hesapları ekledik 
            try
            {
                MySqlCommand command = new MySqlCommand();
                command.CommandText = "insert into personel_olusturma(personel_Tc_Kimlik, personel_isim, personel_soyisim, personel_parola) " +
                    "values('" + mstPersonelTc.Text + "','" + txtPersonelisim.Text + "','" + txtPersonelSoyisim.Text + "','" + txtPersonelParola.Text + "')";

                command.Connection = baglanti;
                command.ExecuteNonQuery();


            }
            catch (Exception )
            {
                //MessageBox.Show("Hata meydana geldi. Hata :" + hata.Message.ToString(), "sdad",
                 //MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (txtPersonel_sifre_tekrar.Text == "" || txtPersonelisim.Text == "" || txtPersonelSoyisim.Text == "" || txtPersonelParola.Text != txtPersonel_sifre_tekrar.Text)
            {
                MessageBox.Show("Boş veya Hatalı bilgiler var", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show(" Personel eklendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                mstPersonelTc.Clear();
                txtPersonelisim.Clear();
                txtPersonelSoyisim.Clear();
                txtPersonelParola.Clear();
                txtPersonel_sifre_tekrar.Clear();
                
                gnbPersonel_Ekle.Enabled = true;
                gbxPersonel_ekle.Visible = false;

            }
            #endregion


        }
        private void btnPersonel_Giriş_Click(object sender, EventArgs e)
        {
            
            if (mtt.personel_giris_kontrol(mstPersonelTc.Text.ToString(), txtPersonelParola.Text) == 1)
            {
                MessageBox.Show("Giriş Başarılı", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);

                kontrol per = new kontrol();
                per.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Bilgiler Var", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void chbgoster_gizle_CheckedChanged(object sender, EventArgs e)
        {
            if (chbgoster_gizle.CheckState == CheckState.Checked)
            {
                txtPersonelParola.UseSystemPasswordChar = true;
                chbgoster_gizle.Text = "Gizle";
            }
            else if (chbgoster_gizle.CheckState == CheckState.Unchecked)
            {
                txtPersonelParola.UseSystemPasswordChar = false;
                chbgoster_gizle.Text = "Göster";
            }
        }

        /*
        private void PersonelDegisme(object sender)
        {
            Guna2Button per = (Guna2Button)sender;
            gbxPersonel_ekle.Location = new Point(per.Location.X + 12, per.Location.Y + 105);
            gbxPersonel_ekle.SendToBack();
        }

        private void UyelerListele(object sender)
        {
            Guna2Button uye = (Guna2Button)sender;
            gbxÜye_listele.Location = new Point(uye.Location.X - 6, uye.Location.Y + 105);
            gbxÜye_listele.SendToBack();
        }

        private void KargolarıListele(object sender)
        {
            Guna2Button kar = (Guna2Button)sender;
            gbxKargo_Listele.Location = new Point(kar.Location.X + 11, kar.Location.Y + 105);
            gbxKargo_Listele.SendToBack();
        }
        */

        private void gnbPersonel_Ekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            gnbKargo_Listele.Enabled = true;
            gnbÜye_Listele.Enabled = true;
            gnbPersonel.Enabled = true;

            gbxKargo_Listele.Visible = false;
            gbxÜye_listele.Visible = false;
            gbxPersonel_List.Visible = false;

            gnbPersonel_Ekle.Enabled = false;
            gbxPersonel_ekle.Visible = true;

            gbxPersonel_ekle.Location = new Point(x: 12, y: 105);
            gbxPersonelGuncelle.Visible = false;



            //PersonelDegisme(sender);
        }

        private void gnbÜye_Listele_Click(object sender, EventArgs e)
        {
            gnbPersonel_Ekle.Enabled = true;
            gnbKargo_Listele.Enabled = true;
            gnbPersonel.Enabled = true;

            gbxPersonel_ekle.Visible = false;
            gbxKargo_Listele.Visible = false;
            gbxPersonel_List.Visible = false;

            gnbÜye_Listele.Enabled = false;
            gbxÜye_listele.Visible = true;

            gbxÜye_listele.Location = new Point(x:12,y:105);
            gbxPersonelGuncelle.Visible = false;


            //UyelerListele(sender);

        }

        private void gnbKargo_Listele_Click(object sender, EventArgs e)
        {
            gnbÜye_Listele.Enabled = true;
            gnbPersonel_Ekle.Enabled = true;
            gnbPersonel.Enabled = true;

            gbxÜye_listele.Visible = false;
            gbxPersonel_ekle.Visible = false;
            gbxPersonel_List.Visible = false;

            gnbKargo_Listele.Enabled = false;
            gbxKargo_Listele.Visible = true;

            gbxKargo_Listele.Location = new Point(x: 12, y: 105);
            gbxPersonelGuncelle.Visible = false;


            //KargolarıListele(sender);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            personelGetir();

            gnbÜye_Listele.Enabled = true;
            gnbPersonel_Ekle.Enabled = true;
            gnbKargo_Listele.Enabled = true;

            gbxÜye_listele.Visible = false;
            gbxPersonel_ekle.Visible = false;
            gbxKargo_Listele.Visible = false;

            gnbPersonel.Enabled = false;
            gbxPersonel_List.Visible = true;

            gbxPersonel_List.Location = new Point(x: 12, y: 105);
            gbxPersonel_List.Size = new Size(width:360 ,height:216);

            gbxPersonelGuncelle.Visible = true;
            gbxPersonelGuncelle.Location = new Point(x:375,y:150);
            mstperGuncelTc.Enabled = false;

        }

        void personelGetir()
        {
            using (var baglan = new MySqlConnection(dbcontrol))
            {
                using (var adap = new MySqlDataAdapter("SELECT * FROM personel_olusturma", baglan))
                {
                    try
                    {
                        baglan.Open();
                        DataTable dt = new DataTable();
                        adap.Fill(dt);
                        dgvPersonelListele.DataSource = dt;
                        dgvPersonelListele.Columns[0].HeaderText = "TC Kimlik Bilgiler";
                        dgvPersonelListele.Columns[1].HeaderText = "İsim";
                        dgvPersonelListele.Columns[2].HeaderText = "Soyisim";
                        dgvPersonelListele.Columns[3].HeaderText = "Parola";
                        baglanti.Close();

                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }
        }
        private void dgvUyeListele_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvPersonelListele_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtperGuncelİsim.Text = dgvPersonelListele.CurrentRow.Cells[1].Value.ToString();
            txtperGuncelSoyisim.Text = dgvPersonelListele.CurrentRow.Cells[2].Value.ToString();
            mstperGuncelTc.Text = dgvPersonelListele.CurrentRow.Cells[0].Value.ToString();
            txtperGuncelParola.Text = dgvPersonelListele.CurrentRow.Cells[3].Value.ToString();
        }

        MySqlCommand cmd;

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            cmd = new MySqlCommand("Update personel_olusturma set personel_isim='" + txtperGuncelİsim.Text + "', personel_soyisim='" +
                txtperGuncelSoyisim.Text + "', personel_Tc_Kimlik='" +
                mstperGuncelTc.Text + "', personel_parola='" +
                txtperGuncelParola.Text + "' where personel_Tc_Kimlik='" +
                mstperGuncelTc.Text + "'", baglanti);
            cmd.ExecuteNonQuery();

            int sonuc = cmd.ExecuteNonQuery();
            if (sonuc != 0)
            {
                MessageBox.Show("Personel güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                personelGetir();
                txtperGuncelİsim.Clear();
                txtperGuncelSoyisim.Clear();
                mstperGuncelTc.Clear();
                txtperGuncelParola.Clear();

                baglanti.Close();
            }
            else
            {
                MessageBox.Show("Personel güncellenemedi !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                baglanti.Close();

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            cmd = new MySqlCommand("Delete from personel_olusturma where personel_isim='" + txtperGuncelİsim.Text + "'", baglanti);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Personel Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            personelGetir();
            txtperGuncelİsim.Clear();
            txtperGuncelSoyisim.Clear();
            mstperGuncelTc.Clear();
            txtperGuncelParola.Clear();


            baglanti.Close();






        }

        private void dgvPersonelListele_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }  


}


