using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Odev
{
    public partial class SubForm : Form
    {
        public SubForm()
        {
            InitializeComponent();
        }
        //Veritabanı bağlantısını oluşturuyoruz
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-PBAPHP1;Initial Catalog=scrum;Integrated Security=True");


        private void btnSatim_Click(object sender, EventArgs e)
        {
            //Satıcı ekranına yönlendirme
            Satici satici = new Satici();
            satici.ShowDialog();

        }

        private void btnAlimSatim_Click(object sender, EventArgs e)
        {
            //Alıcı ekranına yönlendirme
            connection.Open();

            string sorgu2 = "Select * from user_types where user_type_name = alıcı";

            if (sorgu2 == "Select * from user_types where user_type_name = alıcı")
            {
                Alici alici = new Alici();
                alici.ShowDialog();
            }
            else
            {
                MessageBox.Show("Siz bir alıcı değilsiniz!");
            }
            connection.Close();

        }

        private void btnAlim_Click(object sender, EventArgs e)
        {
            Borsa borsa = new Borsa();
            borsa.ShowDialog();
        }
    }
}
