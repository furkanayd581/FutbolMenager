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
    public partial class KullaniciAnasayfa : Form
    {
        public KullaniciAnasayfa()
        {
            InitializeComponent();
        }
        public string kullanıcı = Giriş.gidenbilgi.ToString();
        private void KullaniciAnasayfa_Load(object sender, EventArgs e)
        {
            lbltakımadı.Text = Giriş.gidenbilgi.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            KullanıcıOyuncular oyuncular = new KullanıcıOyuncular();
                oyuncular.Show();
                KullaniciAnasayfa k1 = new KullaniciAnasayfa();
                k1.Close();

                this.Hide();
        }
    }
}
