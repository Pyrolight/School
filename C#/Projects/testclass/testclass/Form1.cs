﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testclass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void oneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = button1.Font;
            if (  fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                button1.Font = fontDialog1.Font;
            }

        }

        private void towToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = button1.Font;
            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                button1.Font = fontDialog1.Font;
            }
        }
    }
}
