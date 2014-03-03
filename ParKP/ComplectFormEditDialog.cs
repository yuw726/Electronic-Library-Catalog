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
    public partial class ComplectFormEditDialog : Form
    {
        public bool submitChanges;
        
        public ComplectFormEditDialog(TextBox tb1, TextBox tb2, TextBox tb3)
        {
            InitializeComponent();
            textBox1.Text = tb1.Text;
            textBox2.Text = tb2.Text;
            textBox3.Text = tb3.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            submitChanges = true;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            submitChanges = false;
            this.Close();
        }
    }
}
