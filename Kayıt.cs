using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Media;

using System.Windows.Forms;

namespace Futbolmenager2
{
    public partial class Kayıt : Form
    {
        public Kayıt()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=Furkan\\SQLEXPRESS;Initial Catalog=Transfer;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {
            
            axWindowsMediaPlayer1.URL = "C:\\Users\\Lenovo\\Desktop\\FutbolMenager\\Waka Waka.mp3";
        }

        private void Giriş_Click(object sender, EventArgs e)
        {
            DateTime thisDate = DateTime.Today;
            int userprivilages = 0;

            baglanti.Open();
            SqlCommand komut3 = new SqlCommand();
            komut3.Connection = baglanti;

            komut3.CommandText = "Select kullanici_email From kullanicilar  where kullanici_email=@P2";
            komut3.Parameters.AddWithValue("@P2", mailtxt.Text);
            object Kontrol1 = komut3.ExecuteScalar();
            komut3.Parameters.Clear();
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand();
            komut2.Connection = baglanti;

            komut2.CommandText = "Select kullanici_adi From kullanicilar  where kullanici_adi=@P1";
            komut2.Parameters.AddWithValue("@P1", kullanıcıadıtxt.Text);
            object Kontrol = komut2.ExecuteScalar();
            komut2.Parameters.Clear();

            baglanti.Close();



            baglanti.Open();
            SqlCommand komut4 = new SqlCommand();
            komut4.Connection = baglanti;

            komut4.CommandText = "Select kullanici_kulup From kullanicilar  where kullanici_kulup=@P5";
            komut4.Parameters.AddWithValue("@P5", kulüptxt.Text);
            object Kontrol2 = komut4.ExecuteScalar();
            komut4.Parameters.Clear();
            baglanti.Close();
             
            if (Kontrol1 != null)
            {
                emaillbl.Text = "Böyle bir mail var!";

            }

            else if (Kontrol !=null)
            {
                kullanıcıhatalbl.Text = "Böyle bir kullanıcı var! ";

            }

            else if (Kontrol2 !=null)
            {
                kuluphatalbl.Text = "Böyle bir kulüp bulunmaktadır!";
            }
         
            else if (kullanıcıadıtxt.Text.Trim() == string.Empty || sifretxt.Text.Trim() == string.Empty || sifretekrar.Text.Trim() == string.Empty || kulüptxt.Text.Trim() == string.Empty || mailtxt.Text.Trim() == string.Empty )
            {
                label5.Text = "Eksik Bilgiler Girildi.";
                return;
            }
            else if (kullanıcıadıtxt.Text.Length == 15 || sifretxt.Text.Length<5 || sifretekrar.Text.Length <5)
            {

               

            }
            else if(sifretxt.Text != sifretekrar.Text)
            {
                sifrehatalbl.Text = "Şifreler uyuşmuyor";
            }

            else
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into kullanicilar(kullanici_adi,kullanici_sifre" +
               ",kullanici_kulup,kullanici_email,kullanici_tipi,kullanici_kayitTarih,kullanici_kurulusTarih)values" +
               "(@P1,@P2,@P3,@P4,@P5,@P6,@P7)", baglanti);
                komut.Parameters.AddWithValue("@P1", kullanıcıadıtxt.Text);
                komut.Parameters.AddWithValue("@P2", sifretxt.Text);
                komut.Parameters.AddWithValue("@P3", kulüptxt.Text);
                komut.Parameters.AddWithValue("@P4", mailtxt.Text);
                komut.Parameters.AddWithValue("@P5", userprivilages);
                komut.Parameters.AddWithValue("@P6", thisDate);
                komut.Parameters.AddWithValue("@P7", dateTimePicker1.Value);
                komut.ExecuteNonQuery();
                baglanti.Close();

                Giriş grş = new Giriş();
                grş.Show();
                Kayıt k1 = new Kayıt();
                k1.Close();

                this.Hide();
            }     

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (kullanıcıadıtxt.Text.Length == 15)
            {
                kullanıcılbl.Text = "Kullanıcı en fazla 14 karakter alabilir!";
                kullanıcılbl.Visible = true;
            }
            else
            {
                kullanıcılbl.Visible = false;
            }

        }

      
        private void PictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.facebook.com");
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.twitter.com");
        }

   
        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            if (sifretxt.Text.Length < 5)
            {
                sifrelbl.Text = "Şifre en az 5 karakterden oluşmaktadır!";
                sifrelbl.Visible = true;
            }
            else
            {

                sifrelbl.Visible = false;
            }
        }


        private void Sifretekrar_TextChanged(object sender, EventArgs e)
        {
            if (sifretekrar.Text.Length < 5)
            {
                sifretekrarlbl.Text = "Şifre en az 5 karakter alabilir!";
                sifretekrarlbl.Visible = true;
            }
            else
            {
                sifretekrarlbl.Visible = false;
            }

        }

        private void txtmail(object sender, EventArgs e)
        {
            string pattern = @"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";


            if (Regex.IsMatch(mailtxt.Text,pattern ))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.mailtxt, "E posta hatalı!");
                return;
            }
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.instagram.com");
        }
    }
}

