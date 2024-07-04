using System.Diagnostics;

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

        int lockedPage = 0;


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
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
        }

        private void logictab_selecting(object sender, TabControlCancelEventArgs e)
        {
            if (lockedPage >= 0 && e.TabPageIndex != lockedPage) e.Cancel = true;

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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Visible = checkBox1.Checked;
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
}