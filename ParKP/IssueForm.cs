using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParKP
{
    public partial class IssueForm : Form
    {
        MainForm mainForm;
            
        public IssueForm(MainForm main)
        {
            InitializeComponent();

            mainForm = main;
            mainForm.Hide();
        }


        private void IssueForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "111")
            {
                dataGridView1.Rows.Add("Преступление и наказание", "Достоевский, Фёдор Михайлович", "ЭБК110242", "10.12.2012", "21.12.2012");
            }
        }
    }
}
