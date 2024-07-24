namespace Nose_Drive_GUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Start = new Button();
            debugLabel = new Label();
            label11 = new Label();
            label6 = new Label();
            mouthLeftDropdown = new ComboBox();
            label7 = new Label();
            mouthRightDropdown = new ComboBox();
            eyebrowsDropdown = new ComboBox();
            label4 = new Label();
            noseDownDropdown = new ComboBox();
            label5 = new Label();
            noseUpDropdown = new ComboBox();
            label3 = new Label();
            noseLeftDropdown = new ComboBox();
            label2 = new Label();
            noseRightDropdown = new ComboBox();
            eyebrowsBar = new TrackBar();
            noseVerBar = new TrackBar();
            mouthBar = new TrackBar();
            noseHorBar = new TrackBar();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            buildCheck = new CheckBox();
            forceCompileCheck = new CheckBox();
            menuStrip1 = new MenuStrip();
            saveToolStripMenuItem = new ToolStripMenuItem();
            presetToolStripMenuItem1 = new ToolStripMenuItem();
            sensibilityValuesToolStripMenuItem = new ToolStripMenuItem();
            loadScriptToolStripMenuItem = new ToolStripMenuItem();
            presetToolStripMenuItem = new ToolStripMenuItem();
            sensibilityToolStripMenuItem = new ToolStripMenuItem();
            scriptToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            logicBox = new GroupBox();
            presetBox = new ComboBox();
            move3dPanel = new Panel();
            label1 = new Label();
            drivePanel = new Panel();
            driveLabel = new Label();
            platformPanel = new Panel();
            label8 = new Label();
            removeScriptButton = new Button();
            groupBox2 = new GroupBox();
            pictureBox1 = new PictureBox();
            openPythonFiles = new OpenFileDialog();
            openJSONFiles = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)eyebrowsBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)noseVerBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mouthBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)noseHorBar).BeginInit();
            menuStrip1.SuspendLayout();
            logicBox.SuspendLayout();
            move3dPanel.SuspendLayout();
            drivePanel.SuspendLayout();
            platformPanel.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Start
            // 
            Start.BackColor = Color.FromArgb(242, 101, 34);
            Start.Cursor = Cursors.Hand;
            Start.Font = new Font("Calibri", 38F, FontStyle.Bold, GraphicsUnit.Pixel);
            Start.ForeColor = Color.White;
            Start.Location = new Point(491, 742);
            Start.Margin = new Padding(4);
            Start.Name = "Start";
            Start.Size = new Size(214, 78);
            Start.TabIndex = 2;
            Start.Text = "START";
            Start.UseVisualStyleBackColor = false;
            Start.Click += startButton_Click;
            // 
            // debugLabel
            // 
            debugLabel.AutoSize = true;
            debugLabel.ForeColor = SystemColors.ButtonFace;
            debugLabel.Location = new Point(172, 49);
            debugLabel.Margin = new Padding(4, 0, 4, 0);
            debugLabel.Name = "debugLabel";
            debugLabel.Size = new Size(80, 22);
            debugLabel.TabIndex = 3;
            debugLabel.Text = "debug log";
            debugLabel.Visible = false;
            debugLabel.Click += label1_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Pixel);
            label11.ForeColor = Color.White;
            label11.Location = new Point(14, 370);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(107, 29);
            label11.TabIndex = 22;
            label11.Text = "Eyebrows";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Pixel);
            label6.ForeColor = Color.White;
            label6.Location = new Point(14, 476);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(119, 29);
            label6.TabIndex = 18;
            label6.Text = "Mouth left";
            // 
            // mouthLeftDropdown
            // 
            mouthLeftDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            mouthLeftDropdown.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Pixel);
            mouthLeftDropdown.FormattingEnabled = true;
            mouthLeftDropdown.Items.AddRange(new object[] { "", "Left Joystick Right", "Left Joystick Left", "Left Joystick Up", "Left Joystick Down", "Right Joystick Right", "Right Joystick Left", "Right Joystick Up", "Right Joystick Down", "A", "B", "X", "Y", "LT", "RT", "LB", "RB", "Start", "Select", "Dpad Right", "Dpad Left", "Dpad Up", "Dpad Down", "Right Thumb", "Left Thumb", "Home" });
            mouthLeftDropdown.Location = new Point(195, 476);
            mouthLeftDropdown.Margin = new Padding(2);
            mouthLeftDropdown.Name = "mouthLeftDropdown";
            mouthLeftDropdown.Size = new Size(160, 30);
            mouthLeftDropdown.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Pixel);
            label7.ForeColor = Color.White;
            label7.Location = new Point(14, 423);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(132, 29);
            label7.TabIndex = 16;
            label7.Text = "Mouth right";
            // 
            // mouthRightDropdown
            // 
            mouthRightDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            mouthRightDropdown.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Pixel);
            mouthRightDropdown.FormattingEnabled = true;
            mouthRightDropdown.Items.AddRange(new object[] { "", "Left Joystick Right", "Left Joystick Left", "Left Joystick Up", "Left Joystick Down", "Right Joystick Right", "Right Joystick Left", "Right Joystick Up", "Right Joystick Down", "A", "B", "X", "Y", "LT", "RT", "LB", "RB", "Start", "Select", "Dpad Right", "Dpad Left", "Dpad Up", "Dpad Down", "Right Thumb", "Left Thumb", "Home" });
            mouthRightDropdown.Location = new Point(195, 423);
            mouthRightDropdown.Margin = new Padding(2);
            mouthRightDropdown.Name = "mouthRightDropdown";
            mouthRightDropdown.Size = new Size(160, 30);
            mouthRightDropdown.TabIndex = 15;
            // 
            // eyebrowsDropdown
            // 
            eyebrowsDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            eyebrowsDropdown.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Pixel);
            eyebrowsDropdown.FormattingEnabled = true;
            eyebrowsDropdown.Items.AddRange(new object[] { "", "Left Joystick Right", "Left Joystick Left", "Left Joystick Up", "Left Joystick Down", "Right Joystick Right", "Right Joystick Left", "Right Joystick Up", "Right Joystick Down", "A", "B", "X", "Y", "LT", "RT", "LB", "RB", "Start", "Select", "Dpad Right", "Dpad Left", "Dpad Up", "Dpad Down", "Right Thumb", "Left Thumb", "Home" });
            eyebrowsDropdown.Location = new Point(195, 370);
            eyebrowsDropdown.Margin = new Padding(2);
            eyebrowsDropdown.Name = "eyebrowsDropdown";
            eyebrowsDropdown.Size = new Size(160, 30);
            eyebrowsDropdown.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Pixel);
            label4.ForeColor = Color.White;
            label4.Location = new Point(14, 318);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(124, 29);
            label4.TabIndex = 12;
            label4.Text = "Nose down";
            label4.Click += label4_Click;
            // 
            // noseDownDropdown
            // 
            noseDownDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            noseDownDropdown.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Pixel);
            noseDownDropdown.FormattingEnabled = true;
            noseDownDropdown.Items.AddRange(new object[] { "", "Left Joystick Right", "Left Joystick Left", "Left Joystick Up", "Left Joystick Down", "Right Joystick Right", "Right Joystick Left", "Right Joystick Up", "Right Joystick Down", "A", "B", "X", "Y", "LT", "RT", "LB", "RB", "Start", "Select", "Dpad Right", "Dpad Left", "Dpad Up", "Dpad Down", "Right Thumb", "Left Thumb", "Home" });
            noseDownDropdown.Location = new Point(195, 318);
            noseDownDropdown.Margin = new Padding(2);
            noseDownDropdown.Name = "noseDownDropdown";
            noseDownDropdown.Size = new Size(160, 30);
            noseDownDropdown.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Pixel);
            label5.ForeColor = Color.White;
            label5.Location = new Point(14, 265);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(94, 29);
            label5.TabIndex = 10;
            label5.Text = "Nose up";
            // 
            // noseUpDropdown
            // 
            noseUpDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            noseUpDropdown.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Pixel);
            noseUpDropdown.FormattingEnabled = true;
            noseUpDropdown.Items.AddRange(new object[] { "", "Left Joystick Right", "Left Joystick Left", "Left Joystick Up", "Left Joystick Down", "Right Joystick Right", "Right Joystick Left", "Right Joystick Up", "Right Joystick Down", "A", "B", "X", "Y", "LT", "RT", "LB", "RB", "Start", "Select", "Dpad Right", "Dpad Left", "Dpad Up", "Dpad Down", "Right Thumb", "Left Thumb", "Home" });
            noseUpDropdown.Location = new Point(195, 265);
            noseUpDropdown.Margin = new Padding(2);
            noseUpDropdown.Name = "noseUpDropdown";
            noseUpDropdown.Size = new Size(160, 30);
            noseUpDropdown.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Pixel);
            label3.ForeColor = Color.White;
            label3.Location = new Point(14, 212);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(101, 29);
            label3.TabIndex = 8;
            label3.Text = "Nose left";
            // 
            // noseLeftDropdown
            // 
            noseLeftDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            noseLeftDropdown.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Pixel);
            noseLeftDropdown.FormattingEnabled = true;
            noseLeftDropdown.Items.AddRange(new object[] { "", "Left Joystick Right", "Left Joystick Left", "Left Joystick Up", "Left Joystick Down", "Right Joystick Right", "Right Joystick Left", "Right Joystick Up", "Right Joystick Down", "A", "B", "X", "Y", "LT", "RT", "LB", "RB", "Start", "Select", "Dpad Right", "Dpad Left", "Dpad Up", "Dpad Down", "Right Thumb", "Left Thumb", "Home" });
            noseLeftDropdown.Location = new Point(195, 212);
            noseLeftDropdown.Margin = new Padding(2);
            noseLeftDropdown.Name = "noseLeftDropdown";
            noseLeftDropdown.Size = new Size(160, 30);
            noseLeftDropdown.TabIndex = 7;
            noseLeftDropdown.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Pixel);
            label2.ForeColor = Color.White;
            label2.Location = new Point(14, 159);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(114, 29);
            label2.TabIndex = 6;
            label2.Text = "Nose right";
            label2.Click += label2_Click;
            // 
            // noseRightDropdown
            // 
            noseRightDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            noseRightDropdown.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Pixel);
            noseRightDropdown.FormattingEnabled = true;
            noseRightDropdown.Items.AddRange(new object[] { "", "Left Joystick Right", "Left Joystick Left", "Left Joystick Up", "Left Joystick Down", "Right Joystick Right", "Right Joystick Left", "Right Joystick Up", "Right Joystick Down", "A", "B", "X", "Y", "LT", "RT", "LB", "RB", "Start", "Select", "Dpad Right", "Dpad Left", "Dpad Up", "Dpad Down", "Right Thumb", "Left Thumb", "Home" });
            noseRightDropdown.Location = new Point(195, 159);
            noseRightDropdown.Margin = new Padding(2);
            noseRightDropdown.Name = "noseRightDropdown";
            noseRightDropdown.Size = new Size(160, 30);
            noseRightDropdown.TabIndex = 5;
            noseRightDropdown.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // eyebrowsBar
            // 
            eyebrowsBar.LargeChange = 1;
            eyebrowsBar.Location = new Point(23, 340);
            eyebrowsBar.Margin = new Padding(2, 4, 2, 4);
            eyebrowsBar.Maximum = 5;
            eyebrowsBar.Name = "eyebrowsBar";
            eyebrowsBar.Size = new Size(193, 69);
            eyebrowsBar.TabIndex = 35;
            eyebrowsBar.Value = 3;
            // 
            // noseVerBar
            // 
            noseVerBar.LargeChange = 1;
            noseVerBar.Location = new Point(23, 221);
            noseVerBar.Margin = new Padding(2, 4, 2, 4);
            noseVerBar.Maximum = 5;
            noseVerBar.Name = "noseVerBar";
            noseVerBar.Size = new Size(193, 69);
            noseVerBar.TabIndex = 34;
            noseVerBar.Value = 3;
            // 
            // mouthBar
            // 
            mouthBar.LargeChange = 1;
            mouthBar.Location = new Point(23, 459);
            mouthBar.Margin = new Padding(2, 4, 2, 4);
            mouthBar.Maximum = 5;
            mouthBar.Name = "mouthBar";
            mouthBar.Size = new Size(193, 69);
            mouthBar.TabIndex = 33;
            mouthBar.Value = 3;
            // 
            // noseHorBar
            // 
            noseHorBar.LargeChange = 1;
            noseHorBar.Location = new Point(23, 102);
            noseHorBar.Margin = new Padding(2, 4, 2, 4);
            noseHorBar.Maximum = 5;
            noseHorBar.Name = "noseHorBar";
            noseHorBar.Size = new Size(193, 69);
            noseHorBar.TabIndex = 32;
            noseHorBar.Value = 3;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Pixel);
            label14.ForeColor = Color.White;
            label14.Location = new Point(23, 300);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(107, 29);
            label14.TabIndex = 31;
            label14.Text = "Eyebrows";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Pixel);
            label15.ForeColor = Color.White;
            label15.Location = new Point(23, 419);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(186, 29);
            label15.TabIndex = 30;
            label15.Text = "Mouth horizontal";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Pixel);
            label16.ForeColor = Color.White;
            label16.Location = new Point(23, 182);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(140, 29);
            label16.TabIndex = 29;
            label16.Text = "Nose vertical";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Pixel);
            label17.ForeColor = Color.White;
            label17.Location = new Point(23, 63);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(168, 29);
            label17.TabIndex = 28;
            label17.Text = "Nose horizontal";
            label17.Click += label17_Click;
            // 
            // buildCheck
            // 
            buildCheck.AutoSize = true;
            buildCheck.Font = new Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Pixel);
            buildCheck.ForeColor = Color.White;
            buildCheck.Location = new Point(722, 774);
            buildCheck.Margin = new Padding(2);
            buildCheck.Name = "buildCheck";
            buildCheck.Size = new Size(90, 33);
            buildCheck.TabIndex = 41;
            buildCheck.Text = "Build";
            buildCheck.UseVisualStyleBackColor = true;
            buildCheck.CheckedChanged += build_Checked;
            // 
            // forceCompileCheck
            // 
            forceCompileCheck.AutoSize = true;
            forceCompileCheck.Font = new Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Pixel);
            forceCompileCheck.ForeColor = Color.White;
            forceCompileCheck.Location = new Point(722, 809);
            forceCompileCheck.Margin = new Padding(2);
            forceCompileCheck.Name = "forceCompileCheck";
            forceCompileCheck.Size = new Size(204, 33);
            forceCompileCheck.TabIndex = 42;
            forceCompileCheck.Text = "Force re-compile";
            forceCompileCheck.UseVisualStyleBackColor = true;
            forceCompileCheck.Visible = false;
            forceCompileCheck.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { saveToolStripMenuItem, loadScriptToolStripMenuItem, settingsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(949, 37);
            menuStrip1.TabIndex = 43;
            menuStrip1.Text = "menuStrip1";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { presetToolStripMenuItem1, sensibilityValuesToolStripMenuItem });
            saveToolStripMenuItem.Font = new Font("Calibri", 12F);
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(75, 33);
            saveToolStripMenuItem.Text = "Save";
            // 
            // presetToolStripMenuItem1
            // 
            presetToolStripMenuItem1.Name = "presetToolStripMenuItem1";
            presetToolStripMenuItem1.Size = new Size(287, 38);
            presetToolStripMenuItem1.Text = "Preset";
            presetToolStripMenuItem1.Click += savePreset_Click;
            // 
            // sensibilityValuesToolStripMenuItem
            // 
            sensibilityValuesToolStripMenuItem.Name = "sensibilityValuesToolStripMenuItem";
            sensibilityValuesToolStripMenuItem.Size = new Size(287, 38);
            sensibilityValuesToolStripMenuItem.Text = "Sensibility Values";
            // 
            // loadScriptToolStripMenuItem
            // 
            loadScriptToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { presetToolStripMenuItem, sensibilityToolStripMenuItem, scriptToolStripMenuItem });
            loadScriptToolStripMenuItem.Font = new Font("Calibri", 12F);
            loadScriptToolStripMenuItem.Name = "loadScriptToolStripMenuItem";
            loadScriptToolStripMenuItem.Size = new Size(77, 33);
            loadScriptToolStripMenuItem.Text = "Load";
            // 
            // presetToolStripMenuItem
            // 
            presetToolStripMenuItem.Name = "presetToolStripMenuItem";
            presetToolStripMenuItem.Size = new Size(287, 38);
            presetToolStripMenuItem.Text = "Preset";
            presetToolStripMenuItem.Click += loadPreset_Click;
            // 
            // sensibilityToolStripMenuItem
            // 
            sensibilityToolStripMenuItem.Name = "sensibilityToolStripMenuItem";
            sensibilityToolStripMenuItem.Size = new Size(287, 38);
            sensibilityToolStripMenuItem.Text = "Sensibility Values";
            sensibilityToolStripMenuItem.Click += loadSettings_Click;
            // 
            // scriptToolStripMenuItem
            // 
            scriptToolStripMenuItem.Name = "scriptToolStripMenuItem";
            scriptToolStripMenuItem.Size = new Size(287, 38);
            scriptToolStripMenuItem.Text = "Script";
            scriptToolStripMenuItem.Click += loadScript_Click;
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Font = new Font("Calibri", 12F);
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(106, 33);
            settingsToolStripMenuItem.Text = "Options";
            settingsToolStripMenuItem.Click += optionsForm_Click;
            // 
            // logicBox
            // 
            logicBox.Controls.Add(move3dPanel);
            logicBox.Controls.Add(drivePanel);
            logicBox.Controls.Add(platformPanel);
            logicBox.Controls.Add(presetBox);
            logicBox.Controls.Add(label11);
            logicBox.Controls.Add(label2);
            logicBox.Controls.Add(label6);
            logicBox.Controls.Add(noseRightDropdown);
            logicBox.Controls.Add(mouthLeftDropdown);
            logicBox.Controls.Add(noseLeftDropdown);
            logicBox.Controls.Add(label7);
            logicBox.Controls.Add(label3);
            logicBox.Controls.Add(mouthRightDropdown);
            logicBox.Controls.Add(noseUpDropdown);
            logicBox.Controls.Add(eyebrowsDropdown);
            logicBox.Controls.Add(label5);
            logicBox.Controls.Add(label4);
            logicBox.Controls.Add(noseDownDropdown);
            logicBox.Font = new Font("Calibri", 32F, FontStyle.Bold, GraphicsUnit.Pixel);
            logicBox.ForeColor = Color.White;
            logicBox.Location = new Point(147, 154);
            logicBox.Margin = new Padding(4);
            logicBox.Name = "logicBox";
            logicBox.Padding = new Padding(4);
            logicBox.Size = new Size(387, 532);
            logicBox.TabIndex = 44;
            logicBox.TabStop = false;
            logicBox.Text = "LOGIC";
            // 
            // presetBox
            // 
            presetBox.BackColor = Color.FromArgb(44, 39, 53);
            presetBox.DropDownStyle = ComboBoxStyle.DropDownList;
            presetBox.Font = new Font("Calibri", 32F, FontStyle.Regular, GraphicsUnit.Pixel);
            presetBox.ForeColor = Color.White;
            presetBox.FormattingEnabled = true;
            presetBox.Items.AddRange(new object[] { "Custom preset", "Driving games", "3D Movement", "Platform" });
            presetBox.Location = new Point(111, 67);
            presetBox.Margin = new Padding(2);
            presetBox.Name = "presetBox";
            presetBox.Size = new Size(244, 47);
            presetBox.TabIndex = 23;
            presetBox.SelectedIndexChanged += presetBox_SelectedIndexChanged_1;
            // 
            // move3dPanel
            // 
            move3dPanel.Controls.Add(label1);
            move3dPanel.Location = new Point(7, 137);
            move3dPanel.Name = "move3dPanel";
            move3dPanel.Size = new Size(373, 388);
            move3dPanel.TabIndex = 49;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Pixel, 0);
            label1.Location = new Point(20, 22);
            label1.Name = "label1";
            label1.Size = new Size(341, 110);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            // 
            // drivePanel
            // 
            drivePanel.Controls.Add(driveLabel);
            drivePanel.Location = new Point(7, 137);
            drivePanel.Name = "drivePanel";
            drivePanel.Size = new Size(373, 388);
            drivePanel.TabIndex = 48;
            // 
            // driveLabel
            // 
            driveLabel.AutoSize = true;
            driveLabel.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Pixel, 0);
            driveLabel.Location = new Point(20, 22);
            driveLabel.Name = "driveLabel";
            driveLabel.Size = new Size(329, 154);
            driveLabel.TabIndex = 0;
            driveLabel.Text = resources.GetString("driveLabel.Text");
            // 
            // platformPanel
            // 
            platformPanel.Controls.Add(label8);
            platformPanel.Location = new Point(7, 137);
            platformPanel.Name = "platformPanel";
            platformPanel.Size = new Size(373, 388);
            platformPanel.TabIndex = 49;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Pixel, 0);
            label8.Location = new Point(20, 22);
            label8.Name = "label8";
            label8.Size = new Size(305, 88);
            label8.TabIndex = 0;
            label8.Text = "This logic is meant for platform games.\r\nControl the left analog with the nose\r\nwhile press some buttons with eyebrows\r\nand mouth left or right.";
            // 
            // removeScriptButton
            // 
            removeScriptButton.BackColor = Color.FromArgb(242, 101, 34);
            removeScriptButton.Cursor = Cursors.Hand;
            removeScriptButton.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            removeScriptButton.ForeColor = Color.White;
            removeScriptButton.Location = new Point(258, 101);
            removeScriptButton.Margin = new Padding(4);
            removeScriptButton.Name = "removeScriptButton";
            removeScriptButton.Size = new Size(194, 65);
            removeScriptButton.TabIndex = 47;
            removeScriptButton.Text = "Remove script";
            removeScriptButton.UseVisualStyleBackColor = false;
            removeScriptButton.Click += removeScript_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(eyebrowsBar);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(noseVerBar);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(mouthBar);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(noseHorBar);
            groupBox2.Controls.Add(label14);
            groupBox2.Font = new Font("Calibri", 32F, FontStyle.Bold, GraphicsUnit.Pixel);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(659, 154);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(247, 532);
            groupBox2.TabIndex = 45;
            groupBox2.TabStop = false;
            groupBox2.Text = "SENSIBILITY";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.path14;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Location = new Point(0, 41);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 120);
            pictureBox1.TabIndex = 46;
            pictureBox1.TabStop = false;
            pictureBox1.Click += logoImage_Click;
            // 
            // openPythonFiles
            // 
            openPythonFiles.FileName = "openFileDialog1";
            openPythonFiles.Filter = "Python files (*.py)|*.py";
            openPythonFiles.InitialDirectory = "currentPath";
            openPythonFiles.Title = "\"Open Python script\"";
            // 
            // openJSONFiles
            // 
            openJSONFiles.FileName = "openFileDialog2";
            openJSONFiles.Filter = "Json files (*.json)|*.json";
            openJSONFiles.InitialDirectory = "currentPath";
            openJSONFiles.Title = "Open JSON file";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 39, 53);
            ClientSize = new Size(949, 848);
            Controls.Add(removeScriptButton);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox2);
            Controls.Add(logicBox);
            Controls.Add(forceCompileCheck);
            Controls.Add(buildCheck);
            Controls.Add(debugLabel);
            Controls.Add(Start);
            Controls.Add(menuStrip1);
            Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Pixel);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Nose Drive GUI";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)eyebrowsBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)noseVerBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)mouthBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)noseHorBar).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            logicBox.ResumeLayout(false);
            logicBox.PerformLayout();
            move3dPanel.ResumeLayout(false);
            move3dPanel.PerformLayout();
            drivePanel.ResumeLayout(false);
            drivePanel.PerformLayout();
            platformPanel.ResumeLayout(false);
            platformPanel.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Start;
        private Label debugLabel;
        private ComboBox noseRightDropdown;
        private Label label2;
        private Label label3;
        private ComboBox noseLeftDropdown;
        private Label label6;
        private ComboBox mouthLeftDropdown;
        private Label label7;
        private ComboBox mouthRightDropdown;
        private ComboBox eyebrowsDropdown;
        private Label label4;
        private ComboBox noseDownDropdown;
        private Label label5;
        private ComboBox noseUpDropdown;
        private Label label11;
        private TrackBar eyebrowsBar;
        private TrackBar noseVerBar;
        private TrackBar mouthBar;
        private TrackBar noseHorBar;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private CheckBox buildCheck;
        private CheckBox forceCompileCheck;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem loadScriptToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private GroupBox logicBox;
        private GroupBox groupBox2;
        private PictureBox pictureBox1;
        private ComboBox presetBox;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem presetToolStripMenuItem;
        private ToolStripMenuItem scriptToolStripMenuItem;
        private ToolStripMenuItem presetToolStripMenuItem1;
        private ToolStripMenuItem sensibilityValuesToolStripMenuItem;
        private ToolStripMenuItem sensibilityToolStripMenuItem;
        private OpenFileDialog openPythonFiles;
        private OpenFileDialog openJSONFiles;
        private Button removeScriptButton;
        private Panel drivePanel;
        private Label driveLabel;
        private Panel move3dPanel;
        private Label label1;
        private Panel platformPanel;
        private Label label8;
    }
}