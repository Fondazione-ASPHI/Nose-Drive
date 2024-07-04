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
            Script = new Button();
            Start = new Button();
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            label11 = new Label();
            label6 = new Label();
            comboBox5 = new ComboBox();
            label7 = new Label();
            comboBox6 = new ComboBox();
            comboBox7 = new ComboBox();
            label4 = new Label();
            comboBox3 = new ComboBox();
            label5 = new Label();
            comboBox4 = new ComboBox();
            label3 = new Label();
            comboBox2 = new ComboBox();
            label2 = new Label();
            comboBox1 = new ComboBox();
            tabPage3 = new TabPage();
            label21 = new Label();
            tabControl2 = new TabControl();
            tabPage1 = new TabPage();
            trackBar6 = new TrackBar();
            trackBar4 = new TrackBar();
            trackBar2 = new TrackBar();
            trackBar1 = new TrackBar();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            button3 = new Button();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            menuStrip1 = new MenuStrip();
            loadScriptToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabControl2.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // Script
            // 
            Script.ForeColor = SystemColors.ActiveCaptionText;
            Script.Location = new Point(106, 143);
            Script.Margin = new Padding(4);
            Script.Name = "Script";
            Script.Size = new Size(240, 92);
            Script.TabIndex = 0;
            Script.Text = "Remove Script";
            Script.UseVisualStyleBackColor = true;
            Script.Click += remove_script;
            // 
            // Start
            // 
            Start.BackColor = Color.FromArgb(242, 101, 34);
            Start.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Point);
            Start.ForeColor = Color.White;
            Start.Location = new Point(391, 680);
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
            label1.Location = new Point(16, 655);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 3;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Font = new Font("Calibri", 16F, FontStyle.Bold, GraphicsUnit.Point);
            tabControl1.Location = new Point(12, 46);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(473, 606);
            tabControl1.TabIndex = 4;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Black;
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(comboBox5);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(comboBox6);
            tabPage2.Controls.Add(comboBox7);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(comboBox3);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(comboBox4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(comboBox2);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(comboBox1);
            tabPage2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage2.ForeColor = SystemColors.ButtonFace;
            tabPage2.Location = new Point(4, 48);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(465, 554);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Logic";
            tabPage2.Click += tabPage2_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Calibri", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = SystemColors.ButtonFace;
            label11.Location = new Point(25, 300);
            label11.Name = "label11";
            label11.Size = new Size(142, 39);
            label11.TabIndex = 22;
            label11.Text = "Eyebrows";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(25, 496);
            label6.Name = "label6";
            label6.Size = new Size(156, 39);
            label6.TabIndex = 18;
            label6.Text = "Mouth left";
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] { "A", "B", "LT", "RT", "L Analog Left", "L Analog Right", "L Analog Up", "L Analog Down" });
            comboBox5.Location = new Point(255, 491);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(182, 37);
            comboBox5.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(28, 446);
            label7.Name = "label7";
            label7.Size = new Size(174, 39);
            label7.TabIndex = 16;
            label7.Text = "Mouth right";
            // 
            // comboBox6
            // 
            comboBox6.FormattingEnabled = true;
            comboBox6.Items.AddRange(new object[] { "A", "B", "LT", "RT", "L Analog Left", "L Analog Right", "L Analog Up", "L Analog Down" });
            comboBox6.Location = new Point(255, 441);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(182, 37);
            comboBox6.TabIndex = 15;
            // 
            // comboBox7
            // 
            comboBox7.FormattingEnabled = true;
            comboBox7.Items.AddRange(new object[] { "A", "B", "LT", "RT", "L Analog Left", "L Analog Right", "L Analog Up", "L Analog Down" });
            comboBox7.Location = new Point(255, 295);
            comboBox7.Name = "comboBox7";
            comboBox7.Size = new Size(182, 37);
            comboBox7.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(19, 192);
            label4.Name = "label4";
            label4.Size = new Size(165, 39);
            label4.TabIndex = 12;
            label4.Text = "Nose down";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "A", "B", "LT", "RT", "L Analog Left", "L Analog Right", "L Analog Up", "L Analog Down" });
            comboBox3.Location = new Point(255, 187);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(182, 37);
            comboBox3.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(19, 149);
            label5.Name = "label5";
            label5.Size = new Size(125, 39);
            label5.TabIndex = 10;
            label5.Text = "Nose up";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "A", "B", "LT", "RT", "L Analog Left", "L Analog Right", "L Analog Up", "L Analog Down" });
            comboBox4.Location = new Point(255, 144);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(182, 37);
            comboBox4.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(19, 107);
            label3.Name = "label3";
            label3.Size = new Size(134, 39);
            label3.TabIndex = 8;
            label3.Text = "Nose left";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "A", "B", "LT", "RT", "L Analog Left", "L Analog Right", "L Analog Up", "L Analog Down" });
            comboBox2.Location = new Point(255, 102);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(182, 37);
            comboBox2.TabIndex = 7;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(19, 66);
            label2.Name = "label2";
            label2.Size = new Size(152, 39);
            label2.TabIndex = 6;
            label2.Text = "Nose right";
            label2.Click += label2_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "A", "B", "LT", "RT", "L Analog Left", "L Analog Right", "L Analog Up", "L Analog Down" });
            comboBox1.Location = new Point(255, 61);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 37);
            comboBox1.TabIndex = 5;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.Black;
            tabPage3.Controls.Add(label21);
            tabPage3.Controls.Add(Script);
            tabPage3.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage3.ForeColor = SystemColors.ButtonFace;
            tabPage3.Location = new Point(4, 48);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(465, 554);
            tabPage3.TabIndex = 2;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(67, 345);
            label21.Name = "label21";
            label21.Size = new Size(321, 58);
            label21.TabIndex = 25;
            label21.Text = "When a script is loaded,\r\nLOGIC is managed by the script.";
            label21.Click += label21_Click;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPage1);
            tabControl2.Font = new Font("Calibri", 14F, FontStyle.Bold, GraphicsUnit.Point);
            tabControl2.Location = new Point(550, 46);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(381, 606);
            tabControl2.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Black;
            tabPage1.Controls.Add(trackBar6);
            tabPage1.Controls.Add(trackBar4);
            tabPage1.Controls.Add(trackBar2);
            tabPage1.Controls.Add(trackBar1);
            tabPage1.Controls.Add(label14);
            tabPage1.Controls.Add(label15);
            tabPage1.Controls.Add(label16);
            tabPage1.Controls.Add(label17);
            tabPage1.Font = new Font("Calibri", 16F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage1.ForeColor = SystemColors.ButtonFace;
            tabPage1.Location = new Point(4, 44);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(373, 558);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Sensibility";
            tabPage1.Click += tabPage1_Click_1;
            // 
            // trackBar6
            // 
            trackBar6.Location = new Point(61, 461);
            trackBar6.Margin = new Padding(3, 4, 3, 4);
            trackBar6.Maximum = 5;
            trackBar6.Name = "trackBar6";
            trackBar6.Size = new Size(214, 69);
            trackBar6.TabIndex = 35;
            trackBar6.Value = 5;
            // 
            // trackBar4
            // 
            trackBar4.Location = new Point(61, 220);
            trackBar4.Margin = new Padding(3, 4, 3, 4);
            trackBar4.Maximum = 5;
            trackBar4.Name = "trackBar4";
            trackBar4.Size = new Size(214, 69);
            trackBar4.TabIndex = 34;
            trackBar4.Value = 5;
            // 
            // trackBar2
            // 
            trackBar2.Location = new Point(61, 345);
            trackBar2.Margin = new Padding(3, 4, 3, 4);
            trackBar2.Maximum = 5;
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(214, 69);
            trackBar2.TabIndex = 33;
            trackBar2.Value = 5;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(61, 104);
            trackBar1.Margin = new Padding(3, 4, 3, 4);
            trackBar1.Maximum = 5;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(214, 69);
            trackBar1.TabIndex = 32;
            trackBar1.Value = 5;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Calibri", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label14.ForeColor = SystemColors.ButtonFace;
            label14.Location = new Point(61, 418);
            label14.Name = "label14";
            label14.Size = new Size(142, 39);
            label14.TabIndex = 31;
            label14.Text = "Eyebrows";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Calibri", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label15.ForeColor = SystemColors.ButtonFace;
            label15.Location = new Point(61, 293);
            label15.Name = "label15";
            label15.Size = new Size(244, 39);
            label15.TabIndex = 30;
            label15.Text = "Mouth horizontal";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Calibri", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label16.ForeColor = SystemColors.ButtonFace;
            label16.Location = new Point(61, 177);
            label16.Name = "label16";
            label16.Size = new Size(186, 39);
            label16.TabIndex = 29;
            label16.Text = "Nose vertical";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Calibri", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label17.ForeColor = SystemColors.ButtonFace;
            label17.Location = new Point(61, 70);
            label17.Name = "label17";
            label17.Size = new Size(222, 39);
            label17.TabIndex = 28;
            label17.Text = "Nose horizontal";
            label17.Click += label17_Click;
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources.ASP_logo;
            button3.Location = new Point(1595, 758);
            button3.Name = "button3";
            button3.Size = new Size(221, 185);
            button3.TabIndex = 40;
            button3.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(646, 720);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(90, 33);
            checkBox1.TabIndex = 41;
            checkBox1.Text = "Build";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox2.Location = new Point(646, 746);
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
            menuStrip1.Items.AddRange(new ToolStripItem[] { loadScriptToolStripMenuItem, settingsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(948, 37);
            menuStrip1.TabIndex = 43;
            menuStrip1.Text = "menuStrip1";
            // 
            // loadScriptToolStripMenuItem
            // 
            loadScriptToolStripMenuItem.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            loadScriptToolStripMenuItem.Name = "loadScriptToolStripMenuItem";
            loadScriptToolStripMenuItem.Size = new Size(138, 33);
            loadScriptToolStripMenuItem.Text = "Load Script";
            loadScriptToolStripMenuItem.Click += select_script;
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(92, 33);
            settingsToolStripMenuItem.Text = "Settings";
            settingsToolStripMenuItem.Click += settingsToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 788);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(button3);
            Controls.Add(tabControl2);
            Controls.Add(label1);
            Controls.Add(tabControl1);
            Controls.Add(Start);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabControl2.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar6).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar4).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Script;
        private Button Start;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage2;
        private ComboBox comboBox1;
        private Label label2;
        private Label label3;
        private ComboBox comboBox2;
        private Label label6;
        private ComboBox comboBox5;
        private Label label7;
        private ComboBox comboBox6;
        private ComboBox comboBox7;
        private Label label4;
        private ComboBox comboBox3;
        private Label label5;
        private ComboBox comboBox4;
        private Label label11;
        private TabControl tabControl2;
        private TabPage tabPage1;
        private TrackBar trackBar6;
        private TrackBar trackBar4;
        private TrackBar trackBar2;
        private TrackBar trackBar1;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Button button3;
        private Label label21;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem loadScriptToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        public TabPage tabPage3;
    }
}