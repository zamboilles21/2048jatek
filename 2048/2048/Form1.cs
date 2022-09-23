﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2048
{
    public partial class A2048 : Form
    {



        
        static Label[,] labelek = new Label[4, 4];
        public static string konami;
        public A2048()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            generatemap();
            szinezo();
            startup();

        }

        private void szinezo()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    switch (labelek[i,j].Text)
                    {
                        
                        case "2":
                            labelek[i, j].BackColor = Color.DodgerBlue;
                            break;
                        case "4":
                            labelek[i, j].BackColor = Color.FromArgb(68, 228, 54);
                            break;
                        case "8":
                            labelek[i, j].BackColor = Color.FromArgb(44, 146, 97);
                            break;
                        case "16":
                            labelek[i, j].BackColor = Color.FromArgb(211, 213, 55);
                            break;
                        case "32":
                            labelek[i, j].BackColor = Color.FromArgb(211, 200, 55);
                            break;
                        case "64":
                            labelek[i, j].BackColor = Color.FromArgb(200, 156, 85);
                            break;
                        case "128":
                            labelek[i, j].BackColor = Color.FromArgb(192, 200, 69);
                            break;
                        case "256":
                            labelek[i, j].BackColor = Color.FromArgb(70, 98, 198);
                            break;
                        case "512":
                            labelek[i, j].BackColor = Color.FromArgb(248, 4, 82);
                            break;
                        case "1024":
                            labelek[i, j].BackColor = Color.FromArgb(125, 131, 113);
                            break;
                        case "2048":
                            labelek[i, j].BackColor = Color.FromArgb(125, 125, 125);
                            break;
                        default:
                            labelek[i, j].BackColor = Color.HotPink;
                            break;

                    }
                }
            }
            
        }
        
        private void generatemap()
        {
            Font font = new Font("Arial", 20);
            

            
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Label cimke = new Label();
                    cimke.Location = new Point(12 + 75 * j + 5 * j, 12 + 75 * i + 5 * i);
                    cimke.Size = new Size(75, 75);
                    cimke.Name = $"{i}_{j}";
                    labelek[i, j] = cimke;
                    cimke.TextAlign = ContentAlignment.MiddleCenter;
                        cimke.Text = "";
                    cimke.Font = font;

                    cimke.BackColor = Color.HotPink;
                    cimke.ForeColor = Color.Beige;
                    
                    this.Controls.Add(cimke);
                    labelek[i, j] = cimke;
                }
            }





        }

        private void startup()
        {

            putnumber();
            putnumber();
        }

        private void putnumber()
        {

             
            int number = generatetwoorfour();
            int x= generatelocation();
            int y = generatelocation();
            if (labelek[x, y].Text=="")
            {
                labelek[x, y].Text = number.ToString();
                szinezo();
            }
            else
            {
                putnumber();
                szinezo();
            }
            
            



        }

        private int generatelocation()
        {
            Random location = new Random();
            int x = location.Next(1, 4);
            
            return x;
            
        }

        private int generatetwoorfour()
        {
           
            Random velet = new Random();
            int decide = velet.Next(0, 2);
            if (decide == 0)
            {
                return  2;
            }
            return  4;
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void Bbtn_Click(object sender, EventArgs e)
        {
            //string direction="bal";
            pontszamolas();
            Movolas("bal");
            putnumber();
            szinezo();

        }

        private void Movolas(string irany)
        {
            switch (irany)
            {
                case "bal":
                    {
                        for (int sor = 0; sor < 4; sor++)
                        {
                            for (int oszlop = 0; oszlop < 4; oszlop++)
                            {
                                if (labelek[sor, oszlop].Text != "")
                                {
                                    for (int i = oszlop + 1; i < 4; i++)
                                    {
                                        if (labelek[sor, i].Text != labelek[sor, i].Text && labelek[sor, i].Text != "") break;
                                        if (labelek[sor, i].Text == labelek[sor, i].Text)
                                        {
                                            labelek[sor, oszlop].Text = (Convert.ToInt32(labelek[sor, oszlop].Text) * 2).ToString();
                                            labelek[sor, i].Text = "";

                                            break;
                                        }
                                    }
                                }
                            }
                        }
                        for (int sor = 0; sor < 4; sor++)
                        {
                            for (int oszlop = 0; oszlop < 4; oszlop++)
                            {
                                if (labelek[sor, oszlop].Text == "")
                                {
                                    for (int i = oszlop + 1; i < 4; i++)
                                    {
                                        if (labelek[sor, i].Text != "")
                                        {
                                            labelek[sor, oszlop].Text = labelek[sor, i].Text;
                                            labelek[sor, i].Text = "";

                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    break;
                case "fel":
                    {
                        for (int sor = 0; sor < 4; sor++)
                        {
                            for (int oszlop = 0; oszlop < 4; oszlop++)
                            {
                                if (labelek[sor, oszlop].Text != "")
                                {
                                    for (int i = sor + 1; i < 4; i++)
                                    {
                                        if (labelek[i, oszlop].Text != labelek[sor, oszlop].Text && labelek[i, oszlop].Text != "") break;
                                        if (labelek[i, oszlop].Text == labelek[sor, oszlop].Text)
                                        {
                                            labelek[sor, oszlop].Text = (Convert.ToInt32(labelek[sor, oszlop].Text) * 2).ToString();
                                            labelek[i, oszlop].Text = "";

                                            break;
                                        }
                                    }
                                }
                            }
                        }
                        for (int sor = 0; sor < 4; sor++)
                        {
                            for (int oszlop = 0; oszlop < 4; oszlop++)
                            {
                                if (labelek[sor, oszlop].Text == "")
                                {
                                    for (int i = sor + 1; i < 4; i++)
                                    {
                                        if (labelek[i, oszlop].Text != "")
                                        {
                                            labelek[sor, oszlop].Text = labelek[i, oszlop].Text;
                                            labelek[i, oszlop].Text = "";

                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    break;
                case "le":
                    {
                        for (int sor = 4; sor >=0; sor--)
                        {
                            for (int oszlop = 0; oszlop < 4; oszlop++)
                            {
                                if (labelek[sor, oszlop].Text != "")
                                {
                                    for (int i = sor - 1; i >=0; i--)
                                    {
                                        if (labelek[i, oszlop].Text != labelek[sor, oszlop].Text && labelek[i, oszlop].Text != "") break;
                                        if (labelek[i, oszlop].Text == labelek[sor, oszlop].Text)
                                        {
                                            labelek[sor, oszlop].Text = (Convert.ToInt32(labelek[sor, oszlop].Text) * 2).ToString();
                                            labelek[i, oszlop].Text = "";

                                            break;
                                        }
                                    }
                                }
                            }
                        }
                        for (int sor = 0; sor < 4; sor++)
                        {
                            for (int oszlop = 4; oszlop >=0; oszlop++)
                            {
                                if (labelek[sor, oszlop].Text == "")
                                {
                                    for (int i = sor + 1; i < 4; i++)
                                    {
                                        if (labelek[i, oszlop].Text != "")
                                        {
                                            labelek[sor, oszlop].Text = labelek[i, oszlop].Text;
                                            labelek[i, oszlop].Text = "";

                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    break;
                case "jobb":
                    {
                        for (int sor = 4; sor >= 0; sor++)
                        {
                            for (int oszlop = 4; oszlop >=0; oszlop--)
                            {
                                if (labelek[sor, oszlop].Text != "")
                                {
                                    for (int i = oszlop - 1; i >=0; i++)
                                    {
                                        if (labelek[sor, i].Text != labelek[sor, i].Text && labelek[sor, i].Text != "") break;
                                        if (labelek[sor, i].Text == labelek[sor, i].Text)
                                        {
                                            labelek[sor, oszlop].Text = (Convert.ToInt32(labelek[sor, oszlop].Text) * 2).ToString();
                                            labelek[sor, i].Text = "";

                                            break;
                                        }
                                    }
                                }
                            }
                        }
                        for (int sor = 0; sor < 4; sor++)
                        {
                            for (int oszlop = 0; oszlop >= 4; oszlop--)
                            {
                                if (labelek[sor, oszlop].Text == "")
                                {
                                    for (int i = oszlop - 1; i < 4; i++)
                                    {
                                        if (labelek[sor, i].Text != "")
                                        {
                                            labelek[sor, oszlop].Text = labelek[sor, i].Text;
                                            labelek[sor, i].Text = "";

                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    break;
            }
        }

        private void Fbtn_Click(object sender, EventArgs e)
        {
            //string direction = "fel";
            pontszamolas();
            Movolas("fel");

            putnumber();
            szinezo();
        }

        private void Jbtn_Click(object sender, EventArgs e)
        {
            //string direction = "jobb";

            pontszamolas();

            

            Movolas("jobb");

            putnumber();
            szinezo();
        }

        private void pontszamolas()
        {
            int score = Convert.ToInt32(score_lbl.Text);
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; i < 4; i++)
                {
                    if(labelek[i, j].Text != "")
                    {
                        score +=Convert.ToInt32(labelek[i, j].Text);
                    }
                }
            }
            score_lbl.Text = score.ToString();
        }

        private void Lbtn_Click(object sender, EventArgs e)
        {
            //string direction = "le";
            pontszamolas();
            Movolas("le");
            
            putnumber();
            szinezo();
        }

        

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.W:
                case Keys.Up:
                    Movolas("fel");
                    szinezo();
                    break;

                case Keys.S:
                case Keys.Down:
                    Movolas("le");
                    szinezo();
                    break;

                case Keys.D:
                case Keys.Right:
                    Movolas("jobbra");
                    szinezo();
                    break;

                case Keys.A:
                case Keys.Left:
                    Movolas("balra");
                    szinezo();
                    break;

                default:
                    break;
            }
        }

        private void WASD_Click(object sender, EventArgs e)
        {
            if (Jbtn.Enabled == false)
            {
                Jbtn.Enabled = true;
                Lbtn.Enabled = true;
                Fbtn.Enabled = true;
                Bbtn.Enabled = true;
            }
            else
            {
                Jbtn.Enabled = false;
                Lbtn.Enabled = false;
                Fbtn.Enabled = false;
                Bbtn.Enabled = false;
            }
            



        }
    }
}
