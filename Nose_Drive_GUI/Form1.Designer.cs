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
            Start = new Button();
            label1 = new Label();
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
            trackBar6 = new TrackBar();
            trackBar4 = new TrackBar();
            trackBar2 = new TrackBar();
            trackBar1 = new TrackBar();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            menuStrip1 = new MenuStrip();
            saveToolStripMenuItem = new ToolStripMenuItem();
            loadScriptToolStripMenuItem = new ToolStripMenuItem();
            presetToolStripMenuItem = new ToolStripMenuItem();
            scriptToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            comboBox1 = new ComboBox();
            groupBox2 = new GroupBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)trackBar6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Start
            // 
            Start.BackColor = Color.FromArgb(242, 81, 27);
            Start.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point);
            Start.ForeColor = Color.White;
            Start.Location = new Point(546, 843);
            Start.Margin = new Padding(4);
            Start.Name = "Start";
            Start.Size = new Size(238, 89);
            Start.TabIndex = 2;
            Start.Text = "START";
            Start.UseVisualStyleBackColor = false;
            Start.Click += start_button;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(191, 56);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 3;
            label1.Text = "label1";
            label1.Visible = false;
            label1.Click += label1_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Pixel);
            label11.ForeColor = Color.White;
            label11.Location = new Point(16, 421);
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
            label6.Location = new Point(16, 541);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(119, 29);
            label6.TabIndex = 18;
            label6.Text = "Mouth left";
            // 
            // mouthLeftDropdown
            // 
            mouthLeftDropdown.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            mouthLeftDropdown.FormattingEnabled = true;
            mouthLeftDropdown.Items.AddRange(new object[] { "Left Joystick Right", "Left Joystick Left", "Left Joystick Up", "Left Joystick Down", "Right Joystick Right", "Right Joystick Left", "Right Joystick Up", "Right Joystick Down", "A", "B", "X", "Y", "LT", "RT", "LB", "RB", "Start", "Select", "Dpad Right", "Dpad Left", "Dpad Up", "Dpad Down", "Right Thumb", "Left Thumb", "Home" });
            mouthLeftDropdown.Location = new Point(217, 533);
            mouthLeftDropdown.Margin = new Padding(2);
            mouthLeftDropdown.Name = "mouthLeftDropdown";
            mouthLeftDropdown.Size = new Size(212, 37);
            mouthLeftDropdown.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Pixel);
            label7.ForeColor = Color.White;
            label7.Location = new Point(16, 481);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(132, 29);
            label7.TabIndex = 16;
            label7.Text = "Mouth right";
            // 
            // mouthRightDropdown
            // 
            mouthRightDropdown.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            mouthRightDropdown.FormattingEnabled = true;
            mouthRightDropdown.Items.AddRange(new object[] { "Left Joystick Right", "Left Joystick Left", "Left Joystick Up", "Left Joystick Down", "Right Joystick Right", "Right Joystick Left", "Right Joystick Up", "Right Joystick Down", "A", "B", "X", "Y", "LT", "RT", "LB", "RB", "Start", "Select", "Dpad Right", "Dpad Left", "Dpad Up", "Dpad Down", "Right Thumb", "Left Thumb", "Home" });
            mouthRightDropdown.Location = new Point(217, 473);
            mouthRightDropdown.Margin = new Padding(2);
            mouthRightDropdown.Name = "mouthRightDropdown";
            mouthRightDropdown.Size = new Size(212, 37);
            mouthRightDropdown.TabIndex = 15;
            // 
            // eyebrowsDropdown
            // 
            eyebrowsDropdown.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            eyebrowsDropdown.FormattingEnabled = true;
            eyebrowsDropdown.Items.AddRange(new object[] { "Left Joystick Right", "Left Joystick Left", "Left Joystick Up", "Left Joystick Down", "Right Joystick Right", "Right Joystick Left", "Right Joystick Up", "Right Joystick Down", "A", "B", "X", "Y", "LT", "RT", "LB", "RB", "Start", "Select", "Dpad Right", "Dpad Left", "Dpad Up", "Dpad Down", "Right Thumb", "Left Thumb", "Home" });
            eyebrowsDropdown.Location = new Point(217, 413);
            eyebrowsDropdown.Margin = new Padding(2);
            eyebrowsDropdown.Name = "eyebrowsDropdown";
            eyebrowsDropdown.Size = new Size(212, 37);
            eyebrowsDropdown.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Pixel);
            label4.ForeColor = Color.White;
            label4.Location = new Point(16, 361);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(124, 29);
            label4.TabIndex = 12;
            label4.Text = "Nose down";
            label4.Click += label4_Click;
            // 
            // noseDownDropdown
            // 
            noseDownDropdown.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            noseDownDropdown.FormattingEnabled = true;
            noseDownDropdown.Items.AddRange(new object[] { "Left Joystick Right", "Left Joystick Left", "Left Joystick Up", "Left Joystick Down", "Right Joystick Right", "Right Joystick Left", "Right Joystick Up", "Right Joystick Down", "A", "B", "X", "Y", "LT", "RT", "LB", "RB", "Start", "Select", "Dpad Right", "Dpad Left", "Dpad Up", "Dpad Down", "Right Thumb", "Left Thumb", "Home" });
            noseDownDropdown.Location = new Point(217, 353);
            noseDownDropdown.Margin = new Padding(2);
            noseDownDropdown.Name = "noseDownDropdown";
            noseDownDropdown.Size = new Size(212, 37);
            noseDownDropdown.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Pixel);
            label5.ForeColor = Color.White;
            label5.Location = new Point(16, 301);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(94, 29);
            label5.TabIndex = 10;
            label5.Text = "Nose up";
            // 
            // noseUpDropdown
            // 
            noseUpDropdown.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            noseUpDropdown.FormattingEnabled = true;
            noseUpDropdown.Items.AddRange(new object[] { "Left Joystick Right", "Left Joystick Left", "Left Joystick Up", "Left Joystick Down", "Right Joystick Right", "Right Joystick Left", "Right Joystick Up", "Right Joystick Down", "A", "B", "X", "Y", "LT", "RT", "LB", "RB", "Start", "Select", "Dpad Right", "Dpad Left", "Dpad Up", "Dpad Down", "Right Thumb", "Left Thumb", "Home" });
            noseUpDropdown.Location = new Point(217, 293);
            noseUpDropdown.Margin = new Padding(2);
            noseUpDropdown.Name = "noseUpDropdown";
            noseUpDropdown.Size = new Size(212, 37);
            noseUpDropdown.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Pixel);
            label3.ForeColor = Color.White;
            label3.Location = new Point(16, 241);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(101, 29);
            label3.TabIndex = 8;
            label3.Text = "Nose left";
            // 
            // noseLeftDropdown
            // 
            noseLeftDropdown.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            noseLeftDropdown.FormattingEnabled = true;
            noseLeftDropdown.Items.AddRange(new object[] { "Left Joystick Right", "Left Joystick Left", "Left Joystick Up", "Left Joystick Down", "Right Joystick Right", "Right Joystick Left", "Right Joystick Up", "Right Joystick Down", "A", "B", "X", "Y", "LT", "RT", "LB", "RB", "Start", "Select", "Dpad Right", "Dpad Left", "Dpad Up", "Dpad Down", "Right Thumb", "Left Thumb", "Home" });
            noseLeftDropdown.Location = new Point(217, 233);
            noseLeftDropdown.Margin = new Padding(2);
            noseLeftDropdown.Name = "noseLeftDropdown";
            noseLeftDropdown.Size = new Size(212, 37);
            noseLeftDropdown.TabIndex = 7;
            noseLeftDropdown.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Pixel);
            label2.ForeColor = Color.White;
            label2.Location = new Point(16, 181);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(114, 29);
            label2.TabIndex = 6;
            label2.Text = "Nose right";
            label2.Click += label2_Click;
            // 
            // noseRightDropdown
            // 
            noseRightDropdown.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            noseRightDropdown.FormattingEnabled = true;
            noseRightDropdown.Items.AddRange(new object[] { "Left Joystick Right", "Left Joystick Left", "Left Joystick Up", "Left Joystick Down", "Right Joystick Right", "Right Joystick Left", "Right Joystick Up", "Right Joystick Down", "A", "B", "X", "Y", "LT", "RT", "LB", "RB", "Start", "Select", "Dpad Right", "Dpad Left", "Dpad Up", "Dpad Down", "Right Thumb", "Left Thumb", "Home" });
            noseRightDropdown.Location = new Point(217, 173);
            noseRightDropdown.Margin = new Padding(2);
            noseRightDropdown.Name = "noseRightDropdown";
            noseRightDropdown.Size = new Size(212, 37);
            noseRightDropdown.TabIndex = 5;
            noseRightDropdown.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // trackBar6
            // 
            trackBar6.LargeChange = 1;
            trackBar6.Location = new Point(19, 391);
            trackBar6.Margin = new Padding(2, 4, 2, 4);
            trackBar6.Maximum = 5;
            trackBar6.Minimum = 1;
            trackBar6.Name = "trackBar6";
            trackBar6.Size = new Size(214, 69);
            trackBar6.TabIndex = 35;
            trackBar6.Value = 3;
            // 
            // trackBar4
            // 
            trackBar4.LargeChange = 1;
            trackBar4.Location = new Point(19, 256);
            trackBar4.Margin = new Padding(2, 4, 2, 4);
            trackBar4.Maximum = 5;
            trackBar4.Minimum = 1;
            trackBar4.Name = "trackBar4";
            trackBar4.Size = new Size(214, 69);
            trackBar4.TabIndex = 34;
            trackBar4.Value = 3;
            // 
            // trackBar2
            // 
            trackBar2.LargeChange = 1;
            trackBar2.Location = new Point(19, 526);
            trackBar2.Margin = new Padding(2, 4, 2, 4);
            trackBar2.Maximum = 5;
            trackBar2.Minimum = 1;
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(214, 69);
            trackBar2.TabIndex = 33;
            trackBar2.Value = 3;
            // 
            // trackBar1
            // 
            trackBar1.LargeChange = 1;
            trackBar1.Location = new Point(19, 121);
            trackBar1.Margin = new Padding(2, 4, 2, 4);
            trackBar1.Maximum = 5;
            trackBar1.Minimum = 1;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(214, 69);
            trackBar1.TabIndex = 32;
            trackBar1.Value = 3;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Calibri", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = Color.White;
            label14.Location = new Point(19, 346);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(142, 39);
            label14.TabIndex = 31;
            label14.Text = "Eyebrows";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Calibri", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = Color.White;
            label15.Location = new Point(19, 481);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(244, 39);
            label15.TabIndex = 30;
            label15.Text = "Mouth horizontal";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Calibri", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label16.ForeColor = Color.White;
            label16.Location = new Point(19, 211);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(186, 39);
            label16.TabIndex = 29;
            label16.Text = "Nose vertical";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Calibri", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label17.ForeColor = Color.White;
            label17.Location = new Point(19, 76);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(222, 39);
            label17.TabIndex = 28;
            label17.Text = "Nose horizontal";
            label17.Click += label17_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.ForeColor = Color.White;
            checkBox1.Location = new Point(802, 880);
            checkBox1.Margin = new Padding(2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(90, 33);
            checkBox1.TabIndex = 41;
            checkBox1.Text = "Build";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += build_Checked;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox2.ForeColor = Color.White;
            checkBox2.Location = new Point(802, 919);
            checkBox2.Margin = new Padding(2);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(204, 33);
            checkBox2.TabIndex = 42;
            checkBox2.Text = "Force re-compile";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.Visible = false;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { saveToolStripMenuItem, loadScriptToolStripMenuItem, settingsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1049, 37);
            menuStrip1.TabIndex = 43;
            menuStrip1.Text = "menuStrip1";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(75, 33);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += save_preset;
            // 
            // loadScriptToolStripMenuItem
            // 
            loadScriptToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { presetToolStripMenuItem, scriptToolStripMenuItem });
            loadScriptToolStripMenuItem.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            loadScriptToolStripMenuItem.Name = "loadScriptToolStripMenuItem";
            loadScriptToolStripMenuItem.Size = new Size(77, 33);
            loadScriptToolStripMenuItem.Text = "Load";
            // 
            // presetToolStripMenuItem
            // 
            presetToolStripMenuItem.Name = "presetToolStripMenuItem";
            presetToolStripMenuItem.Size = new Size(177, 38);
            presetToolStripMenuItem.Text = "Preset";
            presetToolStripMenuItem.Click += load_preset;
            // 
            // scriptToolStripMenuItem
            // 
            scriptToolStripMenuItem.Name = "scriptToolStripMenuItem";
            scriptToolStripMenuItem.Size = new Size(177, 38);
            scriptToolStripMenuItem.Text = "Script";
            scriptToolStripMenuItem.Click += load_script;
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(106, 33);
            settingsToolStripMenuItem.Text = "Settings";
            settingsToolStripMenuItem.Click += settingsToolStripMenuItem_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(noseRightDropdown);
            groupBox1.Controls.Add(mouthLeftDropdown);
            groupBox1.Controls.Add(noseLeftDropdown);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(mouthRightDropdown);
            groupBox1.Controls.Add(noseUpDropdown);
            groupBox1.Controls.Add(eyebrowsDropdown);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(noseDownDropdown);
            groupBox1.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(163, 175);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(458, 605);
            groupBox1.TabIndex = 44;
            groupBox1.TabStop = false;
            groupBox1.Text = "LOGIC";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(44, 39, 53);
            comboBox1.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.ForeColor = Color.White;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Driving games", "3D Movement", "Platform", "Custom preset" });
            comboBox1.Location = new Point(115, 76);
            comboBox1.Margin = new Padding(2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(212, 43);
            comboBox1.TabIndex = 23;
            comboBox1.Text = "Custom preset";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(trackBar6);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(trackBar4);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(trackBar2);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(trackBar1);
            groupBox2.Controls.Add(label14);
            groupBox2.Font = new Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(732, 175);
            groupBox2.Margin = new Padding(4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4);
            groupBox2.Size = new Size(274, 605);
            groupBox2.TabIndex = 45;
            groupBox2.TabStop = false;
            groupBox2.Text = "SENSIBILITY";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.path14;
            pictureBox1.Location = new Point(0, 40);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(120, 120);
            pictureBox1.TabIndex = 46;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 39, 53);
            ClientSize = new Size(1049, 967);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label1);
            Controls.Add(Start);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Nose Drive GUI";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)trackBar6).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar4).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Start;
        private Label label1;
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
        private TrackBar trackBar6;
        private TrackBar trackBar4;
        private TrackBar trackBar2;
        private TrackBar trackBar1;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem loadScriptToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private PictureBox pictureBox1;
        private ComboBox comboBox1;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem presetToolStripMenuItem;
        private ToolStripMenuItem scriptToolStripMenuItem;
    }
}