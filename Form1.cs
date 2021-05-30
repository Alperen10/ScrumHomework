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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Veritabanı bağlantısını oluşturuyoruz.
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-PBAPHP1;Initial Catalog=scrum;Integrated Security=True");
        SqlCommand command;
        private void btnTamamla_Click(object sender, EventArgs e)
        {
            //Kullanıcıları veritabanına kaydediyoruz.
            string sorgu = "INSERT INTO users(user_name,user_surname,user_tc_number,tel_number,address,email) VALUES (@user_name,@user_surname,@user_tc_number,@tel_number,@address,@email)";
            command = new SqlCommand(sorgu, connection);
            command.Parameters.AddWithValue("@user_name",txtUserName.Text);
            command.Parameters.AddWithValue("@user_surname", txtUserSurname.Text);
            command.Parameters.AddWithValue("@user_tc_number", txtUserTcNumber.Text);
            command.Parameters.AddWithValue("@tel_number", txtTelNumber.Text);
            command.Parameters.AddWithValue("@address", txtAddress.Text);
            command.Parameters.AddWithValue("@email", txtEmail.Text);

            connection.Open();
            command.ExecuteNonQuery();
            MessageBox.Show("Kullanıcı başarıyla eklendi.");

            SubForm subForm = new SubForm();
            subForm.ShowDialog();



            connection.Close();

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            //TC kimlik numarasına göre giriş yapmanın kontrolü
            if(txtUserTcNumber.Text == "")
            {
                MessageBox.Show("Giriş başarısız!");
            }
            else
            {
                MessageBox.Show("Giriş başarılı!");
                SubForm subForm = new SubForm();
                subForm.ShowDialog();
            }

        }


        /*
        private void btnGiris_Click(object sender, EventArgs e)
        {

        }

        
        private void btnGiris_Click(object sender, EventArgs e)
        {

        }

        private void btnAlimSatim_Click(object sender, EventArgs e)
        {


        }

        private void btnSatim_Click(object sender, EventArgs e)
        {
           

        }

        private void btnAlim_Click(object sender, EventArgs e)
        {
           
        }
        */
    }
}
