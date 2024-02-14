using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private int exam, text, shopping, others;
        private void Form1_Load(object sender, EventArgs e)
        {

            label1.Text = "代辦清單的數量 = " + listBox1.Items.Count;
            string[] ItemName = new string[] { "考試", "作業", "購物", "其他" };
            comboBox1.Items.AddRange(ItemName);
            comboBox1.Text = "考試";
            label2.Text = "考試 : " + 0;
            label3.Text = "作業 : " + 0;
            label4.Text = "購物 : " + 0;
            label5.Text = "其他 : " + 0;
            
            exam = 0;
            text = 0;
            shopping = 0;
            others = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            listBox1.Items.Add(comboBox1.Text + "-" + textBox1.Text);
            textBox1.Text = "";
            label1.Text = "代辦清單的數量 = " + listBox1.Items.Count;

            bool Exam, Text, Shopping, Others;
            Exam = comboBox1.Text.Contains("考試");
            Text = comboBox1.Text.Contains("作業");
            Shopping = comboBox1.Text.Contains("購物");
            Others = comboBox1.Text.Contains("其他");

            if(Exam == true)
            {
                exam++;
            }
            else if(Text == true)
            {
                text++;
            }
            else if (Shopping == true)
            {
                shopping++;
            }
            else
            {
                others++;
            }
            label2.Text = "考試 : " + exam;
            label3.Text = "作業 : " + text;
            label4.Text = "購物 : " + shopping;
            label5.Text = "其他 : " + others;

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string SS = listBox1.SelectedItem.ToString(); 
            bool Exam, Text, Shopping, Others;
            Exam = SS.Contains("考試");
            Text = SS.Contains("作業");
            Shopping = SS.Contains("購物");
            Others = SS.Contains("其他");

            if (Exam == true)
            {
                exam--;
            }
            else if (Text == true)
            {
                text--;
            }
            else if (Shopping == true)
            {
                shopping--;
            }
            else
            {
                others--;
            }
            label2.Text = "考試 : " + exam;
            label3.Text = "作業 : " + text;
            label4.Text = "購物 : " + shopping;
            label5.Text = "其他 : " + others;

            for (int i = 0; i< listBox1.Items.Count; i++)
            {
                if (listBox1.GetSelected(i))
                {
                    
                    listBox1.Items.Remove(listBox1.Items[i]);
                }

            }
            textBox1.Text = "";
            label1.Text = "代辦清單的數量 = " + listBox1.Items.Count;

            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
