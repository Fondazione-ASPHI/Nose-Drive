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
            tabControl3.Location = new Point(22, 18);
            tabControl3.Margin = new Padding(2);
            tabControl3.Name = "tabControl3";
            tabControl3.SelectedIndex = 0;
            tabControl3.Size = new Size(430, 378);
            tabControl3.TabIndex = 40;
            // 
            // tabPage5
            // 
            tabPage5.BackColor = Color.FromArgb(44, 39, 53);
            tabPage5.Controls.Add(label20);
            tabPage5.Controls.Add(textBox2);
            tabPage5.Controls.Add(textBox1);
            tabPage5.Controls.Add(label8);
            tabPage5.Controls.Add(label13);
            tabPage5.Controls.Add(numericUpDown1);
            tabPage5.Controls.Add(label12);
            tabPage5.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point);
            tabPage5.ForeColor = SystemColors.ButtonFace;
            tabPage5.Location = new Point(4, 29);
            tabPage5.Margin = new Padding(2);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(2);
            tabPage5.Size = new Size(422, 345);
            tabPage5.TabIndex = 0;
            tabPage5.Text = "Settings";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label20.ForeColor = Color.White;
            label20.Location = new Point(117, 277);
            label20.Margin = new Padding(2, 0, 2, 0);
            label20.Name = "label20";
            label20.Size = new Size(77, 24);
            label20.TabIndex = 36;
            label20.Text = "seconds";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Calibri", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(68, 155);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(36, 40);
            textBox2.TabIndex = 44;
            textBox2.Text = "N";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Calibri", 16F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(68, 66);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(36, 40);
            textBox1.TabIndex = 43;
            textBox1.Text = "P";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(63, 31);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(124, 33);
            label8.TabIndex = 42;
            label8.Text = "Pause Key";
            label8.Click += label8_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Calibri", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label13.ForeColor = Color.White;
            label13.Location = new Point(63, 232);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(188, 33);
            label13.TabIndex = 36;
            label13.Text = "Calibration time";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Calibri", 16F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown1.Location = new Point(68, 268);
            numericUpDown1.Margin = new Padding(2, 3, 2, 3);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(45, 40);
            numericUpDown1.TabIndex = 37;
            numericUpDown1.Value = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Calibri", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.White;
            label12.Location = new Point(63, 120);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(215, 33);
            label12.TabIndex = 40;
            label12.Text = "Reset position Key";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 426);
            Controls.Add(tabControl3);
            Margin = new Padding(2);
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