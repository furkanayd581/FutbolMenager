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
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-1ONI7GL\\SQLEXPRESS;Initial Catalog=Transfer;Integrated Security=True");
        
      
        public void verilerigöster(string veriler)
           
        {

            
            SqlDataAdapter da = new SqlDataAdapter(veriler, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            Takımlardatagrid.DataSource = ds.Tables[0];

        }
        private void Takımlardatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AdminTakımlar_Load(object sender, EventArgs e)
        {
            
        }

        private void Takımbtn_Click(object sender, EventArgs e)
        {
            verilerigöster("Select*from kulupler");  
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into kulupler(kulup_adi,kulup_acilis_tarihi,kulup_foto,kulup_sampiyonluk,kulup_toplamDeger,kulup_lig)values(@kulupadı,@kulupacilis,@kulupfoto,@kulupsampiyonluk,@kulupdeger,@kuluplig)", baglanti);
            
            komut.Parameters.AddWithValue("@kulupadı", kulupaditxt.Text);
            komut.Parameters.AddWithValue("@kulupacilis", kuluptarihtxt.Text);
            komut.Parameters.AddWithValue("@kulupfoto", textBox4.Text);
            komut.Parameters.AddWithValue("@kulupsampiyonluk", kulupsampiyonluktxt.Text);
            komut.Parameters.AddWithValue("@kulupdeger", kulupdegertxt.Text);
            komut.Parameters.AddWithValue("@kuluplig", kulupligtxt.Text);
            komut.ExecuteNonQuery();
            verilerigöster("select * from kulupler");
            baglanti.Close();

            kulupıdtxt.Clear();
            kulupaditxt.Clear();
            kuluptarihtxt.Clear();
            textBox4.Clear();
            kulupsampiyonluktxt.Clear();
            kulupdegertxt.Clear();
            kulupligtxt.Clear();
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
    }
}
