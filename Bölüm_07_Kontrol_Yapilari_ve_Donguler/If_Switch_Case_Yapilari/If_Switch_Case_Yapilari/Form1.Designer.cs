namespace If_Switch_Case_Yapilari
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
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            textBox4 = new TextBox();
            button4 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(37, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(258, 31);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(322, 50);
            button1.Name = "button1";
            button1.Size = new Size(175, 31);
            button1.TabIndex = 1;
            button1.Text = "İşaret Ne?";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(37, 122);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(258, 31);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(322, 122);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(256, 31);
            textBox3.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(616, 122);
            button2.Name = "button2";
            button2.Size = new Size(165, 34);
            button2.TabIndex = 4;
            button2.Text = "Hangisi Büyük";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(37, 198);
            button3.Name = "button3";
            button3.Size = new Size(541, 34);
            button3.TabIndex = 5;
            button3.Text = "Üç sayının hangisi büyük";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(37, 290);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(303, 31);
            textBox4.TabIndex = 6;
            // 
            // button4
            // 
            button4.Location = new Point(37, 360);
            button4.Name = "button4";
            button4.Size = new Size(433, 34);
            button4.TabIndex = 7;
            button4.Text = "Hangi Gün?";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(805, 450);
            Controls.Add(button4);
            Controls.Add(textBox4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button2;
        private Button button3;
        private TextBox textBox4;
        private Button button4;
    }
}
