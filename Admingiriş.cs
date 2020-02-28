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
    public partial class Admingiriş : Form
    {
        public Admingiriş()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)


        {



           
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
          


            if (textbox1.Text == "" || textbox2.Text == "")

            {
                MessageBox.Show("boş alan bırakmayınız!");

            }
            else
            {
                MessageBox.Show("Girişiniz Başarıyla Gerçekleşti");
            }
         
        }

        private void Button1_Click_2(object sender, EventArgs e)
        {
           
        }
    }
}
