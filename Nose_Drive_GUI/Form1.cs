using System.Diagnostics;
using System.Reflection.Emit;
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

        public SettingsData settingsData;
        public LogicData logicData;

        public string settingsFile = "settings.json";
        FileInfo settingsFileInfo;
        string settingsFilePath;

        public string logicFile = "logic.json";
        FileInfo logicFileInfo;
        string logicFilePath;

        Form2 frm2;


        public Form1()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;

            currentPath = Directory.GetCurrentDirectory();
            label1.Text = currentPath; // A debug label
#if DEBUG
            label1.Visible = true;
#endif

            // Creating object for file picking .py
            openFileDialog1 = new OpenFileDialog()
            {
                Filter = "Python files (*.py)|*.py",
                Title = "Open Python script",
                InitialDirectory = currentPath
            };
            // Creating object for file picking .json
            openFileDialog2 = new OpenFileDialog()
            {
                Filter = "Json files (*.json)|*.json",
                Title = "Open JSON file",
                InitialDirectory = currentPath
            };

            // Initialize settings data
            settingsData = ReadSettingsFile(settingsFile);
            settingsFileInfo = new FileInfo(settingsFile);
            settingsFilePath = settingsFileInfo.FullName;

            // Initialize logic data data
            logicData = ReadLogicFile(logicFile);
            logicFileInfo = new FileInfo(logicFile);
            logicFilePath = logicFileInfo.FullName;
        }

        void UpdateSettings()
        {
            // Trackbars in main window
            settingsData.nose_horizontal_sensibility = trackBar1.Value;
            settingsData.nose_vertical_sensibility = trackBar4.Value;
            settingsData.mouth_horizontal_sensibility = trackBar2.Value;
            settingsData.eyebrows_sensibility = trackBar6.Value;

            // Options in Form2
            //options.CalibrationTime = (float)frm2.num.Value;
        }

        void UpdateLogic()
        {
            logicData.nose_right = noseRightDropdown.Text;
            logicData.nose_left = noseLeftDropdown.Text;
            logicData.nose_up = noseUpDropdown.Text;
            logicData.nose_down = noseDownDropdown.Text;
            logicData.eyebrows = eyebrowsDropdown.Text;
            logicData.mouth_right = mouthRightDropdown.Text;
            logicData.mouth_left = mouthLeftDropdown.Text;
        }

        SettingsData ReadSettingsFile(string fileName)
        {
            string jsonString = File.ReadAllText(fileName);
            return JsonSerializer.Deserialize<SettingsData>(jsonString);
        }

        LogicData ReadLogicFile(string fileName)
        {
            string jsonString = File.ReadAllText(fileName);
            return JsonSerializer.Deserialize<LogicData>(jsonString);
        }

        //private void SaveFile<DataType>(string fileName, JsonData jsonData) where DataType : JsonData
        //{
        //    UpdateSettings();
        //    string jsonString = JsonSerializer.Serialize<DataType>(jsonData);
        //    File.WriteAllText(fileName, jsonString);
        //}

        private void SaveSettingsFile()
        {
            UpdateSettings();
            string jsonString = JsonSerializer.Serialize(settingsData);
            File.WriteAllText(settingsFile, jsonString);
        }

        private void SaveLogicFile()
        {
            UpdateSettings();
            string jsonString = JsonSerializer.Serialize(logicData);
            File.WriteAllText(logicFile, jsonString);
        }

        private void load_script(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            scriptPath = openFileDialog1.FileName;
            label1.Text = openFileDialog1.FileName;
        }

        // Save .nose file
        private void save_preset(object sender, EventArgs e)
        {

        }

        // Load .nose file
        private void load_preset(object sender, EventArgs e)
        {

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

            UpdateSettings();
            SaveSettingsFile();
            UpdateLogic();
            SaveLogicFile();

            //process.Start();
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

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }        
    }

    public abstract class JsonData
    {

    }

    [System.Serializable]
    public class SettingsData : JsonData
    {
        public float nose_horizontal_sensibility { get; set; }
        public float nose_vertical_sensibility { get; set; }
        public float mouth_horizontal_sensibility { get; set; }
        public float eyebrows_sensibility { get; set; }
        public string pause_key { get; set; }
        public string reset_pos_key { get; set; }
        public int calibration_time { get; set; }
    }

    [System.Serializable]
    public class LogicData : JsonData
    {
        public string nose_right { get; set; }
        public string nose_left { get; set; }
        public string nose_up { get; set; }
        public string nose_down { get; set; }
        public string eyebrows { get; set; }
        public string mouth_right { get; set; }
        public string mouth_left { get; set; }
    }
}