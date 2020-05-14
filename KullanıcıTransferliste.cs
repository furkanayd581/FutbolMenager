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
    public partial class KullanıcıTransferliste : Form
    {



        //public KullanıcıTransferlistesi(string ID, string sporcu_no,string sporcu_adi, string sporcu_soyadi, string sporcu_yas, string sporcu_mevki, string sporcu_ayak, string sporcu_kulup, string sporcu_satis_fiyati, string sporcu_satis_durumu, string sporcu_boy, string sporcu_uyruk)
        //{
        //    InitializeComponent();

        //    transferlistedatagrid.Rows.Add();
        //    transferlistedatagrid.Rows[0].Cells[0].Value = ID;
        //    transferlistedatagrid.Rows[0].Cells[0].Value = sporcu_no;
        //    transferlistedatagrid.Rows[0].Cells[1].Value = sporcu_adi;
        //    transferlistedatagrid.Rows[0].Cells[2].Value = sporcu_soyadi;
        //    transferlistedatagrid.Rows[0].Cells[3].Value = sporcu_yas;
        //    transferlistedatagrid.Rows[0].Cells[4].Value = sporcu_mevki;
        //    transferlistedatagrid.Rows[0].Cells[5].Value = sporcu_ayak;
        //    transferlistedatagrid.Rows[0].Cells[6].Value = sporcu_kulup;
        //    transferlistedatagrid.Rows[0].Cells[7].Value = sporcu_satis_fiyati;
        //    transferlistedatagrid.Rows[0].Cells[8].Value = sporcu_satis_durumu;
        //    transferlistedatagrid.Rows[0].Cells[9].Value = sporcu_boy;
        //    transferlistedatagrid.Rows[0].Cells[10].Value = sporcu_uyruk;


        //}

        public KullanıcıTransferliste()
        {
            InitializeComponent();
        }

        private void KullanıcıTransferliste_Load(object sender, EventArgs e)
        {
            transferlistecekme();
           
        }


        public void  transferlistecekme()
        {
            KullaniciAnasayfa ka = new KullaniciAnasayfa();
            String oyuncular = ka.kullanıcı.ToString();
            SqlConnection baglanti = new SqlConnection("Data Source=TARIK\\SQLEXPRESS;Initial Catalog=Transfer;Integrated Security=True");
            baglanti.Open();
            SqlDataAdapter sqlvericekme = new SqlDataAdapter("Select*from Transferliste", baglanti);
            DataTable sqlVerialma = new DataTable();

            sqlvericekme.Fill(sqlVerialma);
          transferlistedatagrid.DataSource = sqlVerialma;
            baglanti.Close();

        }




        private void Button1_Click(object sender, EventArgs e)
        {
            string giden_id = transferlistedatagrid.Rows[0].Cells[0].Value.ToString();
            string giden_sporcu_no = transferlistedatagrid.Rows[0].Cells[1].Value.ToString();
            string giden_sporcu_adi = transferlistedatagrid.Rows[0].Cells[2].Value.ToString();
            string giden_sporcu_soyadi = transferlistedatagrid.Rows[0].Cells[3].Value.ToString();
            string giden_sporcu_yas = transferlistedatagrid.Rows[0].Cells[4].Value.ToString();
            string giden_sporcu_mevki = transferlistedatagrid.Rows[0].Cells[5].Value.ToString();
            string giden_sporcu_ayak = transferlistedatagrid.Rows[0].Cells[6].Value.ToString();
            string giden_sporcu_kulup = transferlistedatagrid.Rows[0].Cells[7].Value.ToString();
            string giden_sporcu_satis_fiyati = transferlistedatagrid.Rows[0].Cells[8].Value.ToString();
            string giden_sporcu_satis_durumu = transferlistedatagrid.Rows[0].Cells[9].Value.ToString();
            string giden_sporcu_boy= transferlistedatagrid.Rows[0].Cells[10].Value.ToString();
            string giden_sporcu_uyruk = transferlistedatagrid.Rows[0].Cells[11].Value.ToString();


            SqlConnection baglanti = new SqlConnection("Data Source=TARIK\\SQLEXPRESS;Initial Catalog=Transfer;Integrated Security=True");
            baglanti.Open();
            string sorgu = "update Transferliste set ID=@giden_id, sporcu_no= @giden_sporcu_no , sporcu_adi=@giden_sporcu_adi, sporcu_soyadi=@giden_sporcu_soyadi," +
                "  sporcu_yas=@giden_sporcu_yas, sporcu_mevki=@giden_sporcu_mevki, sporcu_ayak=@giden_sporcu_ayak, sporcu_kulup=@giden_sporcu_kulup," +
                "   sporcu_satis_fiyati=@giden_sporcu_satis_fiyati ,sporcu_satis_durumu=@giden_sporcu_satis_durumu," +
                "  sporcu_boy=@giden_sporcu_boy, sporcu_uyruk=@giden_sporcu_uyruk  where ID=@giden_id";


            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@giden_id", giden_id);
            komut.Parameters.AddWithValue("@giden_sporcu_no", giden_sporcu_no);
            komut.Parameters.AddWithValue("@giden_sporcu_adi", giden_sporcu_adi);
            komut.Parameters.AddWithValue("@giden_sporcu_soyadi", giden_sporcu_soyadi);
            komut.Parameters.AddWithValue("@giden_sporcu_yas", giden_sporcu_yas);
            komut.Parameters.AddWithValue("@giden_sporcu_mevki", giden_sporcu_mevki);
            komut.Parameters.AddWithValue("@giden_sporcu_ayak ", giden_sporcu_ayak);
            komut.Parameters.AddWithValue("@giden_sporcu_kulup ", giden_sporcu_kulup);
            komut.Parameters.AddWithValue("@giden_sporcu_satis_fiyati", giden_sporcu_satis_fiyati);
            komut.Parameters.AddWithValue("@giden_sporcu_satis_durumu ", giden_sporcu_satis_durumu); 
            komut.Parameters.AddWithValue("@ giden_sporcu_boy ", giden_sporcu_boy);
            komut.Parameters.AddWithValue("@giden_sporcu_uyruk", giden_sporcu_uyruk);

            komut.ExecuteNonQuery();
            baglanti.Close();

        }
    }
}
