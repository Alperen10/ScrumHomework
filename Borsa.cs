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
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using Microsoft.Office.Interop.Excel;
using excel = Microsoft.Office.Interop.Excel;

namespace Odev
{
    public partial class Borsa : Form
    {
        public static string goData = "";
        public static string goData2 = "";
        public Borsa()
        {
            InitializeComponent();
        }
        //Veritabanı bağlantısını oluşturuyoruz.
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-PBAPHP1;Initial Catalog=scrum;Integrated Security=True");

        private void txtBakiye_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void Borsa_Load(object sender, EventArgs e)
        {
            //Ürünlerin combobox a getirilmesi
            connection.Open();
            SqlCommand command2 = new SqlCommand("select DISTINCT item_name from items",connection);
            SqlDataReader reader2 = command2.ExecuteReader();
            while (reader2.Read())
            {
                cbxUrun.Items.Add(reader2["item_name"]);

            }
            connection.Close();

          
            
            connection.Open();

            //Satıcıların combobox a getirilmesi
            SqlCommand command = new SqlCommand("select DISTINCT U.user_id from user_items U,moneys M where U.user_id = M.user_id", connection);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                cbxSaticiId.Items.Add(reader["user_id"]);

            }
            connection.Close();

            textBox1.Text = Admin2.goingData8.ToString();


        }
        private void btnTamamla_Click(object sender, EventArgs e)
        {
            //Alıcının almak istediği tutarda ürünün olup olmadığının kontrolü
            if (textBox3.Text == textBox4.Text)
            {
                connection.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from user_items where user_id like '" + cbxSaticiId.Text + "'", connection);
                if (cbxSaticiId.Text == "")
                {
                    MessageBox.Show("Hata");
                }

          



                double a = Convert.ToDouble(textBox3.Text);
                double b = Convert.ToDouble(textBox1.Text);
                double c;


                c = b - a;

                //%1 olan aracılık ücretinin alıcıdan kesilmesi
                c = c - c/100;
                textBox2.Text = c.ToString();
                goData = textBox2.Text;

                goData2 = a.ToString();

                
                //Alıcının kalan para miktarını güncelleme
                string sorgu5 = "UPDATE moneys SET user_id=@user_id,money_amount=@money_amount where user_id=@user_id";
                SqlCommand cmd5 = new SqlCommand(sorgu5, connection);
                cmd5.Parameters.AddWithValue("@money_amount", textBox2.Text);
                cmd5.Parameters.AddWithValue("@user_id", txtUserId.Text);
                cmd5.ExecuteNonQuery();


                
               

                Sonuc sonuc = new Sonuc();
                sonuc.ShowDialog();

                connection.Close();


            }
            else if(textBox3.Text != textBox4.Text)
            {
                MessageBox.Show("Almak istediğiniz fiyatta ürün satan satıcı bulunamadı!");

            }


            

        }


        private void cbxUrun_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand cmd2 = new SqlCommand("Select * from moneys where user_id='" + cbxSaticiId.Text + "'", connection);
            connection.Open();
            cmd2.ExecuteNonQuery();
            SqlDataReader dr2;
            dr2 = cmd2.ExecuteReader();
            while (dr2.Read())
            {
                string price = (string)dr2["money_amount"].ToString();
                textBox3.Text = price;

            }
            connection.Close();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            

        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

          
        }

        private void cbxSaticiId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            //Datagridview da gösterme

            System.Data.DataTable dt = new System.Data.DataTable();
            string sql = "Select user_id,money_amount,date from moneys where date Between @date1 and @date2";
            SqlDataAdapter da = new SqlDataAdapter(sql, connection);
            da.SelectCommand.Parameters.AddWithValue("@user_id", txtUserId.Text);
            da.SelectCommand.Parameters.AddWithValue("@money_amount", textBox3.Text);
            da.SelectCommand.Parameters.AddWithValue("@date1", dateTimePicker1.Value);
            da.SelectCommand.Parameters.AddWithValue("@date2", dateTimePicker2.Value);
            da.Fill(dt);
            dataGridView1.DataSource = dt;


            //Excelde rapor oluşturma ve gösterme

            excel.Application app = new excel.Application();
            app.Visible = true;
            Workbook kitap = app.Workbooks.Add(System.Reflection.Missing.Value);
            Worksheet sayfa = (Worksheet)kitap.Sheets[1];
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                Range alan = (Range)sayfa.Cells[1, 1];
                alan.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
            }
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Rows.Count; j++)
                {
                    Range alan2 = (Range)sayfa.Cells[j+1,i+1];
                    alan2.Cells[2, 1] = dataGridView1[i,j].Value;

                }

            }



        }
    }
}
