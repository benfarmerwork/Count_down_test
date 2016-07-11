namespace WindowsFormsApplication3
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_strings = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.TextMessage = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name : ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(114, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // btn_strings
            // 
            this.btn_strings.Location = new System.Drawing.Point(93, 140);
            this.btn_strings.Name = "btn_strings";
            this.btn_strings.Size = new System.Drawing.Size(75, 23);
            this.btn_strings.TabIndex = 2;
            this.btn_strings.Text = "Show string";
            this.btn_strings.UseVisualStyleBackColor = true;
            this.btn_strings.Click += new System.EventHandler(this.btn_strings_Click);
            // 
            // TextMessage
            // 
            this.TextMessage.AutoSize = true;
            this.TextMessage.Location = new System.Drawing.Point(87, 126);
            this.TextMessage.Name = "TextMessage";
            this.TextMessage.Size = new System.Drawing.Size(75, 13);
            this.TextMessage.TabIndex = 3;
            this.TextMessage.Text = "Message Area";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(114, 70);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.TextMessage);
            this.Controls.Add(this.btn_strings);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_strings;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Label TextMessage;
        private System.Windows.Forms.TextBox textBox2;
    }
}

