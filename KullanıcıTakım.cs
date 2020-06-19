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
    public partial class KullanıcıTakım : Form
    {
        public KullanıcıTakım()
        {
            InitializeComponent();
            SqlConnection baglanti = new SqlConnection("Data Source=Furkan\\SQLEXPRESS;Initial Catalog=Transfer;Integrated Security=True");
        }

        private void KullanıcıTakım_Load(object sender, EventArgs e)
        {
            KullaniciAnasayfa ka = new KullaniciAnasayfa();
            String takım = ka.kullanıcı.ToString();
            SqlConnection baglanti = new SqlConnection("Data Source=Furkan\\SQLEXPRESS;Initial Catalog=Transfer;Integrated Security=True");
            baglanti.Open();
            SqlDataAdapter sqlvericekme = new SqlDataAdapter("Select*from kulupler where kulup_adi= (select kullanici_kulup from kullanicilar where kullanici_adi='" + takım.ToString() + "')", baglanti);
            DataTable sqlVerialma = new DataTable();
            sqlvericekme.Fill(sqlVerialma);
            Takımdatagridview.DataSource = sqlVerialma;
            baglanti.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            KullaniciAnasayfa anasayfa = new KullaniciAnasayfa();
            anasayfa.Show();
            this.Hide();
        }
    }
}
