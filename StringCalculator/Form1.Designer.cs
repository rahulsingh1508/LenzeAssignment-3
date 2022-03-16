namespace StringCalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.String1TextBox = new System.Windows.Forms.TextBox();
            this.String2TextBox = new System.Windows.Forms.TextBox();
            this.ConcentationTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EqualButton = new System.Windows.Forms.Button();
            this.PalindromeButton = new System.Windows.Forms.Button();
            this.ReverseButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "String Calculator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "String 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "String 2";
            // 
            // String1TextBox
            // 
            this.String1TextBox.Location = new System.Drawing.Point(245, 82);
            this.String1TextBox.Name = "String1TextBox";
            this.String1TextBox.Size = new System.Drawing.Size(134, 27);
            this.String1TextBox.TabIndex = 3;
            // 
            // String2TextBox
            // 
            this.String2TextBox.Location = new System.Drawing.Point(245, 147);
            this.String2TextBox.Name = "String2TextBox";
            this.String2TextBox.Size = new System.Drawing.Size(134, 27);
            this.String2TextBox.TabIndex = 4;
            // 
            // ConcentationTextBox
            // 
            this.ConcentationTextBox.Location = new System.Drawing.Point(245, 214);
            this.ConcentationTextBox.Name = "ConcentationTextBox";
            this.ConcentationTextBox.ReadOnly = true;
            this.ConcentationTextBox.Size = new System.Drawing.Size(134, 27);
            this.ConcentationTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Concatenation Result";
            // 
            // EqualButton
            // 
            this.EqualButton.Location = new System.Drawing.Point(68, 313);
            this.EqualButton.Name = "EqualButton";
            this.EqualButton.Size = new System.Drawing.Size(94, 29);
            this.EqualButton.TabIndex = 7;
            this.EqualButton.Text = "Equals ?";
            this.EqualButton.UseVisualStyleBackColor = true;
            this.EqualButton.Click += new System.EventHandler(this.EqualButton_Click);
            // 
            // PalindromeButton
            // 
            this.PalindromeButton.Location = new System.Drawing.Point(216, 313);
            this.PalindromeButton.Name = "PalindromeButton";
            this.PalindromeButton.Size = new System.Drawing.Size(94, 29);
            this.PalindromeButton.TabIndex = 8;
            this.PalindromeButton.Text = "Palindrome ?";
            this.PalindromeButton.UseVisualStyleBackColor = true;
            this.PalindromeButton.Click += new System.EventHandler(this.PalindromeButton_Click);
            // 
            // ReverseButton
            // 
            this.ReverseButton.Location = new System.Drawing.Point(366, 313);
            this.ReverseButton.Name = "ReverseButton";
            this.ReverseButton.Size = new System.Drawing.Size(94, 29);
            this.ReverseButton.TabIndex = 9;
            this.ReverseButton.Text = "Reverse";
            this.ReverseButton.UseVisualStyleBackColor = true;
            this.ReverseButton.Click += new System.EventHandler(this.ReverseButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 10;
            this.button1.Text = "Concatenate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(285, 402);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(94, 29);
            this.ClearButton.TabIndex = 11;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 571);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ReverseButton);
            this.Controls.Add(this.PalindromeButton);
            this.Controls.Add(this.EqualButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ConcentationTextBox);
            this.Controls.Add(this.String2TextBox);
            this.Controls.Add(this.String1TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox String1TextBox;
        private TextBox String2TextBox;
        private TextBox ConcentationTextBox;
        private Label label4;
        private Button EqualButton;
        private Button PalindromeButton;
        private Button ReverseButton;
        private Button button1;
        private Button ClearButton;
    }
}