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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        //Veritabanı bağlantısını oluşturuyoruz
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-PBAPHP1;Initial Catalog=scrum;Integrated Security=True");

        private void Admin_Load(object sender, EventArgs e)
        {
            //Verilerin otomatik doldurulması
            cbxUrun.Text = Satici.gidenBilgi1.ToString();
            txtMiktar.Text = Satici.gidenBilgi2.ToString();
            txtFiyat.Text = Satici.gidenBilgi3.ToString();
            txtUserId.Text = Satici.gidenBilgi4.ToString();
            txtItemId.Text = Satici.gidenBilgi5.ToString();
        }

        private void btnTamamla_Click(object sender, EventArgs e)
        {
            //Admin onayının kontrolü
            if(cbxOnay.Text == "Evet")
            {
                //Satıcı verilerinin veritabanına kaydedilmesi
                string sorgu1 = "INSERT INTO items(item_name) VALUES(@item_name)";
                SqlCommand command1 = new SqlCommand(sorgu1, connection);
                string sorgu2 = "INSERT INTO user_items(user_id,item_amount,item_id) VALUES(@user_id,@item_amount,@item_id)";
                SqlCommand command2 = new SqlCommand(sorgu2, connection);
                string sorgu3 = "INSERT INTO moneys(money_amount,user_id) VALUES(@money_amount,@user_id)";
                SqlCommand command3 = new SqlCommand(sorgu3, connection);
                
             

                command1.Parameters.AddWithValue("@item_name", cbxUrun.Text);
                command2.Parameters.AddWithValue("@item_amount", txtMiktar.Text);
                command2.Parameters.AddWithValue("@user_id", txtUserId.Text);
                command2.Parameters.AddWithValue("@item_id",txtItemId.Text);
     
                //Toplam bakiyenin hesaplanması
                int toplamBakiye = Convert.ToInt32(txtMiktar.Text) * Convert.ToInt32(txtFiyat.Text);

                command3.Parameters.AddWithValue("@money_amount", toplamBakiye);
                command3.Parameters.AddWithValue("@user_id", txtUserId.Text);

                connection.Open();

                command1.ExecuteNonQuery();
                command2.ExecuteNonQuery();
                command3.ExecuteNonQuery();

               


                connection.Close();

                MessageBox.Show("Ürün başarıyla eklendi.");

            }

            else
            {
                MessageBox.Show("Ürün eklenemedi.");
            }




        }


    }
}
