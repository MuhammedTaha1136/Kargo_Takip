using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace kargo_takip
{
    public class metot
    {
        string Constr = "Server=localhost;Database=kargo_takip;Uid=root;Pwd=36_1107_34";

        public int Kullanici_Kontrol(string tc_no, string passaword)
        {
            int sonuc = 0;
            using (var con = new MySqlConnection(Constr))
            {
                using (var cmd = new MySqlCommand($"SELECT Tc_Kimlik_Bilgiler, Parola FROM uye_olusturma WHERE Tc_Kimlik_Bilgiler='{tc_no}' AND Parola='{passaword}'",con))
                {
                    try
                    {
                        cmd.Connection.Open();
                        MySqlDataReader dtr = cmd.ExecuteReader();
                        if (dtr.Read())
                        {
                            string d_tc = dtr["Tc_Kimlik_Bilgiler"].ToString();
                            string d_psw = dtr["Parola"].ToString();
                            if (d_tc==tc_no && d_psw==passaword)
                            {
                                sonuc = 1;
                            }
                            else
                            {
                                sonuc = 0;
                            }

                        }
                    }
                    catch 
                    {
                        sonuc = 0;
                        
                    }
                }
            }
            return sonuc;
 
        }
        public int giris_kontrol(string isim, string parola)
        {
            int sonuc = 0;
            using (var con = new MySqlConnection(Constr))
            {
                using (var cmd = new MySqlCommand($"SELECT personel_isim, personel_parola FROM personel_olusturma WHERE personel_isim='{isim}' AND personel_parola='{parola}'", con))
                {
                    try
                    {
                        cmd.Connection.Open();
                        MySqlDataReader dtr = cmd.ExecuteReader();
                        if (dtr.Read())
                        {
                            string isim_bilgileri= dtr["personel_isim"].ToString();
                            string parola_bilgileri = dtr["personel_parola"].ToString();
                            if (isim_bilgileri == isim && parola_bilgileri == parola)
                            {
                                sonuc = 1;
                            }
                            else
                            {
                                sonuc = 0;
                            }

                        }
                    }
                    catch
                    {
                        sonuc = 0;

                    }
                }
            }
            return sonuc;
        }
        
        public int kargo_takip_kontrol(string fatura_no)
        {
            int sonuc = 0;
            using (var con = new MySqlConnection(Constr))
            {
                using (var cmd = new MySqlCommand($"SELECT Fatura_no FROM kargo_ekleme WHERE Fatura_no='{fatura_no}'", con))
                {
                    try
                    {
                        cmd.Connection.Open();
                        MySqlDataReader dtr = cmd.ExecuteReader();
                        if (dtr.Read())
                        {
                            string fatura_no_kod = dtr["Fatura_no"].ToString();
                            if (fatura_no_kod == fatura_no)
                            {
                                sonuc = 1;
                            }
                            else
                            {
                                sonuc = 0;
                            }

                        }
                    }
                    catch
                    {
                        sonuc = 0;

                    }
                }
            }
         return sonuc;

        }

        public int personel_giris_kontrol(string Tc_no, string parola)
        {
            int sonuc = 0;
            using (var con = new MySqlConnection(Constr))
            {
                using (var cmd = new MySqlCommand($"SELECT personel_Tc_Kimlik, personel_parola FROM personel_olusturma WHERE personel_Tc_Kimlik='{Tc_no}' AND personel_parola='{parola}'", con))
                {
                    try
                    {
                        cmd.Connection.Open();
                        MySqlDataReader dtr = cmd.ExecuteReader();
                        if (dtr.Read())
                        {
                            string Tc_kimlik_bilgiler = dtr["personel_Tc_Kimlik"].ToString();
                            string parola_bilgiler = dtr["personel_parola"].ToString();
                            if (Tc_kimlik_bilgiler == Tc_no && parola_bilgiler == parola)
                            {
                                sonuc = 1;
                            }
                            else
                            {
                                sonuc = 0;
                            }

                        }
                    }
                    catch
                    {
                        sonuc = 0;

                    }
                }
            }
            return sonuc;
        }

    }
}
