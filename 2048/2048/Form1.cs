using System;
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


        
        static PictureBox[,] kepek = new PictureBox[4, 4];
        static Label[,] labelek = new Label[4, 4];
        
        public A2048()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            generatemap();
            
            startup();

        }

        private void generatemap()
        {
            
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    PictureBox uj = new PictureBox();
                    uj.Location = new Point(12 + 75 * j + 5 * j, 12 + 75 * i + 5 * i);
                    uj.Size = new Size(75, 75);
                    uj.Name = $"{i}_{j}";
                    kepek[i, j] = uj;
                    
                        uj.Image = Image.FromFile("1767_hi_res.png");
                    

                    uj.BackColor = Color.Transparent;
                    
                    this.Controls.Add(uj);
                    
                }
            }

            
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Label uj2 = new Label();
                    uj2.Location = new Point(12 + 75 * j + 5 * j, 12 + 75 * i + 5 * i);
                    uj2.Size = new Size(75, 75);
                    uj2.Name = $"{i}_{j}";
                    labelek[i, j] = uj2;
                    
                        uj2.Text = "";
                    

                    uj2.BackColor = Color.Transparent;
                    
                    this.Controls.Add(uj2);

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
                kepek[x, y].Image= Image.FromFile($"{number}.png");
            }
            else
            {
                putnumber();
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
            string direction="bal";
            putnumber();
            Movolas(direction);
            
        }

        private void Movolas(string irany)
        {
            switch (irany)
            {
                case "bal":
                    for (int i = 0; i < 4; i++)
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            for (int h = j; h == 1; h--)
                            {
                                if (labelek[i,j-1].Text=="")
                                {
                                    labelek[i, j - 1].Text = labelek[i, j].Text;
                                    labelek[i, j].Text="";
                                    kepek[i, j - 1].Image = kepek[i, j].Image;
                                    kepek[i, j].Image= Image.FromFile("1767_hi_res.png");
                                }
                                else if(labelek[i, j - 1].Text == labelek[i, j].Text)
                                {
                                    int num = Convert.ToInt32(labelek[i, j - 1].Text);
                                    labelek[i, j].Text = "";
                                    kepek[i,j].Image= Image.FromFile("1767_hi_res.png");
                                    labelek[i, j - 1].Text = (num * 2).ToString();
                                    kepek[i, j - 1].Image = Image.FromFile($"{num*2}.png");
                                }
                            }
                        }
                    }
                    break;
                case "fel":
                    for (int i = 0; i < 4; i++)
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            for (int h = i; h == 1; h++)
                            {
                                if (labelek[i - 1, j].Text == "")
                                {
                                    labelek[i - 1, j].Text = labelek[i, j].Text;
                                    labelek[i, j].Text = "";
                                    kepek[i - 1, j].Image = kepek[i, j].Image;
                                    kepek[i, j].Image = Image.FromFile("1767_hi_res.png");
                                }
                                else if (labelek[i - 1, j].Text == labelek[i, j].Text)
                                {
                                    int num = Convert.ToInt32(labelek[i - 1, j].Text);
                                    labelek[i, j].Text = "";
                                    kepek[i, j].Image = Image.FromFile("1767_hi_res.png");
                                    labelek[i - 1, j].Text = (num * 2).ToString();
                                    kepek[i - 1, j].Image = Image.FromFile($"{num * 2}.png");
                                }
                            }
                        }
                    }
                    break;
                case "le":
                    for (int i = 0; i < 4; i++)
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            for (int h = i; h == 4; h++)
                            {
                                if (labelek[i + 1, j].Text == "")
                                {
                                    labelek[i + 1, j ].Text = labelek[i, j].Text;
                                    labelek[i, j].Text = "";
                                    kepek[i + 1, j].Image = kepek[i, j].Image;
                                    kepek[i, j].Image = Image.FromFile("1767_hi_res.png");
                                }
                                else if (labelek[i + 1, j].Text == labelek[i, j].Text)
                                {
                                    int num = Convert.ToInt32(labelek[i + 1, j].Text);
                                    labelek[i, j].Text = "";
                                    kepek[i, j].Image = Image.FromFile("1767_hi_res.png");
                                    labelek[i + 1, j].Text = (num * 2).ToString();
                                    kepek[i + 1, j].Image = Image.FromFile($"{num * 2}.png");
                                }
                            }
                        }
                    }
                    break;
                case "jobb":
                    for (int i = 0; i < 4; i++)
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            for (int h = j; h == 4; h++)
                            {
                                if (labelek[i, j +1].Text == "")
                                {
                                    labelek[i, j +1].Text = labelek[i, j].Text;
                                    labelek[i, j].Text = "";
                                    kepek[i, j + 1].Image = kepek[i, j].Image;
                                    kepek[i, j].Image = Image.FromFile("1767_hi_res.png");
                                }
                                else if (labelek[i, j + 1].Text == labelek[i, j].Text)
                                {
                                    int num = Convert.ToInt32(labelek[i, j + 1].Text);
                                    labelek[i, j].Text = "";
                                    kepek[i, j].Image = Image.FromFile("1767_hi_res.png");
                                    labelek[i, j + 1].Text = (num * 2).ToString();
                                    kepek[i, j + 1].Image = Image.FromFile($"{num * 2}.png");
                                }
                            }
                        }
                    }
                    break;
            }
        }

        private void Fbtn_Click(object sender, EventArgs e)
        {
            string direction = "fel";
            putnumber();
            Movolas(direction);
        }

        private void Jbtn_Click(object sender, EventArgs e)
        {
            string direction = "jobb";
            putnumber();
            Movolas(direction);
        }

        private void Lbtn_Click(object sender, EventArgs e)
        {
            string direction = "le";
            putnumber();
            Movolas(direction);
        }
    }
}
