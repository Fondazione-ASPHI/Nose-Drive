using System.Diagnostics;
using System.Reflection.Emit;
using System.Text.Json;
using System.Windows.Forms;

namespace Nose_Drive_GUI
{
    public partial class Form1 : Form
    {
        //public static string defaultScriptName = "Drive.py";
        public string scriptPath = "";
        public string settingsPath = ".\\settings.json";
        public string logicPath = ".\\logic.json";
        public string customPath = ".\\custom.py";
        public string toBuildPath = ".\\to_build.py";
        public string targetEmbeddedLogic = "";
        public string currentPath;

        public SettingsData settingsData;
        public LogicData logicData;

        //public string settingsFile = "settings.json";
        //FileInfo settingsFileInfo;
        //string settingsFilePath;

        //public string logicFile = "logic.json";
        //FileInfo logicFileInfo;
        //string logicFilePath;

        Form2 frm2;

        Process startScript;
        Process startEmbedded;
        Process startBuild;
        Process getPip;
        Process pyInst;
        Process pyInst2;
        Process buildProcess;

        Dictionary<int, string> embeddedLogicsDictionary;
        Dictionary<int, Panel> panelsDictionary;


        public Form1()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedDialog;

            currentPath = Directory.GetCurrentDirectory();
            debugLabel.Text = currentPath; // A debug label
#if DEBUG
            debugLabel.Visible = true;
#endif

            // Initialize settings data
            //settingsFileInfo = new FileInfo(settingsFile);
            //settingsFilePath = settingsFileInfo.FullName;
            UpdateSettingsGUI(ReadSettingsFile(settingsPath));

            // Initialize logic data data
            //logicFileInfo = new FileInfo(logicFile);
            //logicFilePath = logicFileInfo.FullName;
            UpdateLogicGUI(ReadLogicFile(logicPath));
            
            removeScriptButton.Visible = false;


            // Define Processes
            getPip = new Process
            {
                StartInfo =
                  {
                      FileName = @".\python_310\python.exe",
                      Arguments = ".\\python_310\\get-pip.py"
                  }
            };

            pyInst = new Process
            {
                StartInfo =
                  {
                      FileName = @".\python_310\Scripts\pip.exe",
                      Arguments = "uninstall -y pyinstaller"
                  }
            };

            pyInst2 = new Process
            {
                StartInfo =
                  {
                      FileName = @".\python_310\Scripts\pip.exe",
                      Arguments = "install pyinstaller"
                  }
            };

            buildProcess = new Process
            {
                StartInfo =
                  {
                      FileName = @".\python_310\Scripts\pyinstaller.exe",
                      Arguments = "Builder.spec"
                  }
            };

            embeddedLogicsDictionary = new Dictionary<int, string>()
            {
                { 1, "Drive" },
                { 2, "3D_Movement" },
                { 3, "Platform" }
            };

            panelsDictionary = new Dictionary<int, Panel>()
            {
                { 1, drivePanel },
                { 2, move3dPanel },
                { 3, platformPanel }
            };


            // Must be last init stuff:
            presetBox.SelectedIndex = 1;
        }

        void UpdateSettings()
        {
            // Trackbars in main window
            settingsData.nose_horizontal_sensibility = noseHorBar.Value * 10;
            settingsData.nose_vertical_sensibility = noseVerBar.Value * 10;
            settingsData.mouth_horizontal_sensibility = mouthBar.Value * 15;
            settingsData.eyebrows_sensibility = eyebrowsBar.Value * 40;
        }

        void UpdateSettingsGUI(SettingsData settingsData)
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

       
        void UpdateLogicGUI(LogicData logicData)
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
            File.WriteAllText(settingsPath, jsonString);
        }

        private void SaveLogicFile()
        {
            UpdateLogic();
            string jsonString = JsonSerializer.Serialize(logicData);
            File.WriteAllText(logicPath, jsonString);
        }

        private void loadScript_Click(object sender, EventArgs e)
        {
            openPythonFiles.ShowDialog();
            scriptPath = openPythonFiles.FileName;
            logicBox.Visible = (scriptPath == "");
            removeScriptButton.Visible = (scriptPath != "");
            if (scriptPath != "")
            {
                buildCheck.Visible = true;
                presetBox.SelectedIndex = 0;
            }

            debugLabel.Text = openPythonFiles.FileName;
        }

        // Save .nose file
        private void savePreset_Click(object sender, EventArgs e)
        {
            SaveLogicFile();
        }

        // Load .nose file
        private void loadPreset_Click(object sender, EventArgs e)
        {
            openJSONFiles.ShowDialog();
            //logicPath = openJSONFiles.FileName;
            if (openJSONFiles.FileName != null)
            {
                File.Copy(openJSONFiles.FileName, logicPath, true);
                UpdateLogicGUI(ReadLogicFile(logicPath));

                debugLabel.Text = openJSONFiles.FileName;
            }
        }

        private void saveSettings_Click(object sender, EventArgs e)
        {
            SaveSettingsFile();
        }

        private void loadSettings_Click(object sender, EventArgs e)
        {
            openJSONFiles.ShowDialog();
            //settingsPath = openJSONFiles.FileName;
            if (openJSONFiles.FileName != null)
            {
                File.Copy(openJSONFiles.FileName, settingsPath, true);
                UpdateSettingsGUI(ReadSettingsFile(settingsPath));

                debugLabel.Text = openJSONFiles.FileName;
            }            
        }

        private void startButton_Click(object sender, EventArgs e)
        {


            UpdateSettings();
            SaveSettingsFile();
            UpdateLogic();
            SaveLogicFile();


            // START BUILD
            if (buildCheck.Checked)
            {
                string buildDir = @".\dist\custom";
                if (scriptPath != "")
                {
                    File.Copy(scriptPath, toBuildPath, true);
                    string buildName = new FileInfo(scriptPath).Name.Split('.')[0];
                    buildDir = @".\dist\" + buildName;
                    debugLabel.Text = buildName;
                    
                    if (Directory.Exists(buildDir) && forceCompileCheck.Checked)
                    {
                        Directory.Delete(buildDir, true);
                    }
                }
                else
                {
                    File.Copy(customPath, toBuildPath, true);
                    Directory.Delete(buildDir, true);
                }

                if (!Directory.Exists(buildDir))
                {
                    getPip.Start();
                    getPip.WaitForExit();
                    pyInst.Start();
                    pyInst.WaitForExit();
                    pyInst2.Start();
                    pyInst2.WaitForExit();
                    buildProcess.Start();
                    buildProcess.WaitForExit();
                    Directory.Move(@".\dist\main", buildDir);
                }                

                startBuild = new Process
                {
                    StartInfo =
                  {
                      FileName = buildDir + @"\main.exe",
                      Arguments = settingsPath
                  }
                };
                startBuild.Start();
                startBuild.WaitForExit();
            }
            // START SCRIPT
            else
            {
                // Embedded pre-built default logics
                if (presetBox.SelectedIndex != 0)
                {
                    startEmbedded = new Process
                    {
                        StartInfo =
                          {
                              FileName = @".\dist\Embedded_Logics\main.exe",
                              Arguments = settingsPath + " " + targetEmbeddedLogic
                          }
                    };
                    startEmbedded.Start();
                    startEmbedded.WaitForExit();
                }
                // External script or custom-preset script with GUI customized json
                else
                {
                    if (scriptPath == "")
                        scriptPath = customPath;


                    debugLabel.Text = "command: " + scriptPath + " " + settingsPath;

                    startScript = new Process
                    {
                        StartInfo =
                          {
                              FileName = @".\python_310\python.exe",
                              Arguments = scriptPath + " " + settingsPath
                          }
                    };
                    startScript.Start();
                    startScript.WaitForExit();
                }                
            }
        }

        private void removeScript_Click(object sender, EventArgs e)
        {
            scriptPath = "";
            removeScriptButton.Visible = false;
            logicBox.Visible = true;
        }

        private void optionsForm_Click(object sender, EventArgs e)
        {
            frm2 = new Form2(this);
            frm2.ShowDialog();
        }

        private void build_Checked(object sender, EventArgs e)
        {
            forceCompileCheck.Visible = buildCheck.Checked;
            if (!buildCheck.Checked) { forceCompileCheck.Checked = false; }
        }

        private void presetBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Manage instructions for embedded logics
            foreach (Panel p in panelsDictionary.Values) { p.Visible = false; }
            if (panelsDictionary.ContainsKey(presetBox.SelectedIndex))
                panelsDictionary[presetBox.SelectedIndex].Visible = true;

            // Manage stuff when changing preset
            if (presetBox.SelectedIndex != 0)
            {
                buildCheck.Checked = false;
                buildCheck.Visible = false;
                targetEmbeddedLogic = embeddedLogicsDictionary[presetBox.SelectedIndex];                
                //UpdateLogicGUI(ReadLogicFile(@"default_logics/" + targetEmbeddedLogic + @".json"));
                
                debugLabel.Text = targetEmbeddedLogic;
            }
            else
            {
                buildCheck.Visible = true;
            }
        }

        private void logoImage_Click(object sender, EventArgs e)
        {
            using (Process p = new Process())
            {
                p.StartInfo.FileName = "https://asphi.it/";
                p.StartInfo.UseShellExecute = true;
                p.Start();
            }
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

        private void options_Click(object sender, EventArgs e)
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
        public string pause { get; set; }
        public string reset_pos { get; set; }
        public int calibration_time { get; set; }
        public int camera { get; set; }
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