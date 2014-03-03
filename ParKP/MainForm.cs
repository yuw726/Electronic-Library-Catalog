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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void loginComplectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ComplectDialog complectDialog = new ComplectDialog(this);
            complectDialog.Show();
        }

        private void loginIssueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IssueDialog issueDialog = new IssueDialog(this);
            issueDialog.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool already_in_list = false;

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if ((dataGridView1.Rows[i].Cells[0].Value != null)                     &&
                    (dataGridView1.Rows[i].Cells[1].Value != null)                     &&
                    (dataGridView1.Rows[i].Cells[2].Value != null)                     && 
                    (dataGridView1.Rows[i].Cells[0].Value.ToString() == textBox1.Text) &&
                    (dataGridView1.Rows[i].Cells[1].Value.ToString() == textBox2.Text) &&
                    (dataGridView1.Rows[i].Cells[2].Value.ToString() == textBox3.Text))
                {
                    already_in_list = true;
                }
            }
            if (!already_in_list)
            {
                dataGridView1.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, "есть");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                OrderPublicationDialog opDialog = new OrderPublicationDialog();
                opDialog.ShowDialog();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button2, "Выберите книгу в списке найденных изданий и нажмите кнопку \"Заказать\", чтобы внести книгу в свою карточку");
        }
    }
}
