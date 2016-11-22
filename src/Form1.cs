using System;
using System.Drawing;
using System.Windows.Forms;

namespace EmptyProject
{
    public partial class Form1
    {
        private int i;
        readonly Random t = new Random();

        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            MaximizeBox = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(255, t.Next(0, 255), t.Next(0, 255), t.Next(0, 255));
        }
    }

}