using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Futbolmenager2
{
    public partial class Admin_anasayfa : Form
    {
        public Admin_anasayfa()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            AdminTakımlar takım = new AdminTakımlar();
            takım.Show();
            this.Hide();
        }

        private void Button2_MouseMove(object sender, MouseEventArgs e)
        {
            btntakımlar.BackColor = Color.Red;
        }

        private void Admin_anasayfa_Load(object sender, EventArgs e)
        {
            admintxt.Text = Giriş.gidenbilgi.ToString();
        }

        private void Btnoyuncular_Click(object sender, EventArgs e)
        {
            AdminOyuncular oyuncular = new AdminOyuncular();
            oyuncular.Show();
            this.Hide();
        }

        private void btntransferliste_Click(object sender, EventArgs e)
        {
            AdminTransferListe trnsfr = new AdminTransferListe();
            trnsfr.Show();
            this.Hide();
        }

        private void btnkayitlikullanici_Click(object sender, EventArgs e)
        {
            AdminKayitliKullanici kyt = new AdminKayitliKullanici();
            kyt.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
