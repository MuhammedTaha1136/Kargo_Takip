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
    public partial class kargo_ekle : Form
    {
        public kargo_ekle()
        {
            InitializeComponent();
        }

        
        MySqlConnection kargo_baglanti = new MySqlConnection(
            "Server=localhost;Database=kargo_takip;Uid=root;Pwd=36_1107_34"
            );


        private void kargo_ekle_Load(object sender, EventArgs e)
        {
            txtFaturaNo.Enabled = false;
            
            Random sayi = new Random();
            int rastgelesayi = sayi.Next(10000, 99990);
            txtFaturaNo.Text = rastgelesayi.ToString();

            try
            {
                kargo_baglanti.Open();
                
            }
            catch (Exception bilgi)
            {

                MessageBox.Show("Hata meydana geldi. Hata :" + bilgi.Message.ToString());
            }
            
        }

        private void btnKargo_Ekle_Click(object sender, EventArgs e)
        {
            
            try
            {

                MySqlCommand com = new MySqlCommand();
                com.CommandText = "insert into kargo_ekleme(Fatura_no, urun, adet, gonderilen_il, alınacak_il, gonderen_tcno, gonderen_adı, gonderen_soyadı, alıcı_tcno, alıcı_adı, alıcı_soyadı)" +
                                 " values('" + txtFaturaNo.Text + "','" +  cmbUrun.SelectedItem + "' , '" + txtAdet.Text + "' ,'" + cmbgönder_il.SelectedItem + "', '" + cmbalınacak_il.SelectedItem + "', '" + mstGönderen_Tc.Text + "' , " +
                                 "'" + txtGönderen_Adı.Text + "' , '" + txtGönderen_Soyadı.Text + "' , '" + mskAlıcıTc.Text + "' , '" + txtAlıcıAdı.Text + "' , '" + txtAlıcıSoyadı.Text + "')";

                com.Connection = kargo_baglanti;
                com.ExecuteNonQuery();

            }
            catch (Exception ayıkla)
            {

                MessageBox.Show(ayıkla.Message);
            }
            



            if (mstGönderen_Tc.Text == "" || txtGönderen_Adı.Text == "" || txtGönderen_Soyadı.Text == "" || mskAlıcıTc.Text == "" || txtAlıcıAdı.Text == "" || txtAlıcıSoyadı.Text == "" || txtAdet.Text == "" || txtAğırlık.Text == "")
            {
                MessageBox.Show("Boş bilgiler var", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Kargonuz başarıyla eklenmiştir.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtFaturaNo.Enabled = false;
               
                mstGönderen_Tc.Clear();
                txtGönderen_Adı.Clear();
                txtGönderen_Soyadı.Clear();
                mskAlıcıTc.Clear();
                txtAlıcıAdı.Clear();
                txtAlıcıSoyadı.Clear();
                txtFaturaNo.Clear();
                txtAdet.Clear();
                txtAğırlık.Clear();

                Random sayi = new Random();
                int rastgelesayi = sayi.Next(10000, 99990);
                txtFaturaNo.Text = rastgelesayi.ToString();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void kargo_ekle_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

       

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
           

            

            
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            Random hesap = new Random();
            int rsthesap = hesap.Next(20, 50);
            lblUcret.Text = hesap.ToString();

        }
    }
}
