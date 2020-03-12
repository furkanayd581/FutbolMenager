using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Futbolmenager2
{
    public partial class Giriş : Form
    {
        public static string gidenbilgi = "";

        public Giriş()
        {
            InitializeComponent();
           
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-1ONI7GL\\SQLEXPRESS;Initial Catalog=Transfer;Integrated Security=True");
        
        private void Giriş_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.UserName!=string.Empty)
            {
                kullanicigrştxt.Text = Properties.Settings.Default.UserName;
                
            }
        }

        private void Button1_Click(object sender, EventArgs e)

        {
            gidenbilgi = kullanicigrştxt.Text;

            try
            {
                
                SqlCommand cmd = new SqlCommand("select kullanici_tipi from kullanicilar where kullanici_adi = @KAdi and kullanici_sifre = @KParola", baglanti);
                cmd.Parameters.AddWithValue("@KAdi", kullanicigrştxt.Text);
                cmd.Parameters.AddWithValue("@KParola", sifregrştxt.Text);
                cmd.Connection.Open();
                SqlDataReader rd = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                if (rd.HasRows) // Girilen K.Adı ve K.Parola Dahilinde Gelen Data var ise 
                {
                    while (rd.Read()) // reader Okuyabiliyorsa
                    {
                        if (rd["kullanici_tipi"].ToString() == "1") // 1 Rolü Admin'e ait olarak Ayarlanmışdır
                        {
                            // Kullanıcı Rolü 1 ise Admin Ekranı Aç 
                            Admin_anasayfa admin = new Admin_anasayfa();
                            admin.Show();
                            this.Hide();
                           
                            

                        }
                        else
                        {
                            // Kullanıcı Rolü 1 dışında ise Kullanıcı Ekranı Aç
                            KullaniciAnasayfa kul = new KullaniciAnasayfa();
                            kul.Show();
                            this.Hide();
                        }
                    }
                }
                else /// Reader SATIR döndüremiyorsa K.Adı Parola Yanlış Demekdir
                {
                    rd.Close();
                    girishatalbl.Text = "Kullanıcı adı veya Parola geçersizdir! ";
                }
            }
            catch // Bağlantı açamayıp Sorgu Çalıştıramıyorsa Veritabanına Ulaşamıyor Demekdir
            {
                MessageBox.Show("DB ye ulaşılamadı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


          
      



            baglanti.Close();


            
    


            if (BeniHatirla.Checked == true)
            {
                Properties.Settings.Default.UserName = kullanicigrştxt.Text;
              
                Properties.Settings.Default.Save();
            }
            if (BeniHatirla.Checked==false)
            {
                Properties.Settings.Default.UserName = "";
              
            }



          

         
        }

     
       

      
        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            şifremiunuttum şifre = new şifremiunuttum();
            şifre.Show();

            Giriş grş = new Giriş();
            grş.Close();
            this.Hide();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
        }

        private void LinkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Kayıt kayıt = new Kayıt();
            kayıt.Show();

            Giriş grş = new Giriş();
            grş.Close();
            this.Hide();

        }
    }
}
