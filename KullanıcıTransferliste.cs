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


        public string kullanici_adi;

        public KullanıcıTransferliste()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=Furkan\\SQLEXPRESS;Initial Catalog=Transfer;Integrated Security=True");




        public void kullanici_eskikulup_adi()
        {
            string transfer_oyuncu_kulup;
            transfer_oyuncu_kulup = transferlistedatagrid.CurrentRow.Cells[7].Value.ToString();
            transferoyuncukulup.Text = transfer_oyuncu_kulup.ToString();


            string transfer_satis_fiyati;
            transfer_satis_fiyati = transferlistedatagrid.CurrentRow.Cells[8].Value.ToString();
            transfersatis.Text = transfer_satis_fiyati.ToString();



        }
  
        public void kullanici_kulup_bilgi_cek()
        {
            baglanti.Open();
            SqlCommand listele = new SqlCommand();
            listele.Connection = baglanti;
            listele.CommandText = "Select * from kulupler where kulup_adi = (select kullanici_kulup from kullanicilar where kullanici_adi = '" + kullaniciadi.Text + "')";

            SqlDataReader dr = listele.ExecuteReader();
            if (dr.HasRows)
            {
                if (dr.Read())
                {
                    eski_kulup_bütce.Text = dr["kulup_toplamBütce"].ToString();
                    yenikulupid.Text = dr["kulup_ID"].ToString();
                   

                }
            }
            baglanti.Close();
        }

        public int kulubun_toplam_degeri;
        public void satilan_oyuncunun_eskikulup_id()
        {
            baglanti.Open();
            SqlCommand eski_kulup_id = new SqlCommand();
            eski_kulup_id.Connection = baglanti;
            transfer_oyuncu_kulup = transfer_oyuncu_kulup.Trim();
            eski_kulup_id.CommandText = "select * from kulupler where kulup_adi = (select top(1) Transfer_kulup from Transferliste where Transfer_kulup= '" + transfer_oyuncu_kulup + "')";
           SqlDataReader dr = eski_kulup_id.ExecuteReader();
            if (dr.HasRows)
            {
                if (dr.Read())
                {
                    transfer_oyuncu_kulupdeger.Text = dr["kulup_toplamBütce"].ToString();
                    eskikulupid.Text = dr["kulup_ID"].ToString();
                    kulubun_toplam_degeri = int.Parse(transfer_oyuncu_kulupdeger.Text);

                }
            }

            baglanti.Close();

        }

        public void bütceazalt()
        {
            int klupdeger, oyuncudeger, kalandeger;
            klupdeger = int.Parse(eski_kulup_bütce.Text);
            oyuncudeger = int.Parse(transferlistedatagrid.CurrentRow.Cells[8].Value.ToString());
            kalandeger = klupdeger - oyuncudeger;
            yenikulupdeger.Text = kalandeger.ToString();
        }
        public void bütcearttır()
        {

            int kulup_deger, sporcu_deger, bütce_artan_deger;
            kulup_deger = kulubun_toplam_degeri;
            sporcu_deger = int.Parse(transferlistedatagrid.CurrentRow.Cells[8].Value.ToString());
            bütce_artan_deger = kulubun_toplam_degeri + sporcu_deger;
            bütcearttırlbl.Text = bütce_artan_deger.ToString();

        }

       

       
        public void bütce_bul()
        {
            baglanti.Open();
            SqlCommand satilan_oyuncu_kulup = new SqlCommand();
            satilan_oyuncu_kulup.Connection = baglanti;
            satilan_oyuncu_kulup.CommandText = " select kulup_toplamBütce from kulupler where kulup_adi = (select Transfer_kulup from Transferliste where sporcu_ID = '" + trnsfr + "')";

            baglanti.Close();
        }

        public void takimcek()
        {
            SqlCommand kullanici_takim_bilgisi = new SqlCommand();
            kullanici_takim_bilgisi.Connection = baglanti;

            kullanici_takim_bilgisi.CommandText = "Select * from kulupler where kulup_adi= (select kullanici_kulup from kullanicilar where kullanici_adi='" + kullaniciadi.Text + "')";
        }
        private void KullanıcıTransferliste_Load(object sender, EventArgs e)
        {

       

            transfer_satis_fiyati = transfersatis.Text;
            kullaniciadi.Hide();
            yenikulupid.Hide();
            yenikulupdeger.Hide();
            eski_kulup_bütce.Hide();
            eskikulupid.Hide();
            bütcearttırlbl.Hide();
            transferoyuncukulup.Hide();
            transfer_oyuncu_kulupdeger.Hide();
            transfersatis.Hide();

            kullaniciadi.Text = kullanici_adi;

            kullanicitakimgetir();
            transferlistecekme();

            
            kullanici_kulup_bilgi_cek();
            bütce_bul();
            

        }

        public string kultakget;
        public void kullanicitakimgetir()
        {
            KullaniciAnasayfa ka = new KullaniciAnasayfa();
            string ktg = ka.kullanıcı;
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand();
            komut2.Connection = baglanti;
            komut2.CommandText = "select kullanici_kulup from kullanicilar where kullanici_adi = @kadi ";
            komut2.Parameters.AddWithValue("@kadi", ktg);
            object Kontrol = komut2.ExecuteScalar();
            komut2.Parameters.Clear();
            baglanti.Close();

            kultakget = Kontrol.ToString();

        }


        public void transferlistecekme()
        {
            KullaniciAnasayfa ka = new KullaniciAnasayfa();
            String oyuncular = ka.kullanıcı.ToString();
            baglanti.Open();

            SqlDataAdapter sqlvericekme = new SqlDataAdapter("Select * from Transferliste", baglanti);
            DataTable sqlVerialma = new DataTable();

            sqlvericekme.Fill(sqlVerialma);
            transferlistedatagrid.DataSource = sqlVerialma;
            baglanti.Close();

        }

        private void Transferarama_TextChanged(object sender, EventArgs e)
        {


            if (comboBox1.Text == "ADİ")
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select Transfer_ID, Transfer_no, Transfer_adi, Transfer_soyadi, Transfer_yas, Transfer_mevki, Transfer_ayak, Transfer_kulup, Transfer_satis_fiyati, Transfer_satis_durumu, Transfer_boy, Transfer_uyruk,sporcu_ID from Transferliste where Transfer_adi like '" + aramatxt.Text + "%'", baglanti);
                DataTable data = new DataTable();
                sda.Fill(data);
                transferlistedatagrid.DataSource = data;
            }

            else if (comboBox1.Text == "SOYADİ")
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select Transfer_ID, Transfer_no, Transfer_adi, Transfer_soyadi, Transfer_yas, Transfer_mevki, Transfer_ayak, Transfer_kulup, Transfer_satis_fiyati, Transfer_satis_durumu, Transfer_boy, Transfer_uyruk,sporcu_ID from Transferliste where Transfer_soyadi like '" + aramatxt.Text + "%'", baglanti);
                DataTable data = new DataTable();
                sda.Fill(data);
                transferlistedatagrid.DataSource = data;
            }

            else if (comboBox1.Text == "YAS")
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select Transfer_ID, Transfer_no, Transfer_adi, Transfer_soyadi, Transfer_yas, Transfer_mevki, Transfer_ayak, Transfer_kulup, Transfer_satis_fiyati, Transfer_satis_durumu, Transfer_boy, Transfer_uyruk,sporcu_ID from Transferliste where Transfer_yas like '" + aramatxt.Text + "%'", baglanti);
                DataTable data = new DataTable();
                sda.Fill(data);
                transferlistedatagrid.DataSource = data;
            }

            else if (comboBox1.Text == "MEVKİ")
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select Transfer_ID, Transfer_no, Transfer_adi, Transfer_soyadi, Transfer_yas, Transfer_mevki, Transfer_ayak, Transfer_kulup, Transfer_satis_fiyati, Transfer_satis_durumu, Transfer_boy, Transfer_uyruk,sporcu_ID from Transferliste where Transfer_mevki like '" + aramatxt.Text + "%'", baglanti);
                DataTable data = new DataTable();
                sda.Fill(data);
                transferlistedatagrid.DataSource = data;
            }

            else if (comboBox1.Text == "AYAK")
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select Transfer_ID, Transfer_no, Transfer_adi, Transfer_soyadi, Transfer_yas, Transfer_mevki, Transfer_ayak, Transfer_kulup, Transfer_satis_fiyati, Transfer_satis_durumu, Transfer_boy, Transfer_uyruk,sporcu_ID from Transferliste where Transfer_ayak like '" + aramatxt.Text + "%'", baglanti);
                DataTable data = new DataTable();
                sda.Fill(data);
                transferlistedatagrid.DataSource = data;
            }


            else if (comboBox1.Text == "KULUP")
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select Transfer_ID, Transfer_no, Transfer_adi, Transfer_soyadi, Transfer_yas, Transfer_mevki, Transfer_ayak, Transfer_kulup, Transfer_satis_fiyati, Transfer_satis_durumu, Transfer_boy, Transfer_uyruk,sporcu_ID from Transferliste where Transfer_kulup like '" + aramatxt.Text + "%'", baglanti);
                DataTable data = new DataTable();
                sda.Fill(data);
                transferlistedatagrid.DataSource = data;
            }
            else if (comboBox1.Text == "SATİSFİYAT")
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select Transfer_ID, Transfer_no, Transfer_adi, Transfer_soyadi, Transfer_yas, Transfer_mevki, Transfer_ayak, Transfer_kulup, Transfer_satis_fiyati, Transfer_satis_durumu, Transfer_boy, Transfer_uyruk,sporcu_ID from Transferliste where Transfer_satis_fiyat like '" + aramatxt.Text + "%'", baglanti);
                DataTable data = new DataTable();
                sda.Fill(data);
                transferlistedatagrid.DataSource = data;
            }

            else if (comboBox1.Text == "BOY")
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select Transfer_ID, Transfer_no, Transfer_adi, Transfer_soyadi, Transfer_yas, Transfer_mevki, Transfer_ayak, Transfer_kulup, Transfer_satis_fiyati, Transfer_satis_durumu, Transfer_boy, Transfer_uyruk,sporcu_ID from Transferliste where Transfer_boy like '" + aramatxt.Text + "%'", baglanti);
                DataTable data = new DataTable();
                sda.Fill(data);
                transferlistedatagrid.DataSource = data;
            }

            else if (comboBox1.Text == "UYRUK")
            {
                SqlDataAdapter sda = new SqlDataAdapter("Select Transfer_ID, Transfer_no, Transfer_adi, Transfer_soyadi, Transfer_yas, Transfer_mevki, Transfer_ayak, Transfer_kulup, Transfer_satis_fiyati, Transfer_satis_durumu, Transfer_boy, Transfer_uyruk,sporcu_ID from Transferliste where Transfer_uyruk like '" + aramatxt.Text + "%'", baglanti);
                DataTable data = new DataTable();
                sda.Fill(data);
                transferlistedatagrid.DataSource = data;


            }
        }


        public string trnsfr;
        public string transfer_oyuncu_kulup;
        public string transfer_satis_fiyati;
        private void button1_Click_1(object sender, EventArgs e)
        {

            if (trnsfr == null)
            {
                MessageBox.Show("Transfer edilecek oyuncu seçiniz");

            }


            
            else
            {
                
                bütceazalt();
                satilan_oyuncunun_eskikulup_id();
                kullanici_eskikulup_adi();
                bütcearttır();


               
                try
                {
                
                    baglanti.Open();
                    SqlCommand komut2 = new SqlCommand();
                    komut2.Connection = baglanti;
                    komut2.CommandText = "update sporcular set sporcu_kulup='" + kultakget + "' where sporcu_ID= " + trnsfr;
                    komut2.ExecuteNonQuery();
                    komut2.Parameters.Clear();



                    SqlCommand komut3 = new SqlCommand();
                    komut3.Connection = baglanti;
                    string yenikulup_deger = yenikulupdeger.Text;
                    string yenikulup_id = yenikulupid.Text;
                    komut3.CommandText = "update kulupler set kulup_toplamBütce='" + yenikulup_deger + "' where kulup_ID= " + yenikulup_id;
                    komut3.ExecuteNonQuery();
                    komut3.Parameters.Clear();


                  
                   
                    SqlCommand komut4 = new SqlCommand();
                    komut4.Connection = baglanti;
                    string bütce_arttir = bütcearttırlbl.Text;
                    string eski_kulup_id = eskikulupid.Text;
                    komut4.CommandText = "update kulupler set kulup_toplamBütce ='" + bütce_arttir + "' where kulup_ID = " + eski_kulup_id;
                    komut4.ExecuteNonQuery();
                    komut4.Parameters.Clear();
                  

                    SqlCommand komut = new SqlCommand("delete from Transferliste where sporcu_ID=@sporcu_id", baglanti);
                    komut.Parameters.AddWithValue("@sporcu_id", trnsfr);
                    komut.ExecuteNonQuery();
                    komut.Parameters.Clear();
                    baglanti.Close();
                    transferlistecekme();
                
                }

                catch (Exception hata)
                {
                    MessageBox.Show("Transfer etme işlemi sırasında hata ile karşılaşıldı (button1)" + hata);
                    throw;
                }

            }


        }


        public void transferlistedatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            trnsfr = transferlistedatagrid.CurrentRow.Cells[12].FormattedValue.ToString();
            transfer_oyuncu_kulup = transferlistedatagrid.CurrentRow.Cells[7].FormattedValue.ToString();
         
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            KullaniciAnasayfa anasayfa = new KullaniciAnasayfa();
            anasayfa.Show();
            this.Hide();
        }

        private void transferlistedatagrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (transferlistedatagrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                transferlistedatagrid.CurrentRow.Selected = true;

                transferoyuncukulup.Text = transferlistedatagrid.CurrentRow.Cells[7].FormattedValue.ToString();
                transfersatis.Text = transferlistedatagrid.CurrentRow.Cells[8].FormattedValue.ToString();
            }
        }
    }
}

