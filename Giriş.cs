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
        public Giriş()
        {
            InitializeComponent();
           
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-1ONI7GL\\SQLEXPRESS;Initial Catalog=Transfer;Integrated Security=True");
        private void Giriş_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.UserName!=string.Empty)
            {
                kullanicigrş.Text = Properties.Settings.Default.UserName;
                
            }
        }

        private void Button1_Click(object sender, EventArgs e)

        {

            

            string userName = kullanicigrş.Text;
            baglanti.Open();
            SqlCommand check_User_Name = new SqlCommand("SELECT count(*) FROM kullanicilar WHERE kullanici_adi = '"+userName+"' and kullanici_tipi=1", baglanti);
            check_User_Name.Parameters.AddWithValue("@kullanici_adi", userName);
            int UserExist = (int)check_User_Name.ExecuteScalar();
            if (UserExist > 0)
            {
              
                Admin_anasayfa kayıt = new Admin_anasayfa();
                kayıt.Show();

                Giriş grş = new Giriş();
                grş.Close();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Admin Değil.");
                //Üyelik sayfası burada yönelndirilcek
            }

        


            baglanti.Close();


            //select * from kullanicilar where kullanici_adi='furkan.aydogdu' and kullanici_tipi=1 

          

            if (BeniHatirla.Checked == true)
            {
                Properties.Settings.Default.UserName = kullanicigrş.Text;
              
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
