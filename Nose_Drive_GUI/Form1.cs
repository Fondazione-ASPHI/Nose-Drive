using Emgu.CV;
using System;
using System.Diagnostics;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
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

        public SettingsData settingsData = new SettingsData();
        public LogicData logicData = new LogicData();

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
        public Process updateLibrary;
        Process buildProcess;
        Process keypressProcess;

        Process activeProcess; //Pointer to currently active process
        int activeProcessID;

        Dictionary<int, string> embeddedLogicsDictionary;
        Dictionary<int, string> panelsDictionary;


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
            settingsData = ReadSettingsFile(settingsPath);
            UpdateSettingsGUI(settingsData);

            // Initialize logic data data
            //logicFileInfo = new FileInfo(logicFile);
            //logicFilePath = logicFileInfo.FullName;
            logicData = ReadLogicFile(logicPath);
            UpdateLogicGUI(logicData);

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

            updateLibrary = new Process
            {
                StartInfo =
                  {
                      FileName = @".\python_310\Scripts\pip.exe",
                      Arguments = "install --upgrade nosedrive"
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

            panelsDictionary = new Dictionary<int, string>()
            {
                { 1, "This logic is meant for driving games,\r\nusing the Left Joystick to steer and the Right\r\nand Left Triggers to accelerate and brake.\r\n\r\nNOSE DOWN: Right-Trigger (accelerator)\r\nNOSE UP: Left-Trigger (brake)\r\nNOSE RIGHT and LEFT: steer left and right\r\n" },
                { 2, "This logic is meant for controlling a character\r\nthat moves in a 3D environment.\r\nWith the up and down movement of the nose\r\nthe character will run, while moving the nose\r\nhorizontally, the game camera will slide.\r\n\r\nBy pressing the \"8\" numeric keyboard key\r\nit is possible to switch to \"Aim\" mode, where\r\nboth horizontal and vertical movement of the\r\nhead will control the Right Joystick, to move the\r\ncamera.\r\nPressing the \"9\" key will revert to \"Move\" mode.\r\n" },
                { 3, "This logic is meant for platform games.\r\nControl the left analog with the nose\r\nwhile press some buttons with eyebrows\r\nand mouth left or right.\r\n" }
            };


            // Must be last init stuff:
            presetBox.SelectedIndex = 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
            DialogResult result = openPythonFiles.ShowDialog();
            if (result == DialogResult.OK)
            {
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
        }

        // Save .nose file
        private void savePreset_Click(object sender, EventArgs e)
        {
            DialogResult result = saveJSONFiles.ShowDialog();
            if (result == DialogResult.OK)
            {
                UpdateLogic();
                string jsonString = JsonSerializer.Serialize(logicData);
                File.WriteAllText(saveJSONFiles.FileName, jsonString);
            }
        }

        private void saveSensibilityValues(object sender, EventArgs e)
        {
            DialogResult result = saveJSONFiles.ShowDialog();
            if (result == DialogResult.OK)
            {
                UpdateSettings();
                string jsonString = JsonSerializer.Serialize(settingsData);
                File.WriteAllText(saveJSONFiles.FileName, jsonString);
            }
        }

        // Load .nose file
        private void loadPreset_Click(object sender, EventArgs e)
        {
            DialogResult result = openJSONFiles.ShowDialog();
            if (result == DialogResult.OK)
            {
                presetBox.SelectedIndex = 0;

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
            DialogResult result = openJSONFiles.ShowDialog();
            if (result == DialogResult.OK)
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
                string args = settingsPath;
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
                    if (Directory.Exists(buildDir)) { Directory.Delete(buildDir, true); }
                    args += " " + logicPath;
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
                      Arguments = args,
                      UseShellExecute = false,
                      RedirectStandardError = true,
                      CreateNoWindow = true
                  }
                };
                StartProcess(startBuild);
            }
            // START SCRIPT or PRESET
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
                              Arguments = settingsPath + " " + targetEmbeddedLogic,
                              UseShellExecute = false,
                              RedirectStandardError = true,
                              CreateNoWindow = true
                          }
                    };
                    StartProcess(startEmbedded);
                }
                // External script or custom-preset script with GUI customized json
                else
                {
                    string args = scriptPath + " " + settingsPath;
                    if (scriptPath == "") // case custom preset
                        args = customPath + " " + settingsPath + " " + logicPath;
                    debugLabel.Text = "args: " + args;

                    startScript = new Process
                    {
                        StartInfo =
                          {
                              FileName = @".\python_310\python.exe",
                              Arguments = args,
                              UseShellExecute = false,
                              RedirectStandardError = true,
                              CreateNoWindow = true
                          }
                    };
                    StartProcess(startScript);
                }
            }
        }

        private void StartProcess(Process process)
        {
            Start.Visible = false;
            Stop.Visible = true;

            // Check enable Pause
            if (settingsData.pause == "" || settingsData.pause == null)
            {
                Pause.Visible = false;
                pauseLabel.Visible = true;
            }
            else
            {
                Pause.Visible = true;
                pauseLabel.Visible = false;
            }
            Pause.Enabled = false;

            activeProcess = process;
            debugLabel.Text = "Background process started";
            backgroundWorker1.RunWorkerAsync(argument: process);
        }


        private void StopProcess()
        {
            activeProcess.Kill();
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
            // Manage stuff when changing preset
            if (presetBox.SelectedIndex != 0)
            {
                buildCheck.Checked = false;
                buildCheck.Visible = false;
                targetEmbeddedLogic = embeddedLogicsDictionary[presetBox.SelectedIndex];
                //UpdateLogicGUI(ReadLogicFile(@"default_logics/" + targetEmbeddedLogic + @".json"));
                descriptionPanel.Visible = true;
                descriptionLabel.Text = panelsDictionary[presetBox.SelectedIndex];
                savePresetMenuBtn.Enabled = false;
                //loadPresetMenuBtn.Enabled = false;

                debugLabel.Text = targetEmbeddedLogic;
            }
            else
            {
                buildCheck.Visible = true;
                descriptionPanel.Visible = false;
                savePresetMenuBtn.Enabled = true;
                //loadPresetMenuBtn.Enabled = true;
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

        private void Stop_Click(object sender, EventArgs e)
        {
            StopProcess();
        }

        private void Pause_Click(object sender, EventArgs e)
        {
            Pause.Enabled = false;
            keypressProcess = new Process
            {
                StartInfo =
                  {
                      FileName = @".\python_310\python.exe",
                      Arguments = "utils.py keypress " + settingsData.pause.ToLower(),
                      UseShellExecute = false,
                      CreateNoWindow = true
                  }
            };
            keypressProcess.Start();
            keypressProcess.WaitForExit();
            Pause.Enabled = true;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (activeProcess != null)
            {
                StopProcess();
            }
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            Process process = e.Argument as Process;
            process.Start();
            activeProcessID = process.Id;
            while (!process.StandardError.EndOfStream)
            {
                string line = process.StandardError.ReadLine();
                Debug.WriteLine(line);
                if (line == "Paused: True")
                {
                    Pause.Invoke((MethodInvoker)delegate
                    {
                        debugLabel.Text = "Paused: True";
                        Pause.Text = "RESUME";
                    });
                }
                else if (line == "Paused: False")
                {
                    Pause.Invoke((MethodInvoker)delegate
                    {
                        debugLabel.Text = "Paused: False";
                        Pause.Text = "PAUSE";
                    });
                }
                else if (line == "Now Tracking.")
                {
                    Pause.Invoke((MethodInvoker)delegate
                    {
                        debugLabel.Text = "Now Tracking.";
                        Pause.Enabled = true;
                    });
                }

            }
            process.WaitForExit();
        }

        private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                debugLabel.Text = "Process was cancelled";
            }
            else if (e.Error != null)
            {
                debugLabel.Text = "There was an error running the process. The thread aborted";
            }
            else
            {
                debugLabel.Text = "Process was completed";
            }

            debugLabel.Text = "Background process ended";
            Start.Visible = true;
            Stop.Visible = false;
            Pause.Visible = false;
            pauseLabel.Visible = false;
            Pause.Text = "PAUSE";
        }

        private void Pause_EnabledChanged(object sender, EventArgs e)
        {
            if (Pause.Enabled)
            {
                Pause.BackColor = Color.FromArgb(3, 160, 139);
                Pause.ForeColor = Color.White;
            }
            else
            {
                Pause.BackColor = Color.DarkGray;
                Pause.ForeColor = Color.WhiteSmoke;
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