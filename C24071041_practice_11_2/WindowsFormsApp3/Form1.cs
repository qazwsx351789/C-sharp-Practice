using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            string path = @"" + textBox1.Text;
            try
            {
                Directory.GetFiles(path);
                if (textBox1.Text == ".")
                {
                    textBox1.Text = @".\";
                }

                foreach (string it in Directory.GetFiles(path))
                {
                    listBox1.Items.Add(it);
                }
                

                textBox1.Text = "";
            }
            catch (Exception ex)
            {
                DialogResult result;
                result = MessageBox.Show("無法開啟目錄"+ textBox1.Text+"!", "", MessageBoxButtons.OK, MessageBoxIcon.None);

            }


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SS = listBox1.SelectedItem.ToString();
            try
            {
                Image myPic = Image.FromFile(SS);
                pictureBox1.Image = myPic;
            }
            catch(OutOfMemoryException ex)
            {
                DialogResult result;
                result = MessageBox.Show(SS + "is not a image !" , "", MessageBoxButtons.OK, MessageBoxIcon.None);
            }

        }
        int current;              
        int rate;　　　　　　　　 　
        int wide, high, pX, pY;   
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            wide = pictureBox1.Width;
            high = pictureBox1.Height;
            pX = pictureBox1.Left;
            pY = pictureBox1.Top;
            current = 1;                  
            rate = 80;                    
            
        }
    }
}
