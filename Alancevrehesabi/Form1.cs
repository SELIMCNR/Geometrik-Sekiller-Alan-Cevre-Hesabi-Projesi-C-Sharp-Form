using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Alancevrehesabi
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int kare()
        {
            int kenar, alan, cevre;
            kenar = Convert.ToInt32(textBox1.Text);
            alan = kenar * kenar;
            textBox2.Text = alan.ToString();

            cevre = kenar * 4;
            textBox3.Text = cevre.ToString();
            return 0;
        }
        int dikdörtgen()
        {
            int kenar1, kenar2, alan1, cevre1;
            kenar1 = Convert.ToInt32(textBox4.Text);
            kenar2 = Convert.ToInt32(textBox5.Text);
            alan1 = kenar1 * kenar2;
            textBox6.Text = alan1.ToString();
            cevre1 = (kenar1 + kenar2) * 2;
            textBox7.Text = cevre1.ToString();
            return 0;
        }
        int dikucgen()
        {
            int kenar1, kenar2, kenar3;
            float taban, yukseklik, alan, cevre;

            kenar1 = Convert.ToInt32(textBox10.Text);
            kenar2 = Convert.ToInt32(textBox11.Text);
            kenar3 = Convert.ToInt32(textBox12.Text);
            taban = float.Parse(textBox13.Text);
            yukseklik = float.Parse(textBox14.Text);

            alan = (taban * yukseklik) / 2;
            textBox9.Text = alan.ToString();
            cevre = kenar1 + kenar2 + kenar3;
            textBox8.Text = cevre.ToString();
            return 0;
        }
        int eskenarucgen()
        {
            int kenar;
            double alan, cevre, r;
            kenar = Convert.ToInt32(textBox16.Text);
            r = float.Parse(textBox17.Text);
            r = Math.Sqrt(3) / 4;
            alan = r * kenar * kenar;
            textBox18.Text = alan.ToString();
            cevre = cevre = kenar * 3;
            textBox15.Text = cevre.ToString();
            return 0;
        }
        int cesitkenarucgen()
        {
            int kenar1, kenar2, kenar3;
            double alan, cevre;
            kenar1 = Convert.ToInt32(textBox25.Text);
            kenar2 = Convert.ToInt32(textBox22.Text);
            kenar3 = Convert.ToInt32(textBox21.Text);

            if ((kenar1 != kenar2 && kenar2 != kenar3) && (kenar3 != kenar1))
            {
                alan = (kenar1 + kenar2 + kenar3) / 2;
                textBox24.Text = alan.ToString();
                cevre = kenar1 + kenar2 + kenar3;
                textBox23.Text = cevre.ToString();
            }
            else
            {
                MessageBox.Show("Değerlerde hata var");
            }
            return 0;
        }
        int daire()
        {
            double r, alan, cevre;
            double pi = double.Parse(textBox20.Text);
            textBox20.Text = pi.ToString();

            r = double.Parse(textBox26.Text);
            textBox26.Text = r.ToString();

            alan = alan = r * r * pi;
            textBox27.Text = alan.ToString();
            cevre = cevre = 2 * pi * r;
            textBox19.Text = cevre.ToString();
            return 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            kare();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           dikdörtgen();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           dikucgen();
        }

        private void button4_Click(object sender, EventArgs e)
        {
         eskenarucgen();
        }

        private void button5_Click(object sender, EventArgs e)
        {
          cesitkenarucgen();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            daire();
        }
    }
}
