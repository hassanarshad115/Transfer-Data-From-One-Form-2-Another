using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string dgvp { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.namep = textBox1.Text;
            f.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = dgvp;
        }
    }
}
