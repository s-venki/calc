namespace calc
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
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            add = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            label3 = new Label();
            textBox3 = new TextBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(190, 108);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(152, 43);
            textBox2.TabIndex = 2;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(60, 47);
            label1.Name = "label1";
            label1.Size = new Size(78, 28);
            label1.TabIndex = 2;
            label1.Text = "Value_1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(60, 123);
            label2.Name = "label2";
            label2.Size = new Size(78, 28);
            label2.TabIndex = 3;
            label2.Text = "Value_2";
            // 
            // add
            // 
            add.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add.Location = new Point(36, 196);
            add.Name = "add";
            add.Size = new Size(51, 37);
            add.TabIndex = 4;
            add.Text = "+";
            add.UseVisualStyleBackColor = true;
            add.Click += Add_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(131, 196);
            button2.Name = "button2";
            button2.Size = new Size(51, 37);
            button2.TabIndex = 5;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Sub_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(219, 196);
            button3.Name = "button3";
            button3.Size = new Size(51, 37);
            button3.TabIndex = 6;
            button3.Text = "*";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Mul_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(36, 256);
            button4.Name = "button4";
            button4.Size = new Size(51, 37);
            button4.TabIndex = 7;
            button4.Text = "/";
            button4.UseVisualStyleBackColor = true;
            button4.Click += Div_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(131, 256);
            button5.Name = "button5";
            button5.Size = new Size(51, 37);
            button5.TabIndex = 8;
            button5.Text = "%";
            button5.UseVisualStyleBackColor = true;
            button5.Click += Modulus_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.Location = new Point(219, 256);
            button6.Name = "button6";
            button6.Size = new Size(51, 37);
            button6.TabIndex = 9;
            button6.Text = "^";
            button6.UseVisualStyleBackColor = true;
            button6.Click += Power_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(60, 349);
            label3.Name = "label3";
            label3.Size = new Size(92, 38);
            label3.TabIndex = 10;
            label3.Text = "Result";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(172, 334);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(152, 43);
            textBox3.TabIndex = 11;
            textBox3.KeyPress += textBox3_KeyPress;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(190, 44);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(152, 43);
            textBox1.TabIndex = 12;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyPress += textBox1_KeyPress_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 432);
            Controls.Add(textBox1);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(add);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            MaximizeBox = false;
            Name = "Form1";
            Text = "calc";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Label label3;
        private TextBox textBox3;
        private Button add;
        private TextBox textBox1;
    }
}
