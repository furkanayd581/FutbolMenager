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

        private void KullaniciAnasayfa_Load(object sender, EventArgs e)
        {
            lbltakımadı.Text = Giriş.gidenbilgi.ToString();
        }
    }
}
