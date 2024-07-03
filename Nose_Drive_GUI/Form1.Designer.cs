namespace Nose_Drive_Starter
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
            Settings = new Button();
            Start = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // Script
            // 
            Script.Location = new Point(175, 108);
            Script.Margin = new Padding(4);
            Script.Name = "Script";
            Script.Size = new Size(211, 36);
            Script.TabIndex = 0;
            Script.Text = "Select Script";
            Script.UseVisualStyleBackColor = true;
            Script.Click += select_script;
            // 
            // Settings
            // 
            Settings.Location = new Point(140, 214);
            Settings.Margin = new Padding(4);
            Settings.Name = "Settings";
            Settings.Size = new Size(271, 36);
            Settings.TabIndex = 1;
            Settings.Text = "Select settings file";
            Settings.UseVisualStyleBackColor = true;
            Settings.Click += settings;
            // 
            // Start
            // 
            Start.Location = new Point(162, 379);
            Start.Margin = new Padding(4);
            Start.Name = "Start";
            Start.Size = new Size(238, 89);
            Start.TabIndex = 2;
            Start.Text = "START";
            Start.UseVisualStyleBackColor = true;
            Start.Click += start_button;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 11);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 3;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 562);
            Controls.Add(label1);
            Controls.Add(Start);
            Controls.Add(Settings);
            Controls.Add(Script);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Script;
        private Button Settings;
        private Button Start;
        private Label label1;
    }
}