﻿namespace Nose_Drive_GUI
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            previewButton = new Button();
            pictureBox1 = new PictureBox();
            label20 = new Label();
            resetKeyBox = new TextBox();
            pauseKeyBox = new TextBox();
            label8 = new Label();
            label13 = new Label();
            timeUpDown = new NumericUpDown();
            label12 = new Label();
            cameraNameLabel = new Label();
            camerasBox = new ComboBox();
            updateLibButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)timeUpDown).BeginInit();
            SuspendLayout();
            // 
            // previewButton
            // 
            previewButton.AccessibleName = "Start preview Button";
            previewButton.BackColor = Color.FromArgb(242, 101, 34);
            previewButton.Cursor = Cursors.Hand;
            previewButton.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            previewButton.ForeColor = Color.White;
            previewButton.Location = new Point(490, 233);
            previewButton.Margin = new Padding(4);
            previewButton.Name = "previewButton";
            previewButton.Size = new Size(185, 41);
            previewButton.TabIndex = 48;
            previewButton.Text = "start preview";
            previewButton.UseVisualStyleBackColor = false;
            previewButton.Click += preview_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.AccessibleName = "Camera preview";
            pictureBox1.BackColor = Color.Black;
            pictureBox1.Location = new Point(352, 84);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(440, 320);
            pictureBox1.TabIndex = 45;
            pictureBox1.TabStop = false;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Calibri", 12F);
            label20.ForeColor = Color.White;
            label20.Location = new Point(90, 282);
            label20.Margin = new Padding(2, 0, 2, 0);
            label20.Name = "label20";
            label20.Size = new Size(92, 29);
            label20.TabIndex = 36;
            label20.Text = "seconds";
            // 
            // resetKeyBox
            // 
            resetKeyBox.AccessibleDescription = "In this field a different keyboard letter can be assigned to reset the base position of the face tracking";
            resetKeyBox.AccessibleName = "Reset base position key input field";
            resetKeyBox.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Pixel);
            resetKeyBox.Location = new Point(36, 163);
            resetKeyBox.Margin = new Padding(2);
            resetKeyBox.Name = "resetKeyBox";
            resetKeyBox.Size = new Size(40, 29);
            resetKeyBox.TabIndex = 44;
            resetKeyBox.Text = "N";
            resetKeyBox.TextChanged += resetKeyBox_TextChanged;
            // 
            // pauseKeyBox
            // 
            pauseKeyBox.AccessibleDescription = "In this field a different keyboard letter can be assigned to pause and resume the face tracking";
            pauseKeyBox.AccessibleName = "Pause Key Input Field";
            pauseKeyBox.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Pixel);
            pauseKeyBox.Location = new Point(36, 65);
            pauseKeyBox.Margin = new Padding(2);
            pauseKeyBox.Name = "pauseKeyBox";
            pauseKeyBox.Size = new Size(40, 29);
            pauseKeyBox.TabIndex = 43;
            pauseKeyBox.Text = "P";
            pauseKeyBox.TextChanged += pauseKeyBox_TextChanged;
            // 
            // label8
            // 
            label8.AccessibleName = "Pause Key Label";
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Pixel);
            label8.ForeColor = Color.White;
            label8.Location = new Point(30, 26);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(110, 29);
            label8.TabIndex = 42;
            label8.Text = "Pause Key";
            label8.Click += label8_Click;
            // 
            // label13
            // 
            label13.AccessibleName = "Calibration Time Label";
            label13.AutoSize = true;
            label13.Font = new Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Pixel);
            label13.ForeColor = Color.White;
            label13.Location = new Point(30, 233);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(171, 29);
            label13.TabIndex = 36;
            label13.Text = "Calibration time";
            // 
            // timeUpDown
            // 
            timeUpDown.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Pixel);
            timeUpDown.Location = new Point(36, 277);
            timeUpDown.Margin = new Padding(1);
            timeUpDown.Name = "timeUpDown";
            timeUpDown.Size = new Size(46, 29);
            timeUpDown.TabIndex = 37;
            timeUpDown.Value = new decimal(new int[] { 5, 0, 0, 0 });
            timeUpDown.ValueChanged += timeUpDown_ValueChanged;
            // 
            // label12
            // 
            label12.AccessibleName = "Reset Position Key Label";
            label12.AutoSize = true;
            label12.Font = new Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Pixel);
            label12.ForeColor = Color.White;
            label12.Location = new Point(30, 124);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(192, 29);
            label12.TabIndex = 40;
            label12.Text = "Reset position Key";
            // 
            // cameraNameLabel
            // 
            cameraNameLabel.AutoSize = true;
            cameraNameLabel.Font = new Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Pixel);
            cameraNameLabel.ForeColor = Color.White;
            cameraNameLabel.Location = new Point(352, 52);
            cameraNameLabel.Margin = new Padding(2, 0, 2, 0);
            cameraNameLabel.Name = "cameraNameLabel";
            cameraNameLabel.Size = new Size(89, 29);
            cameraNameLabel.TabIndex = 52;
            cameraNameLabel.Text = "Camera";
            cameraNameLabel.Click += cameraNameLabel_Click;
            // 
            // camerasBox
            // 
            camerasBox.AccessibleName = "Choose camera dropdown";
            camerasBox.BackColor = Color.FromArgb(44, 39, 53);
            camerasBox.DropDownStyle = ComboBoxStyle.DropDownList;
            camerasBox.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Pixel);
            camerasBox.ForeColor = Color.White;
            camerasBox.FormattingEnabled = true;
            camerasBox.Location = new Point(548, 84);
            camerasBox.Margin = new Padding(2);
            camerasBox.Name = "camerasBox";
            camerasBox.Size = new Size(244, 30);
            camerasBox.TabIndex = 53;
            camerasBox.SelectedIndexChanged += camerasBox_SelectedIndexChanged;
            // 
            // updateLibButton
            // 
            updateLibButton.AccessibleName = "Start preview Button";
            updateLibButton.BackColor = Color.FromArgb(242, 101, 34);
            updateLibButton.Cursor = Cursors.Hand;
            updateLibButton.Font = new Font("Calibri", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            updateLibButton.ForeColor = Color.White;
            updateLibButton.Location = new Point(13, 395);
            updateLibButton.Margin = new Padding(4);
            updateLibButton.Name = "updateLibButton";
            updateLibButton.Size = new Size(186, 41);
            updateLibButton.TabIndex = 54;
            updateLibButton.Text = "Update library";
            updateLibButton.UseVisualStyleBackColor = false;
            updateLibButton.Visible = false;
            updateLibButton.Click += updateLibButton_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(9F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(44, 39, 53);
            ClientSize = new Size(821, 449);
            Controls.Add(updateLibButton);
            Controls.Add(previewButton);
            Controls.Add(camerasBox);
            Controls.Add(cameraNameLabel);
            Controls.Add(pictureBox1);
            Controls.Add(label8);
            Controls.Add(label20);
            Controls.Add(label12);
            Controls.Add(resetKeyBox);
            Controls.Add(timeUpDown);
            Controls.Add(pauseKeyBox);
            Controls.Add(label13);
            Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Pixel);
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "Form2";
            Text = "Form2";
            FormClosed += Form2_FormClosed;
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)timeUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label20;
        private TextBox resetKeyBox;
        private TextBox pauseKeyBox;
        private Label label8;
        private Label label13;
        private NumericUpDown timeUpDown;
        private Label label12;
        private PictureBox pictureBox1;
        private Button previewButton;
        private Label cameraNameLabel;
        private ComboBox camerasBox;
        private Button updateLibButton;
    }
}