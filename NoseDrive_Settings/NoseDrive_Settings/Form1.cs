namespace NoseDrive_Settings
{
    using System.Text.Json;

    public partial class Form1 : Form
    {
        public Options options;
        public string fileName = "options.json";

        public Form1()
        {
            InitializeComponent();

            options = ReadOptions();            
        }

        Options ReadOptions()
        {
            string jsonString = File.ReadAllText(fileName);
            return JsonSerializer.Deserialize<Options>(jsonString);
        }

        void UpdateOptions()
        {
            options.nose_horizontal_sensibility = trackBar1.Value;
            options.nose_vertical_sensibility = trackBar4.Value;
            options.mouth_horizontal_sensibility = trackBar2.Value;
            options.mouth_vertical_sensibility = trackBar3.Value;
            options.head_tilt_sensibility = trackBar5.Value;
            options.mouth_open_threshold = trackBar7.Value;
            options.eyebrows_threshold = trackBar6.Value;
            options.calibration_time = (float)numericUpDown1.Value;
        }

        void ValueChanged()
        {
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateOptions();
            string jsonString = JsonSerializer.Serialize(options);
            File.WriteAllText(fileName, jsonString);

            button1.Enabled = false;
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            ValueChanged();
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            ValueChanged();
        }

        private void trackBar5_Scroll(object sender, EventArgs e)
        {
            ValueChanged();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            ValueChanged();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            ValueChanged();
        }

        private void trackBar7_Scroll(object sender, EventArgs e)
        {
            ValueChanged();
        }

        private void trackBar6_Scroll(object sender, EventArgs e)
        {
            ValueChanged();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            ValueChanged();
        }
    }


    [System.Serializable]
    public class Options
    {
        public float nose_horizontal_sensibility { get; set; }
        public float nose_vertical_sensibility { get; set; }
        public float mouth_horizontal_sensibility { get; set; }
        public float mouth_vertical_sensibility { get; set; }
        public float head_tilt_sensibility { get; set; }
        public float eyebrows_threshold { get; set; }
        public float mouth_open_threshold { get; set; }
        public float calibration_time { get; set; }
    }
}