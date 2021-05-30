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
    public partial class Satici : Form
    {
        public static string gidenBilgi1 = "";
        public static string gidenBilgi2 = "";
        public static string gidenBilgi3 = "";
        public static string gidenBilgi4 = "";
        public static string gidenBilgi5 = "";

        public Satici()
        {
            InitializeComponent();
        }
        //Veritabanı bağlantısını oluşturuyoruz.
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-PBAPHP1;Initial Catalog=scrum;Integrated Security=True");
        

        private void Satici_Load(object sender, EventArgs e)
        {
            
        }
        private void btnTamamla_Click(object sender, EventArgs e)
        {

            //Admin formunun otomatik dolması için verileri başka değişkenlere atıyoruz.
            gidenBilgi1 = cbxUrun.Text;
            gidenBilgi2 = txtMiktar.Text;
            gidenBilgi3 = txtFiyat.Text;
            gidenBilgi4 = txtUserId.Text;
            gidenBilgi5 = txtItemId.Text;



            Admin admin = new Admin();
            admin.ShowDialog();


        }

        
    }
}
