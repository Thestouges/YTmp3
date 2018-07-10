namespace YTmp3
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
            this.URLTextBox = new System.Windows.Forms.TextBox();
            this.convert = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.FilePathText = new System.Windows.Forms.TextBox();
            this.FilePathButton = new System.Windows.Forms.Button();
            this.wavradio = new System.Windows.Forms.RadioButton();
            this.mp3radio = new System.Windows.Forms.RadioButton();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // URLTextBox
            // 
            this.URLTextBox.Location = new System.Drawing.Point(12, 44);
            this.URLTextBox.Name = "URLTextBox";
            this.URLTextBox.Size = new System.Drawing.Size(370, 20);
            this.URLTextBox.TabIndex = 0;
            this.URLTextBox.TextChanged += new System.EventHandler(this.URLTextBox_TextChanged);
            // 
            // convert
            // 
            this.convert.Location = new System.Drawing.Point(391, 98);
            this.convert.Name = "convert";
            this.convert.Size = new System.Drawing.Size(75, 23);
            this.convert.TabIndex = 1;
            this.convert.Text = "Convert";
            this.convert.UseVisualStyleBackColor = true;
            this.convert.Click += new System.EventHandler(this.convert_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 127);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(453, 289);
            this.textBox1.TabIndex = 2;
            // 
            // FilePathText
            // 
            this.FilePathText.Location = new System.Drawing.Point(12, 12);
            this.FilePathText.Name = "FilePathText";
            this.FilePathText.Size = new System.Drawing.Size(370, 20);
            this.FilePathText.TabIndex = 3;
            // 
            // FilePathButton
            // 
            this.FilePathButton.Location = new System.Drawing.Point(391, 10);
            this.FilePathButton.Name = "FilePathButton";
            this.FilePathButton.Size = new System.Drawing.Size(75, 23);
            this.FilePathButton.TabIndex = 4;
            this.FilePathButton.Text = "File Path";
            this.FilePathButton.UseVisualStyleBackColor = true;
            this.FilePathButton.Click += new System.EventHandler(this.FilePathButton_Click_1);
            // 
            // wavradio
            // 
            this.wavradio.AutoSize = true;
            this.wavradio.Location = new System.Drawing.Point(334, 101);
            this.wavradio.Name = "wavradio";
            this.wavradio.Size = new System.Drawing.Size(48, 17);
            this.wavradio.TabIndex = 6;
            this.wavradio.Text = ".wav";
            this.wavradio.UseVisualStyleBackColor = true;
            // 
            // mp3radio
            // 
            this.mp3radio.AutoSize = true;
            this.mp3radio.Checked = true;
            this.mp3radio.Location = new System.Drawing.Point(280, 101);
            this.mp3radio.Name = "mp3radio";
            this.mp3radio.Size = new System.Drawing.Size(48, 17);
            this.mp3radio.TabIndex = 7;
            this.mp3radio.TabStop = true;
            this.mp3radio.Text = ".mp3";
            this.mp3radio.UseVisualStyleBackColor = true;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(176, 72);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(289, 20);
            this.NameTextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "File Name (Default title if empty)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(387, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "Youtube Video";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 428);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.mp3radio);
            this.Controls.Add(this.wavradio);
            this.Controls.Add(this.FilePathButton);
            this.Controls.Add(this.FilePathText);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.convert);
            this.Controls.Add(this.URLTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Youtube Audio Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox URLTextBox;
        private System.Windows.Forms.Button convert;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox FilePathText;
        private System.Windows.Forms.Button FilePathButton;
        private System.Windows.Forms.RadioButton wavradio;
        private System.Windows.Forms.RadioButton mp3radio;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

