using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    
    public partial class Calculadora : Form
    {
        
        public Calculadora()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

      

        private void punto_Click(object sender, EventArgs e)
        {
            textBox1.Text += ",";
        }

        private void igual_Click(object sender, EventArgs e)
        {
            float num1, num2;
            string[] cadena;
            if (textBox1.Text.Contains('+'))
            {
                cadena = textBox1.Text.Split('+');
                num1 = float.Parse(cadena[0]);
                num2 = float.Parse(cadena[1]);
                textBox1.Text = Convert.ToString(num1+num2);

            }
            if (textBox1.Text.Contains('-'))
            {
                cadena = textBox1.Text.Split('-');
                num1 = float.Parse(cadena[0]);
                num2 = float.Parse(cadena[1]);
                textBox1.Text = Convert.ToString(num1 -num2);

            }
            if (textBox1.Text.Contains('/'))
            {
                cadena = textBox1.Text.Split('/');
                num1 = float.Parse(cadena[0]);
                num2 = float.Parse(cadena[1]);
                textBox1.Text = Convert.ToString(num1 / num2);

            }
            if (textBox1.Text.Contains('*'))
            {
                cadena = textBox1.Text.Split('*');
                num1 = float.Parse(cadena[0]);
                num2 = float.Parse(cadena[1]);
                textBox1.Text = Convert.ToString(num1 * num2);

            }
        }

        private void division_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                textBox1.Text += "/";
            }
           
        }

        private void multiplicacion_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != string.Empty)
            {
                textBox1.Text += "*";
            }
        }

        private void resta_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                textBox1.Text += "-";
            }
        }

        private void suma_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != string.Empty)
            {
                textBox1.Text += "+";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "1";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
           
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
