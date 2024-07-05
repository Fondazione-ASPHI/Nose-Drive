using System.Diagnostics;
using System.Text.Json;
using System.Windows.Forms;

namespace Nose_Drive_GUI
{
    public partial class Form1 : Form
    {
        //public static string defaultScriptName = "Drive.py";
        public string scriptPath;
        public string settingsPath;
        public string currentPath;

        OpenFileDialog openFileDialog1;
        OpenFileDialog openFileDialog2;

        public Settings options;
        public Logic logic;
        public string settingsFile = "settings.json";
        public string logicFile = "logic.json";

        Form2 frm2;


        public Form1()
        {
            InitializeComponent();

            currentPath = Directory.GetCurrentDirectory();
            label1.Text = currentPath;

            openFileDialog1 = new OpenFileDialog()
            {
                Filter = "Python files (*.py)|*.py",
                Title = "Open Python script",
                InitialDirectory = currentPath
            };

            openFileDialog2 = new OpenFileDialog()
            {
                Filter = "Json files (*.json)|*.json",
                Title = "Open JSON file",
                InitialDirectory = currentPath
            };


            options = ReadSettingsFile("settings.json");
            logic = ReadLogicFile("logic.json");
        }

        void UpdateSettings()
        {
            options.NoseHorizontalHensibility = trackBar1.Value;
            options.NoseVerticalSensibility = trackBar4.Value;
            options.MouthHorizontalSensibility = trackBar2.Value;
            options.EyebrowsSensibility = trackBar6.Value;
            //options.CalibrationTime = (float)frm2.num.Value;
        }

        Settings ReadSettingsFile(string fileName)
        {
            string jsonString = File.ReadAllText(fileName);
            return JsonSerializer.Deserialize<Settings>(jsonString);
        }

        Logic ReadLogicFile(string fileName)
        {
            string jsonString = File.ReadAllText(fileName);
            return JsonSerializer.Deserialize<Logic>(jsonString);
        }

        private void SaveFile(string fileName)
        {
            UpdateSettings();
            string jsonString = JsonSerializer.Serialize(options);
            File.WriteAllText(fileName, jsonString);
        }

        private void select_script(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            scriptPath = openFileDialog1.FileName;
            label1.Text = openFileDialog1.FileName;
        }

        private void settings(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
            settingsPath = openFileDialog2.FileName;
            label1.Text = openFileDialog2.FileName;
        }

        private void start_button(object sender, EventArgs e)
        {
            label1.Text = scriptPath + " " + settingsPath;

            var process = new Process
            {
                StartInfo =
              {
                  FileName = @".\python_310\python.exe",
                  Arguments = scriptPath + " " + settingsPath
              }
            };
            process.Start();
        }

        private void remove_script(object sender, EventArgs e)
        {

        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm2 = new Form2();
            frm2.ShowDialog();
        }

        private void build_Checked(object sender, EventArgs e)
        {
            checkBox2.Visible = checkBox1.Checked;
        }

        private void logictab_selecting(object sender, TabControlCancelEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }        

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }


    [System.Serializable]
    public class Settings
    {
        public float NoseHorizontalHensibility { get; set; }
        public float NoseVerticalSensibility { get; set; }
        public float MouthHorizontalSensibility { get; set; }
        public float EyebrowsSensibility { get; set; }
        public string PauseKey { get; set; }
        public string ResetPosKey { get; set; }
        public int CalibrationTime { get; set; }
    }

    [System.Serializable]
    public class Logic
    {
        public string NoseRight { get; set; }
        public string NoseLeft { get; set; }
        public string NoseUp { get; set; }
        public string NoseDown { get; set; }
        public string Eyebrows { get; set; }
        public string MouthRight { get; set; }
        public string MouthLeft { get; set; }
    }
}