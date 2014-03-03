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
    public partial class ComplectForm : Form
    {
        MainForm mainForm;
        
        public ComplectForm(MainForm main)
        {
            InitializeComponent();

            mainForm = main;
            mainForm.Hide();
        }


        private void ComplectForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ComplectFormEditDialog cfeDialog = new ComplectFormEditDialog(textBox1, textBox2, textBox3);
            cfeDialog.ShowDialog();
            if (cfeDialog.submitChanges)
            {
                textBox1.Text = cfeDialog.textBox1.Text;
                textBox2.Text = cfeDialog.textBox2.Text;
                textBox3.Text = cfeDialog.textBox3.Text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
