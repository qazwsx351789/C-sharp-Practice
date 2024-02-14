using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Text = " ";
            textBox2.PasswordChar = '*';
            label4.Visible = false;
            textBox3.Visible = false;
            button3.Visible = false;
            button2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="C24071041"&&textBox2.Text== "C24071041")
            {
                label3.Text = "C24071041，登入成功";
                label4.Visible = true;
                textBox3.Visible = true;
                button3.Visible = true;
                button2.Visible = true;
            }
            else
            {
                label3.Text = "登入失敗";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            float T = float.Parse(textBox3.Text);
            
            if(T>37.9)
            {
                MessageBox.Show("你發燒了", "注意", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("你沒發燒", "安全", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("是否登出", "登出", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                label3.Text = "";
                textBox3.Text = "";
                textBox2.Text = "";
                textBox1.Text = "";
                label4.Visible = false;
                textBox3.Visible = false;
                button3.Visible = false;
                button2.Visible = false;
            }
        }
    }
    
}
