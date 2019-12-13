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
           // label1.Text = rnd.Next(1, 8).ToString();
          //  label2.Text = rnd.Next(9, 16).ToString();
           // label3.Text = rnd.Next(17, 25).ToString();
          //  label4.Text = rnd.Next(26, 33).ToString();
         //   label6.Text = rnd.Next(42, 49).ToString();
          //  label5.Text = rnd.Next(34, 41).ToString();
        //   metroTile1.Enabled = false;
        
            index = 0;

            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "0";
                    item.BackColor = default;
                }
            }

            if (timer1.Enabled)
            {
                timer1.Stop();
            }
            else
            {
                timer1.Start();
            }
        
        
        }

          
        int index = 0;
        int[] sayilar = new int[6];
        private void timer1_Tick(object sender, EventArgs e)
        {
                       int sayi = rnd.Next(1, 50);
            if (index < 10)
            {
                sayilar[0] = sayi;
                t1.Text = sayilar[0].ToString();
            }

            else if (index < 20)
            {

                if (sayilar.Contains(sayi))
                {
                    index--;
                    t2.BackColor = Color.Tomato;
                }

                sayilar[1] = sayi;
                t2.Text = sayilar[1].ToString();

            }
            else if (index < 30)
            {
                if (sayilar.Contains(sayi))
                {
                    index--;
                    t3.BackColor = Color.Tomato;
                }

                sayilar[2] = sayi;
                t3.Text = sayilar[2].ToString();
            }
            else if (index < 40)
            {
                if (sayilar.Contains(sayi))
                {
                    index--;
                    t4.BackColor = Color.Tomato;
                }

                sayilar[3] = sayi;
                t4.Text = sayilar[3].ToString();
            }
            else if (index < 50)
            {
                if (sayilar.Contains(sayi))
                {
                    index--;
                    t5.BackColor = Color.Tomato;
                }

                sayilar[4] = sayi;
                t5.Text = sayilar[4].ToString();
            }
            else if (index < 60)
            {
                if (sayilar.Contains(sayi))
                {
                    index--;
                    t6.BackColor = Color.Tomato;
                }

                sayilar[5] = sayi;
                t6.Text = sayilar[5].ToString();
            }
           if (index == 70)
            {
                Array.Sort(sayilar);
                 for (int i = 0; i < sayilar.Length; i++)
                {
                    // 0 1 2 3 4 5  => index
                    // 1 2 3 4 5 6  => t+ => eleman name değeri

                    Control ctrl = Controls.Find("t" + (i + 1), false)[0];
                    ctrl.Text = sayilar[i].ToString();
                    ctrl.BackColor = default;
                    // t(0+1) => t1
                }
            }

            index++;
           // timer1.Enabled = true;
            
        }
    }
}
