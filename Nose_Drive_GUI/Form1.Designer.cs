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
            savePresetMenuBtn = new ToolStripMenuItem();
            saveSensibilityMenuBtn = new ToolStripMenuItem();
            loadScriptToolStripMenuItem = new ToolStripMenuItem();
            loadPresetMenuBtn = new ToolStripMenuItem();
            loadSensibilityMenuBtn = new ToolStripMenuItem();
            loadScriptMenuBtn = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            logicBox = new GroupBox();
            descriptionPanel = new Panel();
            descriptionLabel = new Label();
            presetBox = new ComboBox();
            removeScriptButton = new Button();
            groupBox2 = new GroupBox();
            pictureBox1 = new PictureBox();
            openPythonFiles = new OpenFileDialog();
            openJSONFiles = new OpenFileDialog();
            saveJSONFiles = new SaveFileDialog();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            Stop = new Button();
            Pause = new Button();
            pauseLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)eyebrowsBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)noseVerBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mouthBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)noseHorBar).BeginInit();
            menuStrip1.SuspendLayout();
            logicBox.SuspendLayout();
            descriptionPanel.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Start
            // 
            Start.AccessibleDescription = "Starts the face tracking and virtual gamepad emulation, using the selected logic and sensibilities data.";
            Start.AccessibleName = "Start Button";
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
            debugLabel.Location = new Point(161, 55);
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
            label11.AccessibleName = "Eyebrows";
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
            label6.AccessibleName = "Mouth Left";
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
            mouthLeftDropdown.AccessibleDescription = "Use this dropdown to assign a gamepad button to the mouth left movement";
            mouthLeftDropdown.AccessibleName = "Mouth Left Dropdown";
            mouthLeftDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            mouthLeftDropdown.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Pixel);
            mouthLeftDropdown.FormattingEnabled = true;
            mouthLeftDropdown.Items.AddRange(new object[] { "", "Left Joystick Right", "Left Joystick Left", "Left Joystick Up", "Left Joystick Down", "Right Joystick Right", "Right Joystick Left", "Right Joystick Up", "Right Joystick Down", "A", "B", "X", "Y", "LT", "RT", "LB", "RB", "Start", "Select", "Dpad Right", "Dpad Left", "Dpad Up", "Dpad Down", "Right Thumb", "Left Thumb", "Home" });
            mouthLeftDropdown.Location = new Point(195, 476);
            mouthLeftDropdown.Margin = new Padding(2);
            mouthLeftDropdown.Name = "mouthLeftDropdown";
            mouthLeftDropdown.Size = new Size(171, 30);
            mouthLeftDropdown.TabIndex = 17;
            // 
            // label7
            // 
            label7.AccessibleName = "Mouth Right";
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
            mouthRightDropdown.AccessibleDescription = "Use this dropdown to assign a gamepad button to the mouth right movement";
            mouthRightDropdown.AccessibleName = "Mouth Right Dropdown";
            mouthRightDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            mouthRightDropdown.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Pixel);
            mouthRightDropdown.FormattingEnabled = true;
            mouthRightDropdown.Items.AddRange(new object[] { "", "Left Joystick Right", "Left Joystick Left", "Left Joystick Up", "Left Joystick Down", "Right Joystick Right", "Right Joystick Left", "Right Joystick Up", "Right Joystick Down", "A", "B", "X", "Y", "LT", "RT", "LB", "RB", "Start", "Select", "Dpad Right", "Dpad Left", "Dpad Up", "Dpad Down", "Right Thumb", "Left Thumb", "Home" });
            mouthRightDropdown.Location = new Point(195, 423);
            mouthRightDropdown.Margin = new Padding(2);
            mouthRightDropdown.Name = "mouthRightDropdown";
            mouthRightDropdown.Size = new Size(171, 30);
            mouthRightDropdown.TabIndex = 15;
            // 
            // eyebrowsDropdown
            // 
            eyebrowsDropdown.AccessibleDescription = "Use this dropdown to assign a gamepad button to the eyebrows movement";
            eyebrowsDropdown.AccessibleName = "Eyebrows Dropdown";
            eyebrowsDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            eyebrowsDropdown.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Pixel);
            eyebrowsDropdown.FormattingEnabled = true;
            eyebrowsDropdown.Items.AddRange(new object[] { "", "Left Joystick Right", "Left Joystick Left", "Left Joystick Up", "Left Joystick Down", "Right Joystick Right", "Right Joystick Left", "Right Joystick Up", "Right Joystick Down", "A", "B", "X", "Y", "LT", "RT", "LB", "RB", "Start", "Select", "Dpad Right", "Dpad Left", "Dpad Up", "Dpad Down", "Right Thumb", "Left Thumb", "Home" });
            eyebrowsDropdown.Location = new Point(195, 370);
            eyebrowsDropdown.Margin = new Padding(2);
            eyebrowsDropdown.Name = "eyebrowsDropdown";
            eyebrowsDropdown.Size = new Size(171, 30);
            eyebrowsDropdown.TabIndex = 13;
            // 
            // label4
            // 
            label4.AccessibleName = "Nose Down";
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
            noseDownDropdown.AccessibleDescription = "Use this dropdown to assign a gamepad button to the nose down movement";
            noseDownDropdown.AccessibleName = "Nose Down Dropdown";
            noseDownDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            noseDownDropdown.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Pixel);
            noseDownDropdown.FormattingEnabled = true;
            noseDownDropdown.Items.AddRange(new object[] { "", "Left Joystick Right", "Left Joystick Left", "Left Joystick Up", "Left Joystick Down", "Right Joystick Right", "Right Joystick Left", "Right Joystick Up", "Right Joystick Down", "A", "B", "X", "Y", "LT", "RT", "LB", "RB", "Start", "Select", "Dpad Right", "Dpad Left", "Dpad Up", "Dpad Down", "Right Thumb", "Left Thumb", "Home" });
            noseDownDropdown.Location = new Point(195, 318);
            noseDownDropdown.Margin = new Padding(2);
            noseDownDropdown.Name = "noseDownDropdown";
            noseDownDropdown.Size = new Size(171, 30);
            noseDownDropdown.TabIndex = 11;
            // 
            // label5
            // 
            label5.AccessibleName = "Nose Up";
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
            noseUpDropdown.AccessibleDescription = "Use this dropdown to assign a gamepad button to the nose up movement";
            noseUpDropdown.AccessibleName = "Nose Up Dropdown";
            noseUpDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            noseUpDropdown.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Pixel);
            noseUpDropdown.FormattingEnabled = true;
            noseUpDropdown.Items.AddRange(new object[] { "", "Left Joystick Right", "Left Joystick Left", "Left Joystick Up", "Left Joystick Down", "Right Joystick Right", "Right Joystick Left", "Right Joystick Up", "Right Joystick Down", "A", "B", "X", "Y", "LT", "RT", "LB", "RB", "Start", "Select", "Dpad Right", "Dpad Left", "Dpad Up", "Dpad Down", "Right Thumb", "Left Thumb", "Home" });
            noseUpDropdown.Location = new Point(195, 265);
            noseUpDropdown.Margin = new Padding(2);
            noseUpDropdown.Name = "noseUpDropdown";
            noseUpDropdown.Size = new Size(171, 30);
            noseUpDropdown.TabIndex = 9;
            // 
            // label3
            // 
            label3.AccessibleName = "Nose Left";
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
            noseLeftDropdown.AccessibleDescription = "Use this dropdown to assign a gamepad button to the nose left movement";
            noseLeftDropdown.AccessibleName = "Nose Left Dropdown";
            noseLeftDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            noseLeftDropdown.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Pixel);
            noseLeftDropdown.FormattingEnabled = true;
            noseLeftDropdown.Items.AddRange(new object[] { "", "Left Joystick Right", "Left Joystick Left", "Left Joystick Up", "Left Joystick Down", "Right Joystick Right", "Right Joystick Left", "Right Joystick Up", "Right Joystick Down", "A", "B", "X", "Y", "LT", "RT", "LB", "RB", "Start", "Select", "Dpad Right", "Dpad Left", "Dpad Up", "Dpad Down", "Right Thumb", "Left Thumb", "Home" });
            noseLeftDropdown.Location = new Point(195, 212);
            noseLeftDropdown.Margin = new Padding(2);
            noseLeftDropdown.Name = "noseLeftDropdown";
            noseLeftDropdown.Size = new Size(171, 30);
            noseLeftDropdown.TabIndex = 7;
            noseLeftDropdown.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AccessibleName = "Nose Right";
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
            noseRightDropdown.AccessibleDescription = "Use this dropdown to assign a gamepad button to the nose right movement";
            noseRightDropdown.AccessibleName = "Nose Right Dropdown";
            noseRightDropdown.DropDownStyle = ComboBoxStyle.DropDownList;
            noseRightDropdown.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Pixel);
            noseRightDropdown.FormattingEnabled = true;
            noseRightDropdown.Items.AddRange(new object[] { "", "Left Joystick Right", "Left Joystick Left", "Left Joystick Up", "Left Joystick Down", "Right Joystick Right", "Right Joystick Left", "Right Joystick Up", "Right Joystick Down", "A", "B", "X", "Y", "LT", "RT", "LB", "RB", "Start", "Select", "Dpad Right", "Dpad Left", "Dpad Up", "Dpad Down", "Right Thumb", "Left Thumb", "Home" });
            noseRightDropdown.Location = new Point(195, 159);
            noseRightDropdown.Margin = new Padding(2);
            noseRightDropdown.Name = "noseRightDropdown";
            noseRightDropdown.Size = new Size(171, 30);
            noseRightDropdown.TabIndex = 5;
            noseRightDropdown.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // eyebrowsBar
            // 
            eyebrowsBar.AccessibleDescription = "Use this slider to adjust the sensibility of the eyebrows movement";
            eyebrowsBar.AccessibleName = "Eyebrows Slider";
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
            noseVerBar.AccessibleDescription = "Use this slider to adjust the sensibility of the nose vertical movement";
            noseVerBar.AccessibleName = "Nose Vertical Slider";
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
            mouthBar.AccessibleDescription = "Use this slider to adjust the sensibility of the mouth horizontal movement";
            mouthBar.AccessibleName = "Mouth Horizontal Slider";
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
            noseHorBar.AccessibleDescription = "Use this slider to adjust the sensibility of the nose horizontal movement";
            noseHorBar.AccessibleName = "Nose Horizontal Slider";
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
            label14.AccessibleDescription = "";
            label14.AccessibleName = "Eyebrows Label";
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
            label15.AccessibleName = "Mouth Horizontal Label";
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
            label16.AccessibleName = "Nose Vertical Label";
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
            label17.AccessibleName = "Nose Horizontal Label";
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
            buildCheck.AccessibleDescription = "Check this if you want to build the logic into binaries. Takes a bit the first time but then should have less input lag.";
            buildCheck.AccessibleName = "Build Check";
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
            forceCompileCheck.AccessibleDescription = "Check this if you want to force recompile logics that you already compiled using the build check.";
            forceCompileCheck.AccessibleName = "Force recompile Check";
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
            saveToolStripMenuItem.AccessibleDescription = "Menu for saving logic or sensibility data in json files";
            saveToolStripMenuItem.AccessibleName = "Save Menu Item";
            saveToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { savePresetMenuBtn, saveSensibilityMenuBtn });
            saveToolStripMenuItem.Font = new Font("Calibri", 12F);
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(75, 33);
            saveToolStripMenuItem.Text = "Save";
            // 
            // savePresetMenuBtn
            // 
            savePresetMenuBtn.AccessibleDescription = "Save Logic data in a JSON file";
            savePresetMenuBtn.AccessibleName = "Save Logic Button";
            savePresetMenuBtn.Name = "savePresetMenuBtn";
            savePresetMenuBtn.Size = new Size(287, 38);
            savePresetMenuBtn.Text = "Logic";
            savePresetMenuBtn.Click += savePreset_Click;
            // 
            // saveSensibilityMenuBtn
            // 
            saveSensibilityMenuBtn.AccessibleDescription = "Save Sensibility data in a JSON file";
            saveSensibilityMenuBtn.AccessibleName = "Save Sensibility Button";
            saveSensibilityMenuBtn.Name = "saveSensibilityMenuBtn";
            saveSensibilityMenuBtn.Size = new Size(287, 38);
            saveSensibilityMenuBtn.Text = "Sensibility Values";
            saveSensibilityMenuBtn.Click += saveSensibilityValues;
            // 
            // loadScriptToolStripMenuItem
            // 
            loadScriptToolStripMenuItem.AccessibleDescription = "Menu for loading logic or sensibility data in json files";
            loadScriptToolStripMenuItem.AccessibleName = "Load Menu Item";
            loadScriptToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loadPresetMenuBtn, loadSensibilityMenuBtn, loadScriptMenuBtn });
            loadScriptToolStripMenuItem.Font = new Font("Calibri", 12F);
            loadScriptToolStripMenuItem.Name = "loadScriptToolStripMenuItem";
            loadScriptToolStripMenuItem.Size = new Size(77, 33);
            loadScriptToolStripMenuItem.Text = "Load";
            // 
            // loadPresetMenuBtn
            // 
            loadPresetMenuBtn.AccessibleDescription = "Load a Logic JSON file";
            loadPresetMenuBtn.AccessibleName = "Load Logic Button";
            loadPresetMenuBtn.Name = "loadPresetMenuBtn";
            loadPresetMenuBtn.Size = new Size(287, 38);
            loadPresetMenuBtn.Text = "Logic";
            loadPresetMenuBtn.Click += loadPreset_Click;
            // 
            // loadSensibilityMenuBtn
            // 
            loadSensibilityMenuBtn.AccessibleDescription = "Load a Sensibility JSON file";
            loadSensibilityMenuBtn.AccessibleName = "Load Sensibility Button";
            loadSensibilityMenuBtn.Name = "loadSensibilityMenuBtn";
            loadSensibilityMenuBtn.Size = new Size(287, 38);
            loadSensibilityMenuBtn.Text = "Sensibility Values";
            loadSensibilityMenuBtn.Click += loadSettings_Click;
            // 
            // loadScriptMenuBtn
            // 
            loadScriptMenuBtn.AccessibleDescription = "Load custom pytnon script that implements the nose-drive library. It will replace the logic in the GUI.";
            loadScriptMenuBtn.AccessibleName = "Load Script Button";
            loadScriptMenuBtn.Name = "loadScriptMenuBtn";
            loadScriptMenuBtn.Size = new Size(287, 38);
            loadScriptMenuBtn.Text = "Script";
            loadScriptMenuBtn.Click += loadScript_Click;
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.AccessibleName = "Options menu item";
            settingsToolStripMenuItem.Font = new Font("Calibri", 12F);
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(106, 33);
            settingsToolStripMenuItem.Text = "Options";
            settingsToolStripMenuItem.Click += optionsForm_Click;
            // 
            // logicBox
            // 
            logicBox.AccessibleDescription = "Logic box containing dropdown menus to bind each movement to a gamepad button.";
            logicBox.AccessibleName = "Logic Box Container";
            logicBox.Controls.Add(descriptionPanel);
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
            logicBox.Size = new Size(404, 532);
            logicBox.TabIndex = 44;
            logicBox.TabStop = false;
            logicBox.Text = "LOGIC";
            // 
            // descriptionPanel
            // 
            descriptionPanel.AccessibleName = "Description Panel";
            descriptionPanel.Controls.Add(descriptionLabel);
            descriptionPanel.Location = new Point(14, 137);
            descriptionPanel.Name = "descriptionPanel";
            descriptionPanel.Size = new Size(373, 388);
            descriptionPanel.TabIndex = 49;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AccessibleName = "Description Label";
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Pixel, 0);
            descriptionLabel.Location = new Point(10, 22);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new Size(360, 286);
            descriptionLabel.TabIndex = 0;
            descriptionLabel.Text = resources.GetString("descriptionLabel.Text");
            // 
            // presetBox
            // 
            presetBox.AccessibleDescription = "Selection box to change logic, can be custom or one of the default embedded logics.";
            presetBox.AccessibleName = "Logic selection box";
            presetBox.BackColor = Color.FromArgb(44, 39, 53);
            presetBox.DropDownStyle = ComboBoxStyle.DropDownList;
            presetBox.Font = new Font("Calibri", 32F, FontStyle.Regular, GraphicsUnit.Pixel);
            presetBox.ForeColor = Color.White;
            presetBox.FormattingEnabled = true;
            presetBox.Items.AddRange(new object[] { "Custom logic", "Driving games", "3D Movement", "Platform" });
            presetBox.Location = new Point(111, 67);
            presetBox.Margin = new Padding(2);
            presetBox.Name = "presetBox";
            presetBox.Size = new Size(255, 47);
            presetBox.TabIndex = 23;
            presetBox.SelectedIndexChanged += presetBox_SelectedIndexChanged_1;
            // 
            // removeScriptButton
            // 
            removeScriptButton.AccessibleDescription = "Remove currently loaded python nose-drive script and return to GUI custom logic selection.";
            removeScriptButton.AccessibleName = "Remove Script Button";
            removeScriptButton.BackColor = Color.FromArgb(227, 94, 163);
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
            groupBox2.AccessibleDescription = "Sensibility box containing sliders to adjust the sensibility of the supported facial movements";
            groupBox2.AccessibleName = "Sensibility Box Container";
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(eyebrowsBar);
            groupBox2.Controls.Add(noseHorBar);
            groupBox2.Controls.Add(noseVerBar);
            groupBox2.Controls.Add(mouthBar);
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
            pictureBox1.AccessibleDescription = "Click this logo to view ASPHI Onlus website";
            pictureBox1.AccessibleName = "ASPHI Onlus Logo";
            pictureBox1.BackgroundImage = Properties.Resources.logo_onlus;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Location = new Point(13, 41);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(94, 108);
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
            // saveJSONFiles
            // 
            saveJSONFiles.Filter = "Json files (*.json)|*.json";
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            // 
            // Stop
            // 
            Stop.AccessibleDescription = "Stops the face tracking and virtual gamepad emulation";
            Stop.AccessibleName = "Stop Button";
            Stop.BackColor = Color.FromArgb(227, 94, 163);
            Stop.Cursor = Cursors.Hand;
            Stop.Font = new Font("Calibri", 38F, FontStyle.Bold, GraphicsUnit.Pixel);
            Stop.ForeColor = Color.White;
            Stop.Location = new Point(450, 742);
            Stop.Margin = new Padding(4);
            Stop.Name = "Stop";
            Stop.Size = new Size(214, 78);
            Stop.TabIndex = 48;
            Stop.Text = "STOP";
            Stop.UseVisualStyleBackColor = false;
            Stop.Visible = false;
            Stop.Click += Stop_Click;
            // 
            // Pause
            // 
            Pause.AccessibleDescription = "Stops the face tracking and virtual gamepad emulation";
            Pause.AccessibleName = "Stop Button";
            Pause.BackColor = Color.FromArgb(3, 160, 139);
            Pause.Cursor = Cursors.Hand;
            Pause.Font = new Font("Calibri", 38F, FontStyle.Bold, GraphicsUnit.Pixel);
            Pause.ForeColor = Color.White;
            Pause.Location = new Point(207, 742);
            Pause.Margin = new Padding(4);
            Pause.Name = "Pause";
            Pause.Size = new Size(214, 78);
            Pause.TabIndex = 49;
            Pause.Text = "PAUSE";
            Pause.UseVisualStyleBackColor = false;
            Pause.Visible = false;
            Pause.EnabledChanged += Pause_EnabledChanged;
            Pause.Click += Pause_Click;
            // 
            // pauseLabel
            // 
            pauseLabel.AccessibleDescription = "Warning label for missing pause key";
            pauseLabel.AccessibleName = "Missing pause key warning";
            pauseLabel.AutoSize = true;
            pauseLabel.ForeColor = SystemColors.ButtonFace;
            pauseLabel.Location = new Point(223, 707);
            pauseLabel.Margin = new Padding(4, 0, 4, 0);
            pauseLabel.Name = "pauseLabel";
            pauseLabel.Size = new Size(181, 132);
            pauseLabel.TabIndex = 50;
            pauseLabel.Text = "Pausing is disabled.\r\nTo enable pausing,\r\nassign a keyboard letter\r\nor number key to the\r\npause field inside the\r\noptions menu.";
            pauseLabel.Visible = false;
            // 
            // Form1
            // 
            AccessibleDescription = "A graphical user interface for the nose-drive project.";
            AccessibleName = "Nose Drive GUI";
            AutoScaleDimensions = new SizeF(9F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 39, 53);
            ClientSize = new Size(949, 848);
            Controls.Add(pauseLabel);
            Controls.Add(Pause);
            Controls.Add(Stop);
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
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)eyebrowsBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)noseVerBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)mouthBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)noseHorBar).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            logicBox.ResumeLayout(false);
            logicBox.PerformLayout();
            descriptionPanel.ResumeLayout(false);
            descriptionPanel.PerformLayout();
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
        private ToolStripMenuItem loadPresetMenuBtn;
        private ToolStripMenuItem loadScriptMenuBtn;
        private ToolStripMenuItem savePresetMenuBtn;
        private ToolStripMenuItem saveSensibilityMenuBtn;
        private ToolStripMenuItem loadSensibilityMenuBtn;
        private OpenFileDialog openPythonFiles;
        private OpenFileDialog openJSONFiles;
        private Button removeScriptButton;
        private Panel drivePanel;
        private Label driveLabel;
        private Panel descriptionPanel;
        private Label descriptionLabel;
        private Panel platformPanel;
        private Label label8;
        private SaveFileDialog saveJSONFiles;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button Stop;
        private Button Pause;
        private Label pauseLabel;
    }
}