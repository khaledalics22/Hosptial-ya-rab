﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_ISA
{
    public partial class AppointsInfo : Form
    {
        public AppointsInfo()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Appoints a = new Appoints();
            a.Show();
            Close();
        }

        private void AppointsInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
