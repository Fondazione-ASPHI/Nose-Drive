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

            options = new Options();
            //options = JsonSerializer.Deserialize<Options>(fileName);
        }

        void WriteValue()
        {
            button1.Enabled = true;
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

        private void button1_Click(object sender, EventArgs e)
        {
            string jsonString = JsonSerializer.Serialize(options);
            File.WriteAllText(fileName, jsonString);

            button1.Enabled = false;
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