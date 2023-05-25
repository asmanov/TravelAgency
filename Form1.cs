using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelAgency
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.panel2.Controls.Clear();
            this.panel2.Controls.Add(label2);
            this.panel2.Controls.Add(textBox1);
            this.panel2.Controls.Add(label3);
            this.panel2.Controls.Add(textBox2);
            button1.Text = "Log In";
            button1.Location = new Point(90, 370);
            this.panel2.Controls.Add(button1);

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.panel2.Controls.Clear();
            this.panel2.Controls.Add(label2);
            this.panel2.Controls.Add(textBox1);
            this.panel2.Controls.Add(label3);
            this.panel2.Controls.Add(textBox2);
            label4.Location = new Point(55, 250);
            this.panel2.Controls.Add(label4);
            textBox3.Location = new Point(24, 310);
            textBox3.Width = textBox2.Width;
            this.panel2.Controls.Add(textBox3);
            button1.Text = "Registr";
            button1.Location = new Point(90, 370);
            this.panel2.Controls.Add(button1);
            //this.panel2.Controls.Add(this.label4);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
