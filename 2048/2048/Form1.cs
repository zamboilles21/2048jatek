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


        static int counter = 16;
        
        public A2048()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            generatemap();
            
            //startup();

        }

        private void generatemap()
        {
            Panel [] panels = new Panel[counter];
            Label [] labels = new Label[counter];

            for (int i = 0; i < counter; i++)
            {
                panels[i] = new Panel();
                labels[i] = new Label();
            }
            for (int i = 0; i < counter; i++)
            {
                this.Controls.Add(panels[i]);
                this.Controls.Add(labels[i]);
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
            generatelocation(number);
        }

        private int generatelocation(int number)
        {
            Random location = new Random();
            int tizenhatig = location.Next(1, 17);
            
            return tizenhatig;
            




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
    }
}
