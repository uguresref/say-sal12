using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
namespace sayısal_loto
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            label1.Text = rnd.Next(1, 8).ToString();
            label2.Text = rnd.Next(9, 16).ToString();
            label3.Text = rnd.Next(17, 25).ToString();
            label4.Text = rnd.Next(26, 33).ToString();
            label6.Text = rnd.Next(42, 49).ToString();
            label5.Text = rnd.Next(34, 41).ToString();
           // metroTile1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            
        }
    }
}
