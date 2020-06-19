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
    public partial class AdminTransferListe : Form
    {
        public AdminTransferListe()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=Furkan\\SQLEXPRESS;Initial Catalog=Transfer;Integrated Security=True");
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=Furkan\\SQLEXPRESS;Initial Catalog=Transfer;Integrated Security=True");
            baglanti.Open();




            if (comboBox1.Text == "ADİ")
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select Transfer_ID, Transfer_no, Transfer_adi, Transfer_soyadi, Transfer_yas, Transfer_mevki, Transfer_ayak, Transfer_kulup, Transfer_satis_fiyati, Transfer_satis_durumu, Transfer_boy, Transfer_uyruk,sporcu_ID from Transferliste where Transfer_adi like '" + aramatxt.Text + "%'", baglanti);
                DataTable data = new DataTable();
                sda.Fill(data);
                admintrnsferdtagrid.DataSource = data;
            }

            else if (comboBox1.Text == "SOYADİ")
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select Transfer_ID, Transfer_no, Transfer_adi, Transfer_soyadi, Transfer_yas, Transfer_mevki, Transfer_ayak, Transfer_kulup, Transfer_satis_fiyati, Transfer_satis_durumu, Transfer_boy, Transfer_uyruk,sporcu_ID from Transferliste where Transfer_soyadi like '" + aramatxt.Text + "%'", baglanti);
                DataTable data = new DataTable();
                sda.Fill(data);
                admintrnsferdtagrid.DataSource = data;
            }

            else if (comboBox1.Text == "YAS")
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select Transfer_ID, Transfer_no, Transfer_adi, Transfer_soyadi, Transfer_yas, Transfer_mevki, Transfer_ayak, Transfer_kulup, Transfer_satis_fiyati, Transfer_satis_durumu, Transfer_boy, Transfer_uyruk,sporcu_ID from Transferliste where Transfer_yas like '" + aramatxt.Text + "%'", baglanti);
                DataTable data = new DataTable();
                sda.Fill(data);
                admintrnsferdtagrid.DataSource = data;
            }

            else if (comboBox1.Text == "MEVKİ")
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select Transfer_ID, Transfer_no, Transfer_adi, Transfer_soyadi, Transfer_yas, Transfer_mevki, Transfer_ayak, Transfer_kulup, Transfer_satis_fiyati, Transfer_satis_durumu, Transfer_boy, Transfer_uyruk,sporcu_ID from Transferliste where Transfer_mevki like '" + aramatxt.Text + "%'", baglanti);
                DataTable data = new DataTable();
                sda.Fill(data);
                admintrnsferdtagrid.DataSource = data;
            }

            else if (comboBox1.Text == "AYAK")
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select Transfer_ID, Transfer_no, Transfer_adi, Transfer_soyadi, Transfer_yas, Transfer_mevki, Transfer_ayak, Transfer_kulup, Transfer_satis_fiyati, Transfer_satis_durumu, Transfer_boy, Transfer_uyruk,sporcu_ID from Transferliste where Transfer_ayak like '" + aramatxt.Text + "%'", baglanti);
                DataTable data = new DataTable();
                sda.Fill(data);
                admintrnsferdtagrid.DataSource = data;
            }


            else if (comboBox1.Text == "KULUP")
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select Transfer_ID, Transfer_no, Transfer_adi, Transfer_soyadi, Transfer_yas, Transfer_mevki, Transfer_ayak, Transfer_kulup, Transfer_satis_fiyati, Transfer_satis_durumu, Transfer_boy, Transfer_uyruk,sporcu_ID from Transferliste where Transfer_kulup like '" + aramatxt.Text + "%'", baglanti);
                DataTable data = new DataTable();
                sda.Fill(data);
                admintrnsferdtagrid.DataSource = data;
            }
            else if (comboBox1.Text == "SATİSFİYAT")
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select Transfer_ID, Transfer_no, Transfer_adi, Transfer_soyadi, Transfer_yas, Transfer_mevki, Transfer_ayak, Transfer_kulup, Transfer_satis_fiyati, Transfer_satis_durumu, Transfer_boy, Transfer_uyruk,sporcu_ID from Transferliste where Transfer_satis_fiyat like '" + aramatxt.Text + "%'", baglanti);
                DataTable data = new DataTable();
                sda.Fill(data);
                admintrnsferdtagrid.DataSource = data;
            }

            else if (comboBox1.Text == "BOY")
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select Transfer_ID, Transfer_no, Transfer_adi, Transfer_soyadi, Transfer_yas, Transfer_mevki, Transfer_ayak, Transfer_kulup, Transfer_satis_fiyati, Transfer_satis_durumu, Transfer_boy, Transfer_uyruk,sporcu_ID from Transferliste where Transfer_boy like '" + aramatxt.Text + "%'", baglanti);
                DataTable data = new DataTable();
                sda.Fill(data);
                admintrnsferdtagrid.DataSource = data;
            }

            else if (comboBox1.Text == "UYRUK")
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select Transfer_ID, Transfer_no, Transfer_adi, Transfer_soyadi, Transfer_yas, Transfer_mevki, Transfer_ayak, Transfer_kulup, Transfer_satis_fiyati, Transfer_satis_durumu, Transfer_boy, Transfer_uyruk,sporcu_ID from Transferliste where Transfer_uyruk like '" + aramatxt.Text + "%'", baglanti);
                DataTable data = new DataTable();
                sda.Fill(data);
                admintrnsferdtagrid.DataSource = data;
            }
        }

        private void AdminTransferListe_Load(object sender, EventArgs e)
        {
            KullaniciAnasayfa ka = new KullaniciAnasayfa();
            String oyuncular = ka.kullanıcı.ToString();
            SqlConnection baglanti = new SqlConnection("Data Source=Furkan\\SQLEXPRESS;Initial Catalog=Transfer;Integrated Security=True");
            baglanti.Open();
            SqlDataAdapter sqlvericekme = new SqlDataAdapter("Select*from Transferliste", baglanti);
            DataTable sqlVerialma = new DataTable();

            sqlvericekme.Fill(sqlVerialma);
            admintrnsferdtagrid.DataSource = sqlVerialma;
            baglanti.Close();
        }

        public void admintransferlistecekme()
        {
            KullaniciAnasayfa ka = new KullaniciAnasayfa();
            String oyuncular = ka.kullanıcı.ToString();
            baglanti.Open();

            SqlDataAdapter sqlvericekme = new SqlDataAdapter("Select * from Transferliste", baglanti);
            DataTable sqlVerialma = new DataTable();

            sqlvericekme.Fill(sqlVerialma);
            admintrnsferdtagrid.DataSource = sqlVerialma;
            baglanti.Close();

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Admin_anasayfa anasayfa = new Admin_anasayfa();
            anasayfa.Show();
            this.Hide();
        }
        public string trnsfr;
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from Transferliste where sporcu_ID=@sporcu_id", baglanti);
            komut.Parameters.AddWithValue("@sporcu_id", trnsfr);
            komut.ExecuteNonQuery();
            komut.Parameters.Clear();
            baglanti.Close();
            admintransferlistecekme();


        }

        private void admintrnsferdtagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            trnsfr= admintrnsferdtagrid.CurrentRow.Cells[12].FormattedValue.ToString();
        }
    }
}


