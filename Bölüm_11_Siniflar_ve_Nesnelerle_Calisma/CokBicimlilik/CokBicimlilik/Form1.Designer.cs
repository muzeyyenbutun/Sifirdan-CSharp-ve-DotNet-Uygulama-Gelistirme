namespace CokBicimlilik
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
            button4 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 62);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(385, 31);
            textBox1.TabIndex = 0;
            // 
            // button4
            // 
            button4.Location = new Point(12, 118);
            button4.Name = "button4";
            button4.Size = new Size(385, 34);
            button4.TabIndex = 1;
            button4.Text = "dolmakalem->Kalem";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(494, 59);
            button1.Name = "button1";
            button1.Size = new Size(134, 34);
            button1.TabIndex = 2;
            button1.Text = "Kalem";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button2_Click;
            // 
            // button2
            // 
            button2.Location = new Point(494, 99);
            button2.Name = "button2";
            button2.Size = new Size(134, 34);
            button2.TabIndex = 3;
            button2.Text = "DolmaKalem";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button3_Click;
            // 
            // button3
            // 
            button3.Location = new Point(494, 148);
            button3.Name = "button3";
            button3.Size = new Size(134, 34);
            button3.TabIndex = 4;
            button3.Text = "Doldur";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(662, 220);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button4;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
