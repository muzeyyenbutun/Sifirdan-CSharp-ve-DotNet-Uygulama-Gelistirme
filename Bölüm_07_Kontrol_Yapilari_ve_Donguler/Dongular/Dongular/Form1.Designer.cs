namespace Dongular
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(216, 66);
            button1.Name = "button1";
            button1.Size = new Size(151, 30);
            button1.TabIndex = 0;
            button1.Text = "button2";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Test;
            // 
            // button2
            // 
            button2.Location = new Point(37, 66);
            button2.Name = "button2";
            button2.Size = new Size(146, 34);
            button2.TabIndex = 1;
            button2.Text = "for döngüsü";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(216, 116);
            button3.Name = "button3";
            button3.Size = new Size(151, 34);
            button3.TabIndex = 2;
            button3.Text = "while";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(216, 171);
            button4.Name = "button4";
            button4.Size = new Size(151, 34);
            button4.TabIndex = 3;
            button4.Text = "while";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(394, 76);
            button5.Name = "button5";
            button5.Size = new Size(112, 34);
            button5.TabIndex = 4;
            button5.Text = "do";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(37, 171);
            button6.Name = "button6";
            button6.Size = new Size(146, 34);
            button6.TabIndex = 5;
            button6.Text = "for";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(37, 116);
            button7.Name = "button7";
            button7.Size = new Size(146, 34);
            button7.TabIndex = 6;
            button7.Text = "for";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(624, 160);
            button8.Name = "button8";
            button8.Size = new Size(112, 34);
            button8.TabIndex = 7;
            button8.Text = "Hangi Not";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(442, 160);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(394, 166);
            label1.Name = "label1";
            label1.Size = new Size(42, 25);
            label1.TabIndex = 9;
            label1.Text = "Not";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 302);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private TextBox textBox1;
        private Label label1;
    }
}
