namespace SerialDataReader
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.portsBox = new System.Windows.Forms.ComboBox();
            this.baudTxt = new System.Windows.Forms.TextBox();
            this.stopTxt = new System.Windows.Forms.TextBox();
            this.pariTxt = new System.Windows.Forms.TextBox();
            this.dataTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 48);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(455, 246);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(392, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 22);
            this.button1.TabIndex = 2;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // portsBox
            // 
            this.portsBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.portsBox.FormattingEnabled = true;
            this.portsBox.Location = new System.Drawing.Point(12, 21);
            this.portsBox.Name = "portsBox";
            this.portsBox.Size = new System.Drawing.Size(111, 21);
            this.portsBox.TabIndex = 3;
            // 
            // baudTxt
            // 
            this.baudTxt.Location = new System.Drawing.Point(129, 21);
            this.baudTxt.Name = "baudTxt";
            this.baudTxt.Size = new System.Drawing.Size(63, 20);
            this.baudTxt.TabIndex = 4;
            this.baudTxt.Text = "115200";
            // 
            // stopTxt
            // 
            this.stopTxt.Location = new System.Drawing.Point(198, 21);
            this.stopTxt.Name = "stopTxt";
            this.stopTxt.Size = new System.Drawing.Size(52, 20);
            this.stopTxt.TabIndex = 5;
            this.stopTxt.Text = "One";
            // 
            // pariTxt
            // 
            this.pariTxt.Location = new System.Drawing.Point(256, 21);
            this.pariTxt.Name = "pariTxt";
            this.pariTxt.Size = new System.Drawing.Size(52, 20);
            this.pariTxt.TabIndex = 5;
            this.pariTxt.Text = "None";
            // 
            // dataTxt
            // 
            this.dataTxt.Location = new System.Drawing.Point(314, 21);
            this.dataTxt.Name = "dataTxt";
            this.dataTxt.Size = new System.Drawing.Size(72, 20);
            this.dataTxt.TabIndex = 6;
            this.dataTxt.Text = "8";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 306);
            this.Controls.Add(this.dataTxt);
            this.Controls.Add(this.pariTxt);
            this.Controls.Add(this.stopTxt);
            this.Controls.Add(this.baudTxt);
            this.Controls.Add(this.portsBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Serial Data Reader v 0.5.5";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox portsBox;
        private System.Windows.Forms.TextBox baudTxt;
        private System.Windows.Forms.TextBox stopTxt;
        private System.Windows.Forms.TextBox pariTxt;
        private System.Windows.Forms.TextBox dataTxt;
    }
}

