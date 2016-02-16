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

namespace Form_text
{
    public partial class Form1 : Form
    {

        FileStream thefile;
        StreamWriter writer;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            writer.Close();
            thefile.Close();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            writer.WriteLine(textBox1.Text);
            textBox1.Text = " ";
            textBox1.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            thefile = File.Create("someInfo.txt");
            writer = new StreamWriter(thefile);
        }
    }
}
