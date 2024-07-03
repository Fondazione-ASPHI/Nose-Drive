namespace NoseDrive_Settings
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label6 = new Label();
            trackBar1 = new TrackBar();
            trackBar2 = new TrackBar();
            trackBar4 = new TrackBar();
            trackBar6 = new TrackBar();
            label8 = new Label();
            button1 = new Button();
            button2 = new Button();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            label4 = new Label();
            numericUpDown3 = new NumericUpDown();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 11);
            label1.Name = "label1";
            label1.Size = new Size(219, 25);
            label1.TabIndex = 1;
            label1.Text = "Nose horizontal sensibility";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 110);
            label2.Name = "label2";
            label2.Size = new Size(195, 25);
            label2.TabIndex = 3;
            label2.Text = "Nose vertical sensibility";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(343, 11);
            label3.Name = "label3";
            label3.Size = new Size(231, 25);
            label3.TabIndex = 5;
            label3.Text = "Mouth horizontal sensibility";
            label3.Click += label3_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(353, 110);
            label6.Name = "label6";
            label6.Size = new Size(170, 25);
            label6.TabIndex = 11;
            label6.Text = "Eyebrows sensibility";
            label6.Click += label6_Click;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(13, 39);
            trackBar1.Margin = new Padding(3, 4, 3, 4);
            trackBar1.Maximum = 50;
            trackBar1.Minimum = 1;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(214, 69);
            trackBar1.TabIndex = 12;
            trackBar1.Value = 15;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // trackBar2
            // 
            trackBar2.Location = new Point(353, 40);
            trackBar2.Margin = new Padding(3, 4, 3, 4);
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(214, 69);
            trackBar2.TabIndex = 13;
            trackBar2.Value = 10;
            trackBar2.Scroll += trackBar2_Scroll;
            // 
            // trackBar4
            // 
            trackBar4.Location = new Point(13, 152);
            trackBar4.Margin = new Padding(3, 4, 3, 4);
            trackBar4.Maximum = 50;
            trackBar4.Minimum = 1;
            trackBar4.Name = "trackBar4";
            trackBar4.Size = new Size(214, 69);
            trackBar4.TabIndex = 15;
            trackBar4.Value = 30;
            trackBar4.Scroll += trackBar4_Scroll;
            // 
            // trackBar6
            // 
            trackBar6.Location = new Point(346, 151);
            trackBar6.Margin = new Padding(3, 4, 3, 4);
            trackBar6.Maximum = 150;
            trackBar6.Minimum = 50;
            trackBar6.Name = "trackBar6";
            trackBar6.Size = new Size(214, 69);
            trackBar6.TabIndex = 17;
            trackBar6.Value = 100;
            trackBar6.Scroll += trackBar6_Scroll;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(478, 462);
            label8.Name = "label8";
            label8.Size = new Size(137, 25);
            label8.TabIndex = 20;
            label8.Text = "Calibration time";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(379, 561);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(116, 55);
            button1.TabIndex = 22;
            button1.Text = "SAVE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(134, 575);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(104, 35);
            button2.TabIndex = 23;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(527, 491);
            numericUpDown1.Margin = new Padding(3, 4, 3, 4);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(56, 31);
            numericUpDown1.TabIndex = 21;
            numericUpDown1.Value = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(511, 415);
            numericUpDown2.Margin = new Padding(3, 4, 3, 4);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(56, 31);
            numericUpDown2.TabIndex = 25;
            numericUpDown2.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(468, 388);
            label4.Name = "label4";
            label4.Size = new Size(137, 25);
            label4.TabIndex = 24;
            label4.Text = "Calibration time";
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(506, 341);
            numericUpDown3.Margin = new Padding(3, 4, 3, 4);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(56, 31);
            numericUpDown3.TabIndex = 27;
            numericUpDown3.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(457, 312);
            label7.Name = "label7";
            label7.Size = new Size(137, 25);
            label7.TabIndex = 26;
            label7.Text = "Calibration time";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1527, 854);
            Controls.Add(numericUpDown3);
            Controls.Add(label7);
            Controls.Add(numericUpDown2);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(numericUpDown1);
            Controls.Add(label8);
            Controls.Add(trackBar6);
            Controls.Add(trackBar4);
            Controls.Add(trackBar2);
            Controls.Add(trackBar1);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar4).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar6).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label6;
        private TrackBar trackBar1;
        private TrackBar trackBar2;
        private TrackBar trackBar4;
        private TrackBar trackBar6;
        private Label label8;
        private Button button1;
        private Button button2;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private Label label4;
        private NumericUpDown numericUpDown3;
        private Label label7;
    }
}