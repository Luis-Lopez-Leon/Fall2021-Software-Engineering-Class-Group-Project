﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Health_Care_App.Forms
{
    public partial class BluetoothMonitoring : Form
    {
        public BluetoothMonitoring()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tools tools = new Tools();
            tools.Show();
        }
    }
}