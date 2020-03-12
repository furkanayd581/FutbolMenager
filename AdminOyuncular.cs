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
    public partial class AdminOyuncular : Form
    {
        public AdminOyuncular()
        {
            InitializeComponent();
        }





        
        private void AdminOyuncular_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-1ONI7GL\\SQLEXPRESS;Initial Catalog=Transfer;Integrated Security=True");
            baglanti.Open();
            SqlDataAdapter sqlvericekme = new SqlDataAdapter("Select*from sporcular", baglanti);
            DataTable sqlVerialma = new DataTable();
            sqlvericekme.Fill(sqlVerialma);
            OyuncularDataGrid.DataSource = sqlVerialma;
            baglanti.Close();


        }
    }
}
