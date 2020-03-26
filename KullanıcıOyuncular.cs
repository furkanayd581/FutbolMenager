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
    public partial class KullanıcıOyuncular : Form
    {
        public KullanıcıOyuncular()
        {
            InitializeComponent();
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-1ONI7GL\\SQLEXPRESS;Initial Catalog=Transfer;Integrated Security=True");
        }
      
        private void KullanıcıOyuncular_Load(object sender, EventArgs e)
        {
            KullaniciAnasayfa ka = new KullaniciAnasayfa();
            String oyuncular = ka.kullanıcı.ToString();
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-1ONI7GL\\SQLEXPRESS;Initial Catalog=Transfer;Integrated Security=True");
            baglanti.Open();
            SqlDataAdapter sqlvericekme = new SqlDataAdapter("Select*from sporcular where sporcu_kulup= (select kullanici_kulup from kullanicilar where kullanici_adi='"+oyuncular.ToString()+"')" , baglanti);
            DataTable sqlVerialma = new DataTable();

            sqlvericekme.Fill(sqlVerialma);

            KullanıcıDatagrid.DataSource = sqlVerialma;
            baglanti.Close();

        }
    }
}
