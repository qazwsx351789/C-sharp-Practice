﻿using System;
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

        int current;              // 目前顯示的圖像檔順序
        int rate;　　　　　　　　 // 圖像方塊的縮放比例　　
        int wide, high, pX, pY;   // 存放圖片方塊原始的大小、座標
        private int index = -1,num = -1;

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                Image myPic = Image.FromFile(@"..\pic\" + textBox1.Text);
                
                imgList.Images.Add(new Bitmap(@"..\pic\" + textBox1.Text));
                pic.Image = imgList.Images[num+1]; 
            }
            catch(System.NotSupportedException ex)
            {
                Image myPic = Image.FromFile(@"" + textBox1.Text);
                
                imgList.Images.Add(new Bitmap(@"" + textBox1.Text));
                pic.Image = imgList.Images[num+1];
            }

            
            num = num + 1;
            index = num;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pic.SizeMode = PictureBoxSizeMode.Normal;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pic.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (index < num)
            {
                index = index +1 ;
                pic.Image = imgList.Images[index];
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(index > 0)
            {
                index = index - 1;
                pic.Image = imgList.Images[index];
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            wide = pic.Width;
            high = pic.Height;
            pX = pic.Left;
            pY = pic.Top;
            current = 1;                  // 設定顯示的圖像檔順序為 1
            rate = 80;                    // 設定顯示比例為80%
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pic.Image = null;
            imgList.Images.Clear();
            index = -1;
            num = -1;
        }
    }
}
