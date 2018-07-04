using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FunctionalityDll;

namespace SentinelUpDemo
{
    public partial class Form1 : Form
    {
        FunctionalityDll.Class1 newFunction = new Class1();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(newFunction.SayHi());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(newFunction.SayBay());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text += " " + Class1.version;
            button2.Visible = newFunction.EnableButton();
        }
    }
}
