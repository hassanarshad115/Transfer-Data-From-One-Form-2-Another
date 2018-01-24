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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string namep { get; set; }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = namep;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            Form1 f = new Form1(); ;

            int updaterow = dataGridView1.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            string obj = Convert.ToString(dataGridView1.Rows[updaterow].Cells[0].Value);

            f.dgvp = obj.ToString();

            f.ShowDialog();
        }
    }
}
