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
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label8 = new Label();
            label13 = new Label();
            numericUpDown1 = new NumericUpDown();
            label12 = new Label();
            tabControl3.SuspendLayout();
            tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // tabControl3
            // 
            tabControl3.Controls.Add(tabPage5);
            tabControl3.Location = new Point(27, 22);
            tabControl3.Name = "tabControl3";
            tabControl3.SelectedIndex = 0;
            tabControl3.Size = new Size(538, 472);
            tabControl3.TabIndex = 40;
            // 
            // tabPage5
            // 
            tabPage5.BackColor = Color.Black;
            tabPage5.Controls.Add(label20);
            tabPage5.Controls.Add(textBox2);
            tabPage5.Controls.Add(textBox1);
            tabPage5.Controls.Add(label8);
            tabPage5.Controls.Add(label13);
            tabPage5.Controls.Add(numericUpDown1);
            tabPage5.Controls.Add(label12);
            tabPage5.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tabPage5.ForeColor = SystemColors.ButtonFace;
            tabPage5.Location = new Point(4, 34);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(530, 434);
            tabPage5.TabIndex = 0;
            tabPage5.Text = "Settings";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label20.ForeColor = SystemColors.ButtonFace;
            label20.Location = new Point(150, 321);
            label20.Name = "label20";
            label20.Size = new Size(92, 29);
            label20.TabIndex = 36;
            label20.Text = "seconds";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Calibri", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(85, 193);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(44, 47);
            textBox2.TabIndex = 44;
            textBox2.Text = "N";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Calibri", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(85, 98);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(44, 47);
            textBox1.TabIndex = 43;
            textBox1.Text = "P";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(79, 59);
            label8.Name = "label8";
            label8.Size = new Size(147, 39);
            label8.TabIndex = 42;
            label8.Text = "Pause Key";
            label8.Click += label8_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Calibri", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(79, 274);
            label13.Name = "label13";
            label13.Size = new Size(224, 39);
            label13.TabIndex = 36;
            label13.Text = "Calibration time";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Calibri", 16F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown1.Location = new Point(85, 300);
            numericUpDown1.Margin = new Padding(3, 4, 3, 4);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(56, 47);
            numericUpDown1.TabIndex = 37;
            numericUpDown1.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Calibri", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(79, 154);
            label12.Name = "label12";
            label12.Size = new Size(255, 39);
            label12.TabIndex = 40;
            label12.Text = "Reset position Key";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 533);
            Controls.Add(tabControl3);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            tabControl3.ResumeLayout(false);
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl3;
        private TabPage tabPage5;
        private Label label20;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label8;
        private Label label13;
        private NumericUpDown numericUpDown1;
        private Label label12;
    }
}