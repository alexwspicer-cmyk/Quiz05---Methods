using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace Quiz05___Methods
{
    public partial class Form3 : Form
    {
        public Form3()
        {

            InitializeComponent();



        }

        private void Form3_Load(object sender, EventArgs e)
        {
        }

        private void santaPictureBox_Click(object sender, EventArgs e)
        {
            
                BackColor = Color.Red;

                Refresh();
                Thread.Sleep(1000);

                BackColor = Color.Green;

            Refresh();
            Thread.Sleep(1000);

            BackColor = Color.Red;

            Refresh();
            Thread.Sleep(1000);

            BackColor = Color.Green;

            Refresh();
            Thread.Sleep(1000);

            BackColor = Color.Red;

            Refresh();
            Thread.Sleep(1000);

            BackColor = Color.Green;

            Refresh();
            Thread.Sleep(1000);

            BackColor = Color.Red;

            Refresh();
            Thread.Sleep(1000);

            BackColor = Color.Green;

            Refresh();
            Thread.Sleep(1000);

            BackColor = Color.Red;

            Refresh();
            Thread.Sleep(1000);

            BackColor = Color.Green;

            Refresh();
            Thread.Sleep(1000);

            santaPictureBox.Visible = true; //I don't have the file for some reason for the photo


        }

        private void Form3_Click(object sender, EventArgs e)
        {
                
            
        }
    }
}
