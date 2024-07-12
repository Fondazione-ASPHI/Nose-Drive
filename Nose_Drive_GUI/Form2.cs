﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Nose_Drive_GUI
{
    public partial class Form2 : Form
    {
        public Form1 parent;
        public Form2(Form1 parent)
        {
            InitializeComponent();
            this.parent = parent;

            timeUpDown.Value = parent.settingsData.calibration_time;
            resetKeyBox.Text = parent.settingsData.reset_pos_key;
            pauseKeyBox.Text = parent.settingsData.pause_key;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void timeUpDown_ValueChanged(object sender, EventArgs e)
        {
            parent.settingsData.calibration_time = (int)timeUpDown.Value;
        }

        private void pauseKeyBox_TextChanged(object sender, EventArgs e)
        {
            parent.settingsData.pause_key = pauseKeyBox.Text;
        }

        private void resetKeyBox_TextChanged(object sender, EventArgs e)
        {
            parent.settingsData.reset_pos_key = resetKeyBox.Text;
        }
    }
}
