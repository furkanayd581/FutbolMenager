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
    public partial class AdminOyuncular : Form
    {
        public AdminOyuncular()
        {
            InitializeComponent();
        }


        public void verilerigöster(string veriler)

        {
            SqlConnection baglanti = new SqlConnection("Data Source=TARIK\\SQLEXPRESS;Initial Catalog=Transfer;Integrated Security=True");
            baglanti.Open();

            SqlDataAdapter da = new SqlDataAdapter(veriler, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            OyuncularDataGrid.DataSource = ds.Tables[0];

        }



        private void AdminOyuncular_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=TARIK\\SQLEXPRESS;Initial Catalog=Transfer;Integrated Security=True");
            baglanti.Open();
            SqlDataAdapter sqlvericekme = new SqlDataAdapter("Select*from sporcular", baglanti);
            DataTable sqlVerialma = new DataTable();
            sqlvericekme.Fill(sqlVerialma);
            OyuncularDataGrid.DataSource = sqlVerialma;
            baglanti.Close();


        }

        private void aramatxt_TextChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=TARIK\\SQLEXPRESS;Initial Catalog=Transfer;Integrated Security=True");
            baglanti.Open();




            if (comboBox1.Text == "ADI")
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select sporcu_ID,sporcu_no,sporcu_adi, sporcu_soyadi, sporcu_yas, sporcu_mevki, sporcu_ayak, sporcu_kulup, sporcu_satis_fiyati, sporcu_satis_durumu,sporcu_boy,sporcu_uyruk from sporcular where sporcu_adi like '" + aramatxt.Text + "%'", baglanti);
                DataTable data = new DataTable();
                sda.Fill(data);
                OyuncularDataGrid.DataSource = data;
            }

            else if (comboBox1.Text == "SOYADI")
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select sporcu_ID,sporcu_no,sporcu_adi, sporcu_soyadi, sporcu_yas, sporcu_mevki, sporcu_ayak, sporcu_kulup, sporcu_satis_fiyati, sporcu_satis_durumu,sporcu_boy,sporcu_uyruk from sporcular where sporcu_soyadi like '" + aramatxt.Text + "%'", baglanti);
                DataTable data = new DataTable();
                sda.Fill(data);
                OyuncularDataGrid.DataSource = data;
            }
            else if (comboBox1.Text == "YAS")
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select sporcu_ID,sporcu_no,sporcu_adi, sporcu_soyadi, sporcu_yas, sporcu_mevki, sporcu_ayak, sporcu_kulup, sporcu_satis_fiyati, sporcu_satis_durumu,sporcu_boy,sporcu_uyruk from sporcular where sporcu_yas like '" + aramatxt.Text + "%'", baglanti);
                DataTable data = new DataTable();
                sda.Fill(data);
                OyuncularDataGrid.DataSource = data;
            }

            else if (comboBox1.Text == "MEVKİ")
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select sporcu_ID,sporcu_no,sporcu_adi, sporcu_soyadi, sporcu_yas, sporcu_mevki, sporcu_ayak, sporcu_kulup, sporcu_satis_fiyati, sporcu_satis_durumu,sporcu_boy,sporcu_uyruk from sporcular where sporcu_mevki like '" + aramatxt.Text + "%'", baglanti);
                DataTable data = new DataTable();
                sda.Fill(data);
                OyuncularDataGrid.DataSource = data;
            }

            else if (comboBox1.Text == "AYAK")
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select sporcu_ID,sporcu_no,sporcu_adi, sporcu_soyadi, sporcu_yas, sporcu_mevki, sporcu_ayak, sporcu_kulup, sporcu_satis_fiyati, sporcu_satis_durumu,sporcu_boy,sporcu_uyruk from sporcular where sporcu_ayak like '" + aramatxt.Text + "%'", baglanti);
                DataTable data = new DataTable();
                sda.Fill(data);
                OyuncularDataGrid.DataSource = data;
            }

            else if (comboBox1.Text == "KULUP")
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select sporcu_ID,sporcu_no,sporcu_adi, sporcu_soyadi, sporcu_yas, sporcu_mevki, sporcu_ayak, sporcu_kulup, sporcu_satis_fiyati, sporcu_satis_durumu,sporcu_boy,sporcu_uyruk from sporcular where sporcu_kulup like '" + aramatxt.Text + "%'", baglanti);
                DataTable data = new DataTable();
                sda.Fill(data);
                OyuncularDataGrid.DataSource = data;
            }
            else if (comboBox1.Text == "SATISFİYAT")
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select sporcu_ID,sporcu_no,sporcu_adi, sporcu_soyadi, sporcu_yas, sporcu_mevki, sporcu_ayak, sporcu_kulup, sporcu_satis_fiyati, sporcu_satis_durumu,sporcu_boy,sporcu_uyruk from sporcular where sporcu_satis_fiyat like '" + aramatxt.Text + "%'", baglanti);
                DataTable data = new DataTable();
                sda.Fill(data);
                OyuncularDataGrid.DataSource = data;
            }

            else if (comboBox1.Text == "SATISDURUM")
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select sporcu_ID,sporcu_no,sporcu_adi, sporcu_soyadi, sporcu_yas, sporcu_mevki, sporcu_ayak, sporcu_kulup, sporcu_satis_fiyati, sporcu_satis_durumu,sporcu_boy,sporcu_uyruk from sporcular where sporcu_satis_durumu like '" + aramatxt.Text + "%'", baglanti);
                DataTable data = new DataTable();
                sda.Fill(data);
                OyuncularDataGrid.DataSource = data;
            }



            else if (comboBox1.Text == "BOY")
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select sporcu_ID,sporcu_no,sporcu_adi, sporcu_soyadi, sporcu_yas, sporcu_mevki, sporcu_ayak, sporcu_kulup, sporcu_satis_fiyati, sporcu_satis_durumu,sporcu_boy,sporcu_uyruk from sporcular where sporcu_boy  like '" + aramatxt.Text + "%'", baglanti);
                DataTable data = new DataTable();
                sda.Fill(data);
                OyuncularDataGrid.DataSource = data;
            }

            else if (comboBox1.Text == "UYRUK")
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select sporcu_ID,sporcu_no,sporcu_adi, sporcu_soyadi, sporcu_yas, sporcu_mevki, sporcu_ayak, sporcu_kulup, sporcu_satis_fiyati, sporcu_satis_durumu,sporcu_boy,sporcu_uyruk from sporcular where sporcu_uyruk like '" + aramatxt.Text + "%'", baglanti);
                DataTable data = new DataTable();
                sda.Fill(data);
                OyuncularDataGrid.DataSource = data;
            }














        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=TARIK\\SQLEXPRESS;Initial Catalog=Transfer;Integrated Security=True");
            baglanti.Open();



            SqlCommand komut = new SqlCommand("insert into sporcular(sporcu_no,sporcu_adi, sporcu_soyadi, sporcu_yas, sporcu_mevki, sporcu_ayak, sporcu_kulup, sporcu_satis_fiyati, sporcu_satis_durumu,sporcu_boy,sporcu_uyruk)values(@sporcuno,@sporcuadi,@sporcusoyadi,@sporcuyas,@sporcumevki,@sporcuayak,@sporcukulup,@sporcusatisfiyati,@sporcusatisdurumu,@sporcuboy,@sporcuuyruk)", baglanti);

            komut.Parameters.AddWithValue("@sporcuno", no.Text);
            komut.Parameters.AddWithValue("@sporcuadi", adi.Text);
            komut.Parameters.AddWithValue("@sporcusoyadi", soyadi.Text);
            komut.Parameters.AddWithValue("@sporcuyas", yas.Text);
            komut.Parameters.AddWithValue("@sporcumevki", mevki.Text);
            komut.Parameters.AddWithValue("@sporcuayak", ayak.Text);
            komut.Parameters.AddWithValue("@sporcukulup", kulüp.Text);
            komut.Parameters.AddWithValue("@sporcusatisfiyati", satış.Text);
            komut.Parameters.AddWithValue("@sporcusatisdurumu", durum.Text);
            komut.Parameters.AddWithValue("@sporcuboy", boy.Text);
            komut.Parameters.AddWithValue("@sporcuuyruk", uyruk.Text);
            komut.ExecuteNonQuery();
            verilerigöster("select*from sporcular");
            
            baglanti.Close();

            no.Clear();
            adi.Clear();
            soyadi.Clear();
            yas.Clear();
            mevki.Clear();
            ayak.Clear();
            kulüp.Clear();
            satış.Clear();
            durum.Clear();
            boy.Clear();
            uyruk.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            SqlConnection baglanti = new SqlConnection("Data Source=TARIK\\SQLEXPRESS;Initial Catalog=Transfer;Integrated Security=True");
            baglanti.Open();


            SqlCommand komut = new SqlCommand("delete from sporcular where sporcu_adi=@sporcuadi", baglanti);
            komut.Parameters.AddWithValue("@sporcuadi", adi.Text);
            komut.ExecuteNonQuery();
            verilerigöster("select*from sporcular");
            baglanti.Close();
            no.Clear();
            adi.Clear();
            soyadi.Clear();
            yas.Clear();
            mevki.Clear();
            ayak.Clear();
            kulüp.Clear();
            satış.Clear();
            durum.Clear();
            boy.Clear();
            uyruk.Clear();
        }

        private void OyuncularDataGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (OyuncularDataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                OyuncularDataGrid.CurrentRow.Selected = true;

                no.Text = OyuncularDataGrid.CurrentRow.Cells[1].FormattedValue.ToString();
                adi.Text = OyuncularDataGrid.CurrentRow.Cells[2].FormattedValue.ToString();
                soyadi.Text = OyuncularDataGrid.CurrentRow.Cells[3].FormattedValue.ToString();
                yas.Text = OyuncularDataGrid.CurrentRow.Cells[4].FormattedValue.ToString();
                mevki.Text = OyuncularDataGrid.CurrentRow.Cells[5].FormattedValue.ToString();
                ayak.Text = OyuncularDataGrid.CurrentRow.Cells[6].FormattedValue.ToString();
                kulüp.Text = OyuncularDataGrid.CurrentRow.Cells[7].FormattedValue.ToString();
                satış.Text = OyuncularDataGrid.CurrentRow.Cells[8].FormattedValue.ToString();
                durum.Text = OyuncularDataGrid.CurrentRow.Cells[9].FormattedValue.ToString();
                boy.Text = OyuncularDataGrid.CurrentRow.Cells[10].FormattedValue.ToString();
                uyruk.Text = OyuncularDataGrid.CurrentRow.Cells[11].FormattedValue.ToString();


            }
        }
    }
}
