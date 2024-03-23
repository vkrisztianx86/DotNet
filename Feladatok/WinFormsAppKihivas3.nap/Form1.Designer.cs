namespace WinFormsAppKihivas3.nap
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
            labelIncreaseable = new Label();
            buttonIncrease = new Button();
            buttonDecrease = new Button();
            checkBox1 = new CheckBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            progressBar1 = new ProgressBar();
            SuspendLayout();
            // 
            // labelIncreaseable
            // 
            labelIncreaseable.BackColor = SystemColors.MenuHighlight;
            labelIncreaseable.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelIncreaseable.ImageAlign = ContentAlignment.TopLeft;
            labelIncreaseable.Location = new Point(2, 9);
            labelIncreaseable.Name = "labelIncreaseable";
            labelIncreaseable.Size = new Size(766, 91);
            labelIncreaseable.TabIndex = 0;
            labelIncreaseable.Text = "Counter";
            labelIncreaseable.TextAlign = ContentAlignment.MiddleCenter;
            labelIncreaseable.Click += label1_Click;
            // 
            // buttonIncrease
            // 
            buttonIncrease.Cursor = Cursors.PanNorth;
            buttonIncrease.Location = new Point(2, 103);
            buttonIncrease.Name = "buttonIncrease";
            buttonIncrease.Size = new Size(168, 50);
            buttonIncrease.TabIndex = 1;
            buttonIncrease.Text = "Increase";
            buttonIncrease.UseVisualStyleBackColor = true;
            buttonIncrease.Click += button1_Click;
            // 
            // buttonDecrease
            // 
            buttonDecrease.Cursor = Cursors.PanSouth;
            buttonDecrease.Location = new Point(176, 103);
            buttonDecrease.Name = "buttonDecrease";
            buttonDecrease.Size = new Size(168, 50);
            buttonDecrease.TabIndex = 2;
            buttonDecrease.Text = "Decrease";
            buttonDecrease.UseVisualStyleBackColor = true;
            buttonDecrease.Click += buttonDecrease_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(466, 233);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(101, 24);
            checkBox1.TabIndex = 3;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(466, 139);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(117, 24);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(466, 169);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(117, 24);
            radioButton2.TabIndex = 5;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(2, 375);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(773, 29);
            progressBar1.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 453);
            Controls.Add(progressBar1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(checkBox1);
            Controls.Add(buttonDecrease);
            Controls.Add(buttonIncrease);
            Controls.Add(labelIncreaseable);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PrimeFinder";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelIncreaseable;
        private Button buttonIncrease;
        private Button buttonDecrease;
        private CheckBox checkBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private ProgressBar progressBar1;
    }
}
