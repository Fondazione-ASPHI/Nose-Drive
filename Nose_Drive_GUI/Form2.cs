using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;


namespace Nose_Drive_GUI
{
    public partial class Form2 : Form
    {
        public Form1 parent;

        private VideoCapture capture;


        public Form2(Form1 parent)
        {
            InitializeComponent();
            this.parent = parent;

            timeUpDown.Value = parent.settingsData.calibration_time;
            resetKeyBox.Text = parent.settingsData.reset_pos;
            pauseKeyBox.Text = parent.settingsData.pause;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            capture = new VideoCapture((int)cameraIndex.Value, VideoCapture.API.DShow);
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
            parent.settingsData.pause = pauseKeyBox.Text;
        }

        private void resetKeyBox_TextChanged(object sender, EventArgs e)
        {
            parent.settingsData.reset_pos = resetKeyBox.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void preview_Click(object sender, EventArgs e)
        {
            Mat matImage = capture.QueryFrame();
            pictureBox1.Image = matImage.ToBitmap();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            capture.Dispose();
        }

        private void cameraIndex_ValueChanged(object sender, EventArgs e)
        {
            capture.Dispose();
            capture = new VideoCapture((int)cameraIndex.Value, VideoCapture.API.DShow);
        }
    }
}
