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


        private void Transferbtn_Click(object sender, EventArgs e)
        {


          
            
            try
            {
                string giden_sporcu_no= KullanıcıDatagrid.SelectedRows[0].Cells[1].Value.ToString();
                string giden_sporcu_adi = KullanıcıDatagrid.SelectedRows[0].Cells[2].Value.ToString();
                string giden_sporcu_soyadi = KullanıcıDatagrid.SelectedRows[0].Cells[3].Value.ToString();
                string giden_sporcu_yas = KullanıcıDatagrid.SelectedRows[0].Cells[4].Value.ToString();
                string giden_sporcu_mevki = KullanıcıDatagrid.SelectedRows[0].Cells[5].Value.ToString();
                string giden_sporcu_ayak = KullanıcıDatagrid.SelectedRows[0].Cells[6].Value.ToString();
                string giden_sporcu_kulup = KullanıcıDatagrid.SelectedRows[0].Cells[7].Value.ToString();
                string giden_sporcu_satis_fiyati =KullanıcıDatagrid.SelectedRows[0].Cells[8].Value.ToString();
                string giden_sporcu_satis_durumu = KullanıcıDatagrid.SelectedRows[0].Cells[9].Value.ToString();
                string giden_sporcu_boy = KullanıcıDatagrid.SelectedRows[0].Cells[10].Value.ToString();
                string giden_sporcu_uyruk = KullanıcıDatagrid.SelectedRows[0].Cells[11].Value.ToString();
                SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-1ONI7GL\\SQLEXPRESS;Initial Catalog=Transfer;Integrated Security=True");
                baglanti.Open();
                string sorgu = "insert INTO Transferliste (sporcu_no, sporcu_adi, sporcu_soyadi,  sporcu_yas, sporcu_mevki, sporcu_ayak, sporcu_kulup,  sporcu_satis_fiyati,sporcu_satis_durumu, sporcu_boy, sporcu_uyruk) values (@giden_sporcu_no,@giden_sporcu_adi,@giden_sporcu_soyadi,@giden_sporcu_yas,@giden_sporcu_mevki,@giden_sporcu_ayak,@giden_sporcu_kulup,@giden_sporcu_satis_fiyati,@giden_sporcu_satis_durumu,@giden_sporcu_boy, @giden_sporcu_uyruk)";


                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@giden_sporcu_no", giden_sporcu_no);
                komut.Parameters.AddWithValue("@giden_sporcu_adi", giden_sporcu_adi);
                komut.Parameters.AddWithValue("@giden_sporcu_soyadi", giden_sporcu_soyadi);
                komut.Parameters.AddWithValue("@giden_sporcu_yas", giden_sporcu_yas);
                komut.Parameters.AddWithValue("@giden_sporcu_mevki", giden_sporcu_mevki);
                komut.Parameters.AddWithValue("@giden_sporcu_ayak ", giden_sporcu_ayak);
                komut.Parameters.AddWithValue("@giden_sporcu_kulup ", giden_sporcu_kulup);
                komut.Parameters.AddWithValue("@giden_sporcu_satis_fiyati", giden_sporcu_satis_fiyati);
                komut.Parameters.AddWithValue("@giden_sporcu_satis_durumu ", giden_sporcu_satis_durumu);
                komut.Parameters.AddWithValue("@giden_sporcu_boy ", giden_sporcu_boy);
                komut.Parameters.AddWithValue("@giden_sporcu_uyruk", giden_sporcu_uyruk);


                komut.ExecuteNonQuery();
               
                

                baglanti.Close();



                //   KullanıcıDatagrid.SelectedRows[0].Cells[0].Value.ToString(),
              
                   
            }
            catch (Exception)
            {
                MessageBox.Show("buton 1 clik hatası");
                throw;
            }


        }
    }
}
