﻿using System;
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



        

        public KullanıcıTransferliste()
        {
            InitializeComponent();
        }



        private void KullanıcıTransferliste_Load(object sender, EventArgs e)
        {
            transferlistecekme();

            kullanicitakimgetir();
        }
        public string kultakget;
        public void kullanicitakimgetir ()
        {
            KullaniciAnasayfa ka = new KullaniciAnasayfa();
            string ktg = ka.kullanıcı;
            SqlConnection baglanti = new SqlConnection("Data Source=TARIK\\SQLEXPRESS;Initial Catalog=Transfer;Integrated Security=True");
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand();
            komut2.Connection = baglanti;

            komut2.CommandText = "select kullanici_kulup from kullanicilar where kullanici_adi = @kadi ";
            komut2.Parameters.AddWithValue("@kadi", ktg );
           object Kontrol = komut2.ExecuteScalar();
            komut2.Parameters.Clear();
            baglanti.Close();

            kultakget = Kontrol.ToString();



        }


        public void transferlistecekme()
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





        }

        private void Transferarama_TextChanged(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=TARIK\\SQLEXPRESS;Initial Catalog=Transfer;Integrated Security=True");
            baglanti.Open();




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
        private void button1_Click_1(object sender, EventArgs e)
        {

           

                try
            {
                SqlConnection baglanti = new SqlConnection("Data Source=TARIK\\SQLEXPRESS;Initial Catalog=Transfer;Integrated Security=True");
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand();
                komut2.Connection = baglanti;

                komut2.CommandText = "update sporcular set sporcu_kulup=@sporcu where sporcu_ID=@sporcuID";
                komut2.Parameters.AddWithValue("@sporcuID", trnsfr );
                komut2.Parameters.AddWithValue("@sporcu", kultakget );
                object Kontrol = komut2.ExecuteScalar();
                komut2.Parameters.Clear();
                baglanti.Close();


                
                
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Transferliste where sporcu_ID=@sporcu_id", baglanti);
                komut.Parameters.AddWithValue("@sporcu_id",trnsfr);
                komut.ExecuteNonQuery();
                baglanti.Close();

                transferlistecekme();





            }

            catch (Exception)
            {
                MessageBox.Show("buton 1 clik hatası");
                throw;
            }

        }
       

        public void transferlistedatagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 

             trnsfr = transferlistedatagrid.CurrentRow.Cells[12].FormattedValue.ToString();
               
     

            
        }
    }
}

