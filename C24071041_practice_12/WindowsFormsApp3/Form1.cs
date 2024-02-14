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

        public class Mine_Button : Button
        {
            public bool is_Mine = false;
        }
        string file = @".\Mine.txt.txt";
        


        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Mine_Event(object sender, EventArgs e)
        {
            Mine_Button clicked = (Mine_Button)sender;
            if(clicked.Enabled)
            {
                clicked.Enabled = false;
                if(clicked.is_Mine)
                {
                    MessageBox.Show("你踩到炸彈了","BOOM",MessageBoxButtons.OK, MessageBoxIcon.None);
                    clicked.Text = "*";

                }
            }
        }
        int x, y;
        Mine_Button[,] Mine_map;
        private void button1_Click(object sender, EventArgs e)
        {
            
            StreamReader sr = new StreamReader(file);
            
            x= int.Parse(sr.ReadLine());
            y= int.Parse(sr.ReadLine());

            Mine_map = new Mine_Button[y, x];
            string Map_Line = "";
            for(int i = 0; i < y; ++i)
            {
                Map_Line = sr.ReadLine();
                for (int j = 0; j <x;++j)
                {
                    Mine_map[i, j] = new Mine_Button();
                    Mine_map[i, j].Size = new Size(50, 50);
                    Mine_map[i, j].Location = new Point(50 * j, 50 * i);
                    Mine_map[i, j].Click += Mine_Event;
                    Controls.Add(Mine_map[i, j]);
                    if(Map_Line[j] == '*')
                    {
                        Mine_map[i, j].is_Mine = true;
                    }
                    else
                    {
                        Mine_map[i, j].is_Mine = false;

                    }
                    
                }


            }
           
            
            sr.Close();
        }
        bool vis = false;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == 80)
            {
                if(vis == false)
                {
                    for (int i = 0; i < y; ++i)
                    {
                        for (int j = 0; j < x; ++j)
                        {
                            if(Mine_map[i, j].Enabled == true)
                            {
                                if (Mine_map[i, j].is_Mine == true)
                                {
                                    Mine_map[i, j].Text = "*";
                                }
                            }
                            

                        }
                    }
                    vis = true;

                }
                else
                {
                    for (int i = 0; i < y; ++i)
                    {
                        for (int j = 0; j < x; ++j)
                        {
                            if(Mine_map[i, j].Enabled == true)
                            {
                                if (Mine_map[i, j].is_Mine == true)
                                {
                                    Mine_map[i, j].Text = "";
                                }
                            }
                            

                        }
                    }
                    vis = false;
                }
            }
        }
    }
}
