namespace WinFormsAppKihivasMegoldas4.nap
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
            panel1 = new Panel();
            trackBar1 = new TrackBar();
            trackBar2 = new TrackBar();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonShadow;
            panel1.Location = new Point(117, 49);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 300);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(105, 457);
            trackBar1.Maximum = 100;
            trackBar1.Minimum = 1;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(300, 56);
            trackBar1.TabIndex = 1;
            trackBar1.TickFrequency = 10;
            trackBar1.Value = 50;
            trackBar1.ValueChanged += trackBar1_ValueChanged;
            // 
            // trackBar2
            // 
            trackBar2.Location = new Point(105, 380);
            trackBar2.Maximum = 100;
            trackBar2.Minimum = 1;
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(300, 56);
            trackBar2.TabIndex = 2;
            trackBar2.TickFrequency = 10;
            trackBar2.Value = 50;
            trackBar2.ValueChanged += trackBar2_ValueChanged;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            numericUpDown1.Location = new Point(434, 457);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 3;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            numericUpDown2.Location = new Point(434, 380);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(150, 27);
            numericUpDown2.TabIndex = 4;
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(434, 179);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 5;
            label1.Text = "outline";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.Location = new Point(245, 9);
            label2.Name = "label2";
            label2.Size = new Size(19, 20);
            label2.TabIndex = 6;
            label2.Text = "B";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.Location = new Point(434, 240);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 7;
            label3.Text = "area";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label4.Location = new Point(29, 192);
            label4.Name = "label4";
            label4.Size = new Size(20, 20);
            label4.TabIndex = 8;
            label4.Text = "A";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label5.Location = new Point(58, 387);
            label5.Name = "label5";
            label5.Size = new Size(20, 20);
            label5.TabIndex = 9;
            label5.Text = "A";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label6.Location = new Point(59, 457);
            label6.Name = "label6";
            label6.Size = new Size(19, 20);
            label6.TabIndex = 10;
            label6.Text = "B";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Items.AddRange(new object[] { "Rectangle", "Ellipse" });
            comboBox1.Location = new Point(542, 179);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 11;
            comboBox1.Click += comboBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(965, 585);
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(trackBar2);
            Controls.Add(trackBar1);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TrackBar trackBar1;
        private TrackBar trackBar2;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox comboBox1;
    }
}
