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

            // Initialize settings data
            settingsData = ReadSettingsFile(settingsFile);
            settingsFileInfo = new FileInfo(settingsFile);
            settingsFilePath = settingsFileInfo.FullName;
            UpdateSettingsGUI();

            // Initialize logic data data
            logicData = ReadLogicFile(logicFile);
            logicFileInfo = new FileInfo(logicFile);
            logicFilePath = logicFileInfo.FullName;
            UpdateLogicGUI();

            presetBox.SelectedIndex = 0;
        }

        void UpdateSettings()
        {
            // Trackbars in main window
            settingsData.nose_horizontal_sensibility = noseHorBar.Value * 10;
            settingsData.nose_vertical_sensibility = noseVerBar.Value * 10;
            settingsData.mouth_horizontal_sensibility = mouthBar.Value * 15;
            settingsData.eyebrows_sensibility = eyebrowsBar.Value * 40;

            // Options in Form2
            //options.CalibrationTime = (float)frm2.num.Value;
        }

        void UpdateSettingsGUI()
        {
            if (settingsData != null)
            {
                noseHorBar.Value = (int)(settingsData.nose_horizontal_sensibility / 10);
                noseVerBar.Value = (int)(settingsData.nose_vertical_sensibility / 10);
                mouthBar.Value = (int)(settingsData.mouth_horizontal_sensibility / 15);
                eyebrowsBar.Value = (int)(settingsData.eyebrows_sensibility / 40);
            }
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

        void UpdateLogicGUI()
        {
            if (logicData != null)
            {
                noseRightDropdown.Text = logicData.nose_right;
                noseLeftDropdown.Text = logicData.nose_left;
                noseUpDropdown.Text = logicData.nose_up;
                noseDownDropdown.Text = logicData.nose_down;
                eyebrowsDropdown.Text = logicData.eyebrows;
                mouthRightDropdown.Text = logicData.mouth_right;
                mouthLeftDropdown.Text = logicData.mouth_left;
            }
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
            UpdateLogic();
            string jsonString = JsonSerializer.Serialize(logicData);
            File.WriteAllText(logicFile, jsonString);
        }

        private void load_script(object sender, EventArgs e)
        {
            openPythonFiles.ShowDialog();
            scriptPath = openPythonFiles.FileName;
            label1.Text = openPythonFiles.FileName;
        }

        // Save .nose file
        private void save_preset(object sender, EventArgs e)
        {
            SaveLogicFile();
        }

        // Load .nose file
        private void load_preset(object sender, EventArgs e)
        {
            openJSONFiles.ShowDialog();
            logicFilePath = openJSONFiles.FileName;
            label1.Text = openJSONFiles.FileName;
        }

        private void save_settings(object sender, EventArgs e)
        {
            SaveSettingsFile();
        }

        private void load_settings(object sender, EventArgs e)
        {
            openJSONFiles.ShowDialog();
            settingsPath = openJSONFiles.FileName;
            label1.Text = openJSONFiles.FileName;
        }

        private void start_button(object sender, EventArgs e)
        {
            label1.Text = scriptPath + " " + settingsPath;

            var mainProcess = new Process
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


            // Manage building
            if (buildCheck.Checked)
            {
                Process getPip = new Process
                {
                    StartInfo =
                  {
                      FileName = @".\python_310\python.exe",
                      Arguments = ".\\python_310\\get-pip.py"
                  }
                };
                getPip.Start();
                getPip.WaitForExit();

                Process pyInst = new Process
                {
                    StartInfo =
                  {
                      FileName = @".\python_310\Scripts\pip.exe",
                      Arguments = "uninstall -y pyinstaller"
                  }
                };
                pyInst.Start();
                pyInst.WaitForExit();

                Process pyInst2 = new Process
                {
                    StartInfo =
                  {
                      FileName = @".\python_310\Scripts\pip.exe",
                      Arguments = "install pyinstaller"
                  }
                };
                pyInst2.Start();
                pyInst2.WaitForExit();

                Process buildProcess = new Process
                {
                    StartInfo =
                  {
                      FileName = @".\python_310\Scripts\pyinstaller.exe",
                      Arguments = "Builder.spec"
                  }
                };
                buildProcess.Start();
                buildProcess.WaitForExit();
            }



            mainProcess.Start();
            mainProcess.WaitForExit();
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
            forceCompileCheck.Visible = buildCheck.Checked;
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (Process p = new Process())
            {
                p.StartInfo.FileName = "https://asphi.it/";
                p.StartInfo.UseShellExecute = true;
                p.Start();
            }
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