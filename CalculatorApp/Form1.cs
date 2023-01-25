using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float num1, ans;
        int count;
        public void disable()
        {
            textBox1.Enabled = false;
            button_on.Show();
            button_off.Hide();
            button_dzero.Enabled = false;
            button_0.Enabled = false;
            button_1.Enabled = false;
            button_2.Enabled = false;
            button_3.Enabled = false;
            button_4.Enabled = false;
            button_5.Enabled = false;
            button_6.Enabled = false;
            button_7.Enabled = false;
            button_8.Enabled = false;
            button_9.Enabled = false;
            button_div.Enabled = false;
            button_mul.Enabled = false;
            button_bs.Enabled = false;
            button_c.Enabled = false;
            button_poi.Enabled = false;
            button_per.Enabled = false;
            button_ans.Enabled = false;
            button_plus.Enabled = false;
            button_minus.Enabled = false;
        }

        public void enable()
        {
            textBox1.Enabled = true;
            button_on.Hide();
            button_off.Show();
            button_dzero.Enabled = true;
            button_0.Enabled = true;
            button_1.Enabled = true;
            button_2.Enabled = true;
            button_3.Enabled = true;
            button_4.Enabled = true;
            button_5.Enabled = true;
            button_6.Enabled = true;
            button_7.Enabled = true;
            button_8.Enabled = true;
            button_9.Enabled = true;
            button_div.Enabled = true;
            button_mul.Enabled = true;
            button_bs.Enabled = true;
            button_c.Enabled = true;
            button_poi.Enabled = true;
            button_per.Enabled = true;
            button_ans.Enabled = true;
            button_plus.Enabled = true;
            button_minus.Enabled = true;
        }
        private void button_1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "1";
            else
                textBox1.Text = textBox1.Text += 1;
        }
        private void button_2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "2";
            else
                textBox1.Text = textBox1.Text += 2;
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "3";
            else
                textBox1.Text = textBox1.Text += 3;
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "4";
            else
                textBox1.Text = textBox1.Text += 4;
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "5";
            else
                textBox1.Text = textBox1.Text += 5;
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "6";
            else
                textBox1.Text = textBox1.Text += 6;
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "7";
            else
                textBox1.Text = textBox1.Text += 7;
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "8";
            else
                textBox1.Text = textBox1.Text += 8;
        }

        private void button_on_Click(object sender, EventArgs e)
        {
            enable();
        }

        private void button_off_Click(object sender, EventArgs e)
        {
            disable();
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                num1 = float.Parse(textBox1.Text);
                textBox1.Clear();
                textBox1.Focus();
                count = 1;
            }
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 2;
        }

        private void button_div_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 4;
        }

        private void button_mul_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
            count = 3;
        }

        private void button_per_Click(object sender, EventArgs e)
        {
            ans = float.Parse(textBox1.Text);
            ans = ans / 100;
            textBox1.Text = ans.ToString();
        }

        private void button_0_Click(object sender, EventArgs e)
        {
           textBox1.Text = textBox1.Text += 0;
        }

        private void button_dzero_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "0";
            else
                textBox1.Text = textBox1.Text + 0+0;
        }

        private void button_poi_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void button_ans_Click(object sender, EventArgs e)
        {
            compute(count);
        }
        public void compute(int count)
        {
            switch(count)
            {
                case 1:
                    ans = num1 - float.Parse(textBox1.Text);
                        textBox1.Text = ans.ToString();
                    break;
                case 2:
                    ans = num1 + float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case 3:
                    ans = num1 * float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                case 4:
                    ans = num1 / float.Parse(textBox1.Text);
                    textBox1.Text = ans.ToString();
                    break;
                default:
                    break;


            }
        }

        private void button_c_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            count = 0;
        }

        private void button_bs_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length>0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
            }
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "9";
            else
                textBox1.Text = textBox1.Text += 9;
        }

        
    }
}
