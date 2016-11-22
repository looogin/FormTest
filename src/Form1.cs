using System;
using System.Drawing;

namespace EmptyProject
{
    public partial class Form1
    {
        private readonly Color[] cd = {Color.Red,Color.Beige,Color.Coral,Color.Green, Color.GreenYellow };
        private  int i;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = cd[i];
            i++;
            if (i >= cd.Length) i = 0;
            Console.WriteLine(i);
        }
    }
}