using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Futbolmenager2
{
    public partial class KullaniciAnasayfa : Form
    {
        public KullaniciAnasayfa()
        {
            InitializeComponent();
        }
        public string kullanıcı = Giriş.gidenbilgi.ToString();
        private void KullaniciAnasayfa_Load(object sender, EventArgs e)
        {
            lbltakımadı.Text = Giriş.gidenbilgi.ToString();
            takimcek();

        }
        public string t_amblem;
        public void takimcek ()
        {

            SqlConnection baglanti = new SqlConnection("Data Source=TARIK\\SQLEXPRESS;Initial Catalog=Transfer;Integrated Security=True");

            SqlCommand act = new SqlCommand();
            act.Connection = baglanti;

            act.CommandText = "Select*from kulupler where kulup_adi= (select kullanici_kulup from kullanicilar where kullanici_adi='" + lbltakımadı.Text + "')";


            SqlDataReader dr;
            baglanti.Open();
            dr = act.ExecuteReader();

            while (dr.Read())
            {
                t_amblem= dr["kulup_foto"].ToString();
            }

           // pictureBox2.Image = Image.FromFile(t_amblem);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            KullanıcıOyuncular oyuncular = new KullanıcıOyuncular();
                oyuncular.Show();
                KullaniciAnasayfa k1 = new KullaniciAnasayfa();
                k1.Close();

                this.Hide();
        }

        private void BtnTakım_Click(object sender, EventArgs e)
        {
            KullanıcıTakım tkm = new KullanıcıTakım();
            tkm.Show();
            KullaniciAnasayfa k1 = new KullaniciAnasayfa();
            k1.Hide();
            this.Hide();
        }

        private void Lbltakımadı_Click(object sender, EventArgs e)
        {

        }

        private void Btntransfer_Click(object sender, EventArgs e)
        {
          KullanıcıTransferliste liste = new KullanıcıTransferliste();
            liste.Show();
            

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {

        
        }
    }
}
