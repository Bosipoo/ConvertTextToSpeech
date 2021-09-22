
namespace ConvertTextToSpeech
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
            this.cb_voicetype = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.speak = new System.Windows.Forms.Button();
            this.resume = new System.Windows.Forms.Button();
            this.pause = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select voice type";
            // 
            // cb_voicetype
            // 
            this.cb_voicetype.FormattingEnabled = true;
            this.cb_voicetype.Items.AddRange(new object[] {
            "NotSet",
            "Male",
            "Female",
            "Neutral"});
            this.cb_voicetype.Location = new System.Drawing.Point(241, 32);
            this.cb_voicetype.Name = "cb_voicetype";
            this.cb_voicetype.Size = new System.Drawing.Size(272, 28);
            this.cb_voicetype.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(44, 79);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(785, 328);
            this.textBox1.TabIndex = 2;
            // 
            // speak
            // 
            this.speak.Location = new System.Drawing.Point(138, 428);
            this.speak.Name = "speak";
            this.speak.Size = new System.Drawing.Size(116, 48);
            this.speak.TabIndex = 3;
            this.speak.Text = "Speak";
            this.speak.UseVisualStyleBackColor = true;
            this.speak.Click += new System.EventHandler(this.speak_Click);
            // 
            // resume
            // 
            this.resume.Location = new System.Drawing.Point(465, 428);
            this.resume.Name = "resume";
            this.resume.Size = new System.Drawing.Size(116, 48);
            this.resume.TabIndex = 4;
            this.resume.Text = "Resume";
            this.resume.UseVisualStyleBackColor = true;
            this.resume.Click += new System.EventHandler(this.resume_Click);
            // 
            // pause
            // 
            this.pause.Location = new System.Drawing.Point(302, 428);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(116, 48);
            this.pause.TabIndex = 5;
            this.pause.Text = "Pause";
            this.pause.UseVisualStyleBackColor = true;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(627, 428);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(116, 48);
            this.save.TabIndex = 6;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 514);
            this.Controls.Add(this.save);
            this.Controls.Add(this.pause);
            this.Controls.Add(this.resume);
            this.Controls.Add(this.speak);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cb_voicetype);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_voicetype;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button speak;
        private System.Windows.Forms.Button resume;
        private System.Windows.Forms.Button pause;
        private System.Windows.Forms.Button save;
    }
}

