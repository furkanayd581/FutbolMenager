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
    public partial class AdminKayitliKullanici : Form
    {
        public AdminKayitliKullanici()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=Furkan\\SQLEXPRESS;Initial Catalog=Transfer;Integrated Security=True");

        public void verilerigöster(string veriler)

        {


            SqlDataAdapter da = new SqlDataAdapter(veriler, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            Adminkayitdatagrid.DataSource = ds.Tables[0];

        }
        private void AdminKayitliKullanici_Load(object sender, EventArgs e)
        {

            SqlConnection baglanti = new SqlConnection("Data Source=Furkan\\SQLEXPRESS;Initial Catalog=Transfer;Integrated Security=True");
            baglanti.Open();
            SqlDataAdapter sqlvericekme = new SqlDataAdapter("Select*from kullanicilar", baglanti);
            DataTable sqlVerialma = new DataTable();
            sqlvericekme.Fill(sqlVerialma);
            Adminkayitdatagrid.DataSource = sqlVerialma;
            baglanti.Close();
        }

        private void Silbtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from kullanicilar where kullanici_adi=@kullanıcıadı", baglanti);
            komut.Parameters.AddWithValue("@kullanıcıadı", textBox1.Text);
            komut.ExecuteNonQuery();
            verilerigöster("select*from kullanicilar");
            baglanti.Close();





        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=Furkan\\SQLEXPRESS;Initial Catalog=Transfer;Integrated Security=True");
            baglanti.Open();



            if (comboBox1.Text == "KULLANICIADI")
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select kullanici_ID,kullanici_adi,kullanici_sifre, kullanici_kulup, kullanici_email, kullanici_tipi, kullanici_kayitTarih, kullanici_kurulusTarih from kullanicilar where kullanici_adi like '" + textBox1.Text + "%'", baglanti);
                DataTable data = new DataTable();
                sda.Fill(data);
                Adminkayitdatagrid.DataSource = data;
            }

            else if (comboBox1.Text == "KULLANICIKULUP")
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select kullanici_ID,kullanici_adi,kullanici_sifre, kullanici_kulup, kullanici_email, kullanici_tipi, kullanici_kayitTarih, kullanici_kurulusTarih from kullanicilar where kullanici_kulup like '" + textBox1.Text + "%'", baglanti);
                DataTable data = new DataTable();
                sda.Fill(data);
                Adminkayitdatagrid.DataSource = data;
            }
        }

        private void Adminkayitdatagrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Adminkayitdatagrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                Adminkayitdatagrid.CurrentRow.Selected = true;

                textBox1.Text = Adminkayitdatagrid.CurrentRow.Cells[1].FormattedValue.ToString();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Admin_anasayfa anasayfa = new Admin_anasayfa();
            anasayfa.Show();
            this.Hide();
        }
    }
}
