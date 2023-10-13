using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nilai1 = int.Parse(textBox2.Text);
            int nilai2 = int.Parse(textBox3.Text);
            int hasil;
            hasil = nilai1 + nilai2;
            textBox4.Text = hasil.ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int nilai1 = int.Parse(textBox2.Text);
            int nilai2 = int.Parse(textBox3.Text);
            int hasil;
            hasil = nilai1 - nilai2;
            textBox4.Text = hasil.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int nilai1 = int.Parse(textBox2.Text);
            int nilai2 = int.Parse(textBox3.Text);
            int hasil;
            hasil = nilai1 * nilai2;
            textBox4.Text = hasil.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int nilai1 = int.Parse(textBox2.Text);
            int nilai2 = int.Parse(textBox3.Text);
            int hasil;
            hasil = nilai1 / nilai2;
            textBox4.Text = hasil.ToString();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
