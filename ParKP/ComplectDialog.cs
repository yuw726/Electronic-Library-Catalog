﻿using System;
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
    public partial class ComplectDialog : Form
    {
        //TODO: убрать этот костыль!
        MainForm mainForm;
        
        public ComplectDialog(MainForm main)
        {
            InitializeComponent();
            mainForm = main;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ComplectForm complect = new ComplectForm(mainForm);
            complect.Show();
            this.Close();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
