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
    public partial class Kargo_Takip : Form
    {
        metot mtt= new metot();

        public Kargo_Takip()
        {
            InitializeComponent();
        }
        MySqlConnection baglanti = new MySqlConnection("Server = localhost; Database=kargo_takip;Uid=root;Pwd=36_1107_34");

        private void Kargo_Takip_Load(object sender, EventArgs e)
        {
            baglanti.Open();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (mtt.kargo_takip_kontrol(txtFatura_no_kontrol.Text) == 1)
            {
                this.timer1.Start();

                MySqlCommand komut = new MySqlCommand("select * from kargo_ekleme where Fatura_no like '" + txtFatura_no_kontrol.Text + "'", baglanti);
                MySqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    txtAdı.Text = read["gonderen_adı"].ToString();
                    txtAlıcıİsim.Text = read["alıcı_adı"].ToString();
                    txtAlıcıTcBilgi.Text = read["alıcı_tcno"].ToString();
                    txtTcBilgi.Text = read["gonderen_tcno"].ToString();
                    txtSube.Text = read["gonderilen_il"].ToString();
                    txtAlıcıSube.Text = read["alınacak_il"].ToString();
                    lblUrun.Text = read["urun"].ToString();

                    // Kargonun durumunu ayarladık.
                    string[] Bulundugu_yer = new string[3];
                    Bulundugu_yer[0]= "Şubede";
                    Bulundugu_yer[1]= "Yola Çıktı";
                    Bulundugu_yer[2]= "Teslim Edildi";

                    Random yer = new Random();
                    int rastgele = yer.Next(0, Bulundugu_yer.Length);
                    lblBulunduğu_yer.Text = Bulundugu_yer[rastgele];


                    // Tahmini varış süresini ayarladık.
                    string[] tahmini_varıs = new string[6];
                    tahmini_varıs[0] = "3 Saat";
                    tahmini_varıs[1] = "5 Saat"; 
                    tahmini_varıs[2] = "7 Saat";
                    tahmini_varıs[3] = "9 Saat";
                    tahmini_varıs[4] = "12 Saat";
                    tahmini_varıs[5] = "En geç 2 gün";

                    Random var = new Random();
                    int varıs = var.Next(0, tahmini_varıs.Length);
                    lblVarışTarihi.Text = tahmini_varıs[varıs];
                    
                    if (lblBulunduğu_yer.Text== "Teslim Edildi")
                    {
                        lblVarışTarihi.Text = "Teslim Edildi";
                    }

                    if (lblBulunduğu_yer.Text== "Şubede")
                    {
                        lblVarışTarihi.Text = "Şubede";
                    }


                }

            }
            else if (txtFatura_no_kontrol.TextLength > 5 || txtFatura_no_kontrol.TextLength < 5)
            {
                MessageBox.Show("Lütfen 5 haneli" + "\n" +
                                "kargo takip numaranızı giriniz.");

            }
            else
            {
                MessageBox.Show("Fatura no hatalı", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
        }

        
    }
}
