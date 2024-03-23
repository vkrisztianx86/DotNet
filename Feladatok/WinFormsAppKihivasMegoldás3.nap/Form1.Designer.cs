namespace WinFormsAppKihivasMegoldás3.nap
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
            textBox1 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InactiveCaption;
            textBox1.Cursor = Cursors.Cross;
            textBox1.ForeColor = SystemColors.ControlText;
            textBox1.Location = new Point(16, 41);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Type a number to be checked for being prime or not";
            textBox1.Size = new Size(761, 27);
            textBox1.TabIndex = 0;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Gill Sans Ultra Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button1.Location = new Point(204, 74);
            button1.Name = "button1";
            button1.Size = new Size(379, 108);
            button1.TabIndex = 1;
            button1.Text = "CHECK";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Red;
            label1.Cursor = Cursors.No;
            label1.Font = new Font("Copperplate Gothic Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 9);
            label1.Name = "label1";
            label1.Size = new Size(761, 25);
            label1.TabIndex = 2;
            label1.Text = "Prime Checker Program";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(128, 255, 128);
            textBox2.Cursor = Cursors.AppStarting;
            textBox2.Font = new Font("Showcard Gothic", 9F, FontStyle.Underline, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(128, 241);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Result will appear here if type a number above and click check";
            textBox2.RightToLeft = RightToLeft.No;
            textBox2.Size = new Size(550, 197);
            textBox2.TabIndex = 3;
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.WordWrap = false;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 0, 192);
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private Label label1;
        private TextBox textBox2;
    }
}
