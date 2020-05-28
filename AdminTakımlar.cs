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
    public partial class AdminTakımlar : Form
    {
        public AdminTakımlar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=TARIK\\SQLEXPRESS;Initial Catalog=Transfer;Integrated Security=True");
        

        public void verilerigöster(string veriler)
           
        {

            
            SqlDataAdapter da = new SqlDataAdapter(veriler, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            Takımlardatagrid.DataSource = ds.Tables[0];

        }
        

       

        private void Takımbtn_Click(object sender, EventArgs e)
        {
            verilerigöster("Select*from kulupler");  
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into kulupler(kulup_adi,kulup_acilis_tarihi,kulup_foto,kulup_sampiyonluk,kulup_toplamDeger,kulup_lig,stadyum)values(@kulupadı,@kulupacilis,@kulupfoto,@kulupsampiyonluk,@kulupdeger,@kuluplig,@Stadyum)", baglanti);
            
            komut.Parameters.AddWithValue("@kulupadı", kulupaditxt.Text);
            komut.Parameters.AddWithValue("@kulupacilis", kuluptarihtxt.Text);
            komut.Parameters.AddWithValue("@kulupfoto", resimekletxt.Text);
            komut.Parameters.AddWithValue("@kulupsampiyonluk", kulupsampiyonluktxt.Text);
            komut.Parameters.AddWithValue("@kulupdeger", kulupdegertxt.Text);
            komut.Parameters.AddWithValue("@kuluplig", kulupligtxt.Text);
            komut.Parameters.AddWithValue("@Stadyum", stadyumtxt.Text);
            komut.ExecuteNonQuery();
            verilerigöster("select * from kulupler");
            baglanti.Close();

            
            kulupaditxt.Clear();
            kuluptarihtxt.Clear();
            resimekletxt.Clear();
            kulupsampiyonluktxt.Clear();
            kulupdegertxt.Clear();
            kulupligtxt.Clear();
            stadyumtxt.Clear();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from kulupler where kulup_adi=@kulupadı", baglanti);
            komut.Parameters.AddWithValue("@kulupadı", kulupaditxt.Text);
            komut.ExecuteNonQuery();
            verilerigöster("select*from kulupler");
            baglanti.Close();
        }
       
        private void Button2_Click(object sender, EventArgs e)
        {

            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            resimekletxt.Text = openFileDialog1.FileName;

        }

      private void Takımlardatagrid_CellClick(object sender,DataGridViewCellEventArgs e)
        {
            
            
        }

        private void AdminTakımlar_Load(object sender, EventArgs e)
        {

        }

        private void Takımlardatagrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Takımlardatagrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                Takımlardatagrid.CurrentRow.Selected = true;

                kulupaditxt.Text = Takımlardatagrid.CurrentRow.Cells[1].FormattedValue.ToString();
                kuluptarihtxt.Text = Takımlardatagrid.CurrentRow.Cells[2].FormattedValue.ToString();
                resimekletxt.Text = Takımlardatagrid.CurrentRow.Cells[3].FormattedValue.ToString();
                kulupsampiyonluktxt.Text = Takımlardatagrid.CurrentRow.Cells[4].FormattedValue.ToString();
                kulupdegertxt.Text = Takımlardatagrid.CurrentRow.Cells[5].FormattedValue.ToString();
                kulupligtxt.Text = Takımlardatagrid.CurrentRow.Cells[6].FormattedValue.ToString();
                stadyumtxt.Text= Takımlardatagrid.CurrentRow.Cells[7].FormattedValue.ToString();


            }

        }

      
       
        
        private void Aramatxt_TextChanged(object sender, EventArgs e)
        {

            SqlConnection baglanti = new SqlConnection("Data Source=TARIK\\SQLEXPRESS;Initial Catalog=Transfer;Integrated Security=True");
            baglanti.Open();




            if (comboBox1.Text == "ADİ")
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select kulup_ID, kulup_adi, kulup_acilis_tarihi, kulup_foto, kulup_sampiyonluk, kulup_toplamDeger, kulup_lig, stadyum from kulupler where kulup_adi like '" + aramatxt.Text + "%'", baglanti);
                DataTable data = new DataTable();
                sda.Fill(data);
                Takımlardatagrid.DataSource = data;
            }
            else if (comboBox1.Text=="SAMPİYON")
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select kulup_ID, kulup_adi, kulup_acilis_tarihi, kulup_foto, kulup_sampiyonluk, kulup_toplamDeger, kulup_lig, stadyum from kulupler where kulup_sampiyonluk like '" + aramatxt.Text + "%'", baglanti);
                DataTable data = new DataTable();
                sda.Fill(data);
                Takımlardatagrid.DataSource = data;
            }

            else if (comboBox1.Text == "LİG")
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select kulup_ID, kulup_adi, kulup_acilis_tarihi, kulup_foto, kulup_sampiyonluk, kulup_toplamDeger, kulup_lig, stadyum from kulupler where kulup_lig like '" + aramatxt.Text + "%'", baglanti);
                DataTable data = new DataTable();
                sda.Fill(data);
                Takımlardatagrid.DataSource = data;
            }

            else if (comboBox1.Text == "STADYUM")
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select kulup_ID, kulup_adi, kulup_acilis_tarihi, kulup_foto, kulup_sampiyonluk, kulup_toplamDeger, kulup_lig, stadyum from kulupler where stadyum like '" + aramatxt.Text + "%'", baglanti);
                DataTable data = new DataTable();
                sda.Fill(data);
                Takımlardatagrid.DataSource = data;
            }


        }

        private void güncelbtn_Click(object sender, EventArgs e)
        {
          
        }
    }
}
