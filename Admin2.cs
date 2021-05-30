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
using System.Xml;

namespace Odev
{
    public partial class Admin2 : Form
    {
        
        public static string goingData8 = "";
        public Admin2()
        {
            InitializeComponent();
        }
        //Baglantiyi olusturuyoruz
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-PBAPHP1;Initial Catalog=scrum;Integrated Security=True");
    

        private void Admin2_Load(object sender, EventArgs e)
        {
            //Alici formundan gelen verileri otomatik dolduruyoruz
            txtFiyat.Text = Alici.goingData3.ToString();
            txtUserId.Text = Alici.goingData4.ToString();
            dateTimePicker1.Text = Alici.goingData5.ToString();
            

        }

        private void btnTamamla_Click(object sender, EventArgs e)
        {
            //Admin onayının kontrolü
            if (cbxOnay.Text == "Evet")
            {

                var xmldoc = new XmlDocument();


                //Adminin seçtiği gün bilgisine göre döviz kurunun alınması
                string day = dateTimePicker1.Value.Day.ToString();

                //Adminin seçtiği ay bilgisine göre döviz kurunun alınması
                string month = dateTimePicker1.Value.Month.ToString();

                //Adminin seçtiği yıl bilgisine göre döviz kurunun alınması
                string year = dateTimePicker1.Value.Year.ToString();

                int ay = Convert.ToInt32(month);

                int gun = Convert.ToInt32(day);

                //Seçtiği ay tek rakamla başlıyorsa başına 0 ekliyoruz.
                if (ay <= 9)
                {
                    month = "0" + dateTimePicker1.Value.Month.ToString();
                }
                else
                {
                    month = dateTimePicker1.Value.Month.ToString();

                }
                //Seçtiği gün tek rakamla başlıyorsa başına 0 ekliyoruz.
                if (gun <= 9)
                {
                    day = "0" + dateTimePicker1.Value.Day.ToString();
                }
                else
                {
                    day = dateTimePicker1.Value.Day.ToString();

                }

                //Merkez bankasından verileri seçilen tarihe göre çekiyoruz.
                string url = string.Empty;
                url = string.Format("http://www.tcmb.gov.tr/kurlar/{0}{1}/{2}{1}{0}.xml", year, month, day);

                xmldoc.Load(url);
                DateTime tarih = Convert.ToDateTime(xmldoc.SelectSingleNode("//Tarih_Date").Attributes["Tarih"].Value);
                string sterlin = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='GBP']/BanknoteSelling").InnerXml;
                lblDöviz.Text = string.Format("Tarih:{0}", tarih.ToShortDateString());
                txtDöviz.Text = string.Format("{0}", sterlin);


                //Seçilen tarihe göre toplam bakiyenin hesaplanması
                double fiyat = Convert.ToDouble(txtDöviz.Text) * Convert.ToDouble(txtFiyat.Text);
                txtFiyat.Text = fiyat.ToString();
                goingData8 = txtFiyat.Text;









                //Alıcı bilgilerini veritabanına kaydetme
                string sorgu = "INSERT INTO moneys(money_amount,user_id,date) VALUES(@money_amount,@user_id,@date)";
                SqlCommand command = new SqlCommand(sorgu, connection);

                command.Parameters.AddWithValue("@money_amount", txtFiyat.Text);
                command.Parameters.AddWithValue("@user_id", txtUserId.Text);
                command.Parameters.AddWithValue("@date", dateTimePicker1.Value);
                connection.Open();
                command.ExecuteNonQuery();




                connection.Close();
                MessageBox.Show("Bakiye ekleme işleminiz tamamlanmıştır.");
                Borsa borsa = new Borsa();
                borsa.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bakiye ekleme işlemi tamamlanamadı.");
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Admin onayının kontrolü
            if (cbxOnay.Text == "Evet")
            {

                var xmldoc = new XmlDocument();


                //Adminin seçtiği gün bilgisine göre döviz kurunun alınması
                string day = dateTimePicker1.Value.Day.ToString();

                //Adminin seçtiği ay bilgisine göre döviz kurunun alınması
                string month = dateTimePicker1.Value.Month.ToString();

                //Adminin seçtiği yıl bilgisine göre döviz kurunun alınması
                string year = dateTimePicker1.Value.Year.ToString();

                int ay = Convert.ToInt32(month);

                int gun = Convert.ToInt32(day);

                //Seçtiği ay tek rakamla başlıyorsa başına 0 ekliyoruz.
                if (ay <= 9)
                {
                    month = "0" + dateTimePicker1.Value.Month.ToString();
                }
                else
                {
                    month = dateTimePicker1.Value.Month.ToString();

                }
                //Seçtiği gün tek rakamla başlıyorsa başına 0 ekliyoruz.
                if (gun <= 9)
                {
                    day = "0" + dateTimePicker1.Value.Day.ToString();
                }
                else
                {
                    day = dateTimePicker1.Value.Day.ToString();

                }

                //Merkez bankasından verileri seçilen tarihe göre çekiyoruz.
                string url = string.Empty;
                url = string.Format("http://www.tcmb.gov.tr/kurlar/{0}{1}/{2}{1}{0}.xml", year, month, day);

                xmldoc.Load(url);
                DateTime tarih = Convert.ToDateTime(xmldoc.SelectSingleNode("//Tarih_Date").Attributes["Tarih"].Value);
                string sterlin = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='GBP']/BanknoteSelling").InnerXml;
                lblDöviz.Text = string.Format("Tarih:{0}", tarih.ToShortDateString());
                txtDöviz.Text = string.Format("{0}", sterlin);


                //Seçilen tarihe göre toplam bakiyenin hesaplanması
                double fiyat = Convert.ToDouble(txtDöviz.Text) * Convert.ToDouble(txtFiyat.Text);
                txtFiyat.Text = fiyat.ToString();
                goingData8 = txtFiyat.Text;









                //Alıcı bilgilerini veritabanına kaydetme
                string sorgu = "INSERT INTO moneys(money_amount,user_id,date) VALUES(@money_amount,@user_id,@date)";
                SqlCommand command = new SqlCommand(sorgu, connection);

                command.Parameters.AddWithValue("@money_amount", txtFiyat.Text);
                command.Parameters.AddWithValue("@user_id", txtUserId.Text);
                command.Parameters.AddWithValue("@date", dateTimePicker1.Value);
                connection.Open();
                command.ExecuteNonQuery();




                connection.Close();
                MessageBox.Show("Bakiye ekleme işleminiz tamamlanmıştır.");
                Borsa borsa = new Borsa();
                borsa.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bakiye ekleme işlemi tamamlanamadı.");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Admin onayının kontrolü
            if (cbxOnay.Text == "Evet")
            {
                
                var xmldoc = new XmlDocument();


                //Adminin seçtiği gün bilgisine göre döviz kurunun alınması
                string day = dateTimePicker1.Value.Day.ToString();

                //Adminin seçtiği ay bilgisine göre döviz kurunun alınması
                string month = dateTimePicker1.Value.Month.ToString();

                //Adminin seçtiği yıl bilgisine göre döviz kurunun alınması
                string year = dateTimePicker1.Value.Year.ToString();

                int ay = Convert.ToInt32(month);

                int gun = Convert.ToInt32(day);

                //Seçtiği ay tek rakamla başlıyorsa başına 0 ekliyoruz.
                if (ay <= 9)
                {
                    month = "0" + dateTimePicker1.Value.Month.ToString();
                }
                else
                {
                    month = dateTimePicker1.Value.Month.ToString();

                }
                //Seçtiği gün tek rakamla başlıyorsa başına 0 ekliyoruz.
                if (gun <= 9)
                {
                    day = "0" + dateTimePicker1.Value.Day.ToString();
                }
                else
                {
                    day = dateTimePicker1.Value.Day.ToString();

                }

                //Merkez bankasından verileri seçilen tarihe göre çekiyoruz.
                string url = string.Empty;
                url = string.Format("http://www.tcmb.gov.tr/kurlar/{0}{1}/{2}{1}{0}.xml",year,month,day);

                xmldoc.Load(url);
                DateTime tarih = Convert.ToDateTime(xmldoc.SelectSingleNode("//Tarih_Date").Attributes["Tarih"].Value);
                string sterlin = xmldoc.SelectSingleNode("Tarih_Date/Currency [@Kod='GBP']/BanknoteSelling").InnerXml;
                lblDöviz.Text = string.Format("Tarih:{0}", tarih.ToShortDateString());
                txtDöviz.Text = string.Format("{0}", sterlin);


                //Seçilen tarihe göre toplam bakiyenin hesaplanması
                double fiyat = Convert.ToDouble(txtDöviz.Text) * Convert.ToDouble(txtFiyat.Text);
                txtFiyat.Text = fiyat.ToString();
                goingData8 = txtFiyat.Text;





              



                //Alıcı bilgilerini veritabanına kaydetme
                string sorgu = "INSERT INTO moneys(money_amount,user_id,date) VALUES(@money_amount,@user_id,@date)";
                SqlCommand command = new SqlCommand(sorgu, connection);

                command.Parameters.AddWithValue("@money_amount", txtFiyat.Text);
                command.Parameters.AddWithValue("@user_id", txtUserId.Text);
                command.Parameters.AddWithValue("@date", dateTimePicker1.Value);
                connection.Open();
                command.ExecuteNonQuery();




                connection.Close();
                MessageBox.Show("Bakiye ekleme işleminiz tamamlanmıştır.");
                Borsa borsa = new Borsa();
                borsa.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bakiye ekleme işlemi tamamlanamadı.");
            }

        }

        private void txtDöviz_TextChanged(object sender, EventArgs e)
        {

            txtDöviz.Text = txtDöviz.Text.Replace(".", ",");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Admin onayının kontrolü
            if (cbxOnay.Text == "Evet")
            {
                //Alıcının toplam bakiyesinin Alici formundan otomatik getirilmesi
                goingData8 = txtFiyat.Text;


                //Alici bilgilerini veritabanına kaydetme
                string sorgu = "INSERT INTO moneys(money_amount,user_id,date) VALUES(@money_amount,@user_id,@date)";
                SqlCommand command = new SqlCommand(sorgu, connection);

                command.Parameters.AddWithValue("@money_amount", txtFiyat.Text);
                command.Parameters.AddWithValue("@user_id", txtUserId.Text);
                command.Parameters.AddWithValue("@date", dateTimePicker1.Value);
                connection.Open();
                command.ExecuteNonQuery();


                







                connection.Close();
                MessageBox.Show("Bakiye ekleme işleminiz tamamlanmıştır.");
                Borsa borsa = new Borsa();
                borsa.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bakiye ekleme işlemi tamamlanamadı.");
            }

        }
    }
}
