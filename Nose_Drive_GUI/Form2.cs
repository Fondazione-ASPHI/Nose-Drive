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
using DirectShowLib;
using System.Xml.Linq;


namespace Nose_Drive_GUI
{
    public partial class Form2 : Form
    {
        public Form1 parent;

        private VideoCapture capture;
        Mat matImage;

        private DsDevice[] directShowCameras;

        public Form2(Form1 parent)
        {
            InitializeComponent();
            this.parent = parent;

            FormBorderStyle = FormBorderStyle.FixedDialog;

            timeUpDown.Value = parent.settingsData.calibration_time;
            resetKeyBox.Text = parent.settingsData.reset_pos;
            pauseKeyBox.Text = parent.settingsData.pause;
        }

        private void InitCamera()
        {
            capture = new VideoCapture((int)camerasBox.SelectedIndex, VideoCapture.API.DShow);
            cameraNameLabel.Text = capture.CaptureSource.ToString();
            capture.ImageGrabbed += Capture_ImageGrabbed;
            capture.Start();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            directShowCameras = DsDevice.GetDevicesOfCat(FilterCategory.VideoInputDevice);
            for (int i = 0; i < directShowCameras.Count(); i++)
            {
                camerasBox.Items.Add(directShowCameras[i].Name);
            }

            camerasBox.SelectedIndex = parent.settingsData.camera;
        }

        private void Capture_ImageGrabbed(object? sender, EventArgs e)
        {
            if (capture != null)
            {
                matImage = capture.QueryFrame();
                pictureBox1.Image = matImage.ToBitmap();
            }
        }

        private void timeUpDown_ValueChanged(object sender, EventArgs e)
        {
            parent.settingsData.calibration_time = (int)timeUpDown.Value;
        }

        private void pauseKeyBox_TextChanged(object sender, EventArgs e)
        {
            string acceptedValues = "abcdefghijklmnopqrstuvwxyz123456789";
            if (acceptedValues.Contains(pauseKeyBox.Text) && pauseKeyBox.Text.Count() <= 1)
            {
                parent.settingsData.pause = pauseKeyBox.Text;
            }
            else
            {
                pauseKeyBox.Text = "";
            }
        }

        private void resetKeyBox_TextChanged(object sender, EventArgs e)
        {
            string acceptedValues = "abcdefghijklmnopqrstuvwxyz123456789";
            if (acceptedValues.Contains(resetKeyBox.Text) && resetKeyBox.Text.Count() <= 1)
            {
                parent.settingsData.reset_pos = resetKeyBox.Text;
            }
            else
            {
                resetKeyBox.Text = "";
            }
        }

        private void preview_Click(object sender, EventArgs e)
        {
            previewButton.Visible = false;
            Cursor.Current = Cursors.WaitCursor;
            InitCamera();
        }

        private void StopCamera()
        {
            if (capture != null)
            {
                Cursor.Current = Cursors.WaitCursor;
                capture.Stop();
                capture.Dispose();
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            StopCamera();
        }

        private void camerasBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (capture != null)
            {
                Cursor.Current = Cursors.WaitCursor;
                StopCamera();
                InitCamera();
            }

            parent.settingsData.camera = camerasBox.SelectedIndex;
        }

        private void cameraNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void updateLibButton_Click(object sender, EventArgs e)
        {
            parent.updateLibrary.Start();
            parent.updateLibrary.WaitForExit();
        }
    }
}
