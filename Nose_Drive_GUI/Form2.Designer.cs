namespace Nose_Drive_GUI
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
            tabControl3 = new TabControl();
            tabPage5 = new TabPage();
            label20 = new Label();
            resetKeyBox = new TextBox();
            pauseKeyBox = new TextBox();
            label8 = new Label();
            label13 = new Label();
            timeUpDown = new NumericUpDown();
            label12 = new Label();
            tabControl3.SuspendLayout();
            tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)timeUpDown).BeginInit();
            SuspendLayout();
            // 
            // tabControl3
            // 
            tabControl3.Controls.Add(tabPage5);
            tabControl3.Location = new Point(25, 20);
            tabControl3.Margin = new Padding(2);
            tabControl3.Name = "tabControl3";
            tabControl3.SelectedIndex = 0;
            tabControl3.Size = new Size(484, 416);
            tabControl3.TabIndex = 40;
            // 
            // tabPage5
            // 
            tabPage5.BackColor = Color.FromArgb(44, 39, 53);
            tabPage5.Controls.Add(label20);
            tabPage5.Controls.Add(resetKeyBox);
            tabPage5.Controls.Add(pauseKeyBox);
            tabPage5.Controls.Add(label8);
            tabPage5.Controls.Add(label13);
            tabPage5.Controls.Add(timeUpDown);
            tabPage5.Controls.Add(label12);
            tabPage5.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tabPage5.ForeColor = SystemColors.ButtonFace;
            tabPage5.Location = new Point(4, 31);
            tabPage5.Margin = new Padding(2);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(2);
            tabPage5.Size = new Size(476, 381);
            tabPage5.TabIndex = 0;
            tabPage5.Text = "Settings";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label20.ForeColor = Color.White;
            label20.Location = new Point(131, 304);
            label20.Margin = new Padding(2, 0, 2, 0);
            label20.Name = "label20";
            label20.Size = new Size(77, 24);
            label20.TabIndex = 36;
            label20.Text = "seconds";
            // 
            // resetKeyBox
            // 
            resetKeyBox.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Pixel);
            resetKeyBox.Location = new Point(77, 171);
            resetKeyBox.Margin = new Padding(2);
            resetKeyBox.Name = "resetKeyBox";
            resetKeyBox.Size = new Size(40, 29);
            resetKeyBox.TabIndex = 44;
            resetKeyBox.Text = "N";
            resetKeyBox.TextChanged += resetKeyBox_TextChanged;
            // 
            // pauseKeyBox
            // 
            pauseKeyBox.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Pixel);
            pauseKeyBox.Location = new Point(77, 73);
            pauseKeyBox.Margin = new Padding(2);
            pauseKeyBox.Name = "pauseKeyBox";
            pauseKeyBox.Size = new Size(40, 29);
            pauseKeyBox.TabIndex = 43;
            pauseKeyBox.Text = "P";
            pauseKeyBox.TextChanged += pauseKeyBox_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Pixel);
            label8.ForeColor = Color.White;
            label8.Location = new Point(71, 34);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(115, 31);
            label8.TabIndex = 42;
            label8.Text = "Pause Key";
            label8.Click += label8_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Pixel);
            label13.ForeColor = Color.White;
            label13.Location = new Point(71, 255);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(176, 31);
            label13.TabIndex = 36;
            label13.Text = "Calibration time";
            // 
            // timeUpDown
            // 
            timeUpDown.Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Pixel);
            timeUpDown.Location = new Point(77, 299);
            timeUpDown.Margin = new Padding(1);
            timeUpDown.Name = "timeUpDown";
            timeUpDown.Size = new Size(46, 29);
            timeUpDown.TabIndex = 37;
            timeUpDown.Value = new decimal(new int[] { 5, 0, 0, 0 });
            timeUpDown.ValueChanged += timeUpDown_ValueChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Calibri", 24F, FontStyle.Regular, GraphicsUnit.Pixel);
            label12.ForeColor = Color.White;
            label12.Location = new Point(71, 132);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(200, 31);
            label12.TabIndex = 40;
            label12.Text = "Reset position Key";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(9F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 469);
            Controls.Add(tabControl3);
            Font = new Font("Calibri", 18F, FontStyle.Regular, GraphicsUnit.Pixel);
            Margin = new Padding(2);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            tabControl3.ResumeLayout(false);
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)timeUpDown).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl3;
        private TabPage tabPage5;
        private Label label20;
        private TextBox resetKeyBox;
        private TextBox pauseKeyBox;
        private Label label8;
        private Label label13;
        private NumericUpDown timeUpDown;
        private Label label12;
    }
}