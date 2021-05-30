using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Odev
{
    public partial class Sonuc : Form
    {
        public Sonuc()
        {
            InitializeComponent();
        }

        private void Sonuc_Load(object sender, EventArgs e)
        {
            textBox1.Text = Borsa.goData.ToString();
            textBox2.Text = Borsa.goData2.ToString();
         
        }
    }
}
