using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Futbolmenager2
{
    public partial class şifremiunuttum : Form
    {
        public şifremiunuttum()
        {
            InitializeComponent();
        }

        private void Şifremiunuttum_Load(object sender, EventArgs e)
        {

        }
       string sifre;
      
        private void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=TARIK\\SQLEXPRESS;Initial Catalog=Transfer;Integrated Security=True");
            
            SqlCommand act = new SqlCommand();
            act.Connection = baglanti;
           
            act.CommandText = "select * from kullanicilar where kullanici_email = '"+ sifremiunuttumtxt.Text+"'";


            SqlDataReader dr;
            baglanti.Open();
            dr = act.ExecuteReader();
            
            while (dr.Read())
            {
                sifre = dr["kullanici_sifre"].ToString();
            }
            

           
            SmtpClient sc = new SmtpClient();
            sc.Port = 587;
            sc.Host = "smtp.gmail.com";
            sc.EnableSsl = true;

            sc.Credentials = new NetworkCredential("info.footballmenager@gmail.com", "b6948e79");
            MailMessage mail = new MailMessage();

            mail.From = new MailAddress("info.footballmenager@gmail.com", "Football Menager");

            mail.To.Add(sifremiunuttumtxt.Text);
            mail.Subject = "FM şifre bildirimi";
            mail.IsBodyHtml = true;
            mail.Body = "Şifreniz" +sifre + " dır. ";
            sc.Send(mail);
        }
    }
}
