﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NiehausResume
{
    public partial class Explain : Form
    {
        public Explain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void setMessage(string message)
        {
            lbl_ExplainHeader.Text = message;
        }


    }
}
