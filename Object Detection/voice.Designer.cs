
namespace Object_Detection
{
    partial class voice
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.voice_but2 = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Object_Detection.Properties.Resources.voicerecogntionpolice;
            this.pictureBox1.Location = new System.Drawing.Point(168, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(357, 168);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(168, 201);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(358, 85);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "~Log~";
            // 
            // voice_but2
            // 
            this.voice_but2.BackColor = System.Drawing.Color.Maroon;
            this.voice_but2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.voice_but2.Font = new System.Drawing.Font("Sitka Heading", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.voice_but2.Location = new System.Drawing.Point(281, 303);
            this.voice_but2.Name = "voice_but2";
            this.voice_but2.Size = new System.Drawing.Size(127, 38);
            this.voice_but2.TabIndex = 3;
            this.voice_but2.Text = "Enable Voice Control";
            this.voice_but2.UseVisualStyleBackColor = false;
            this.voice_but2.Click += new System.EventHandler(this.button2_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.InfoText;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.ForeColor = System.Drawing.Color.Yellow;
            this.richTextBox2.Location = new System.Drawing.Point(5, 69);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(139, 96);
            this.richTextBox2.TabIndex = 5;
            this.richTextBox2.Text = "𝓥𝓸𝓲𝓬𝓮 𝓒𝓸𝓷𝓽𝓻𝓸𝓵𝓼:\n\n𝙊𝙗𝙟𝙚𝙘𝙩 𝙙𝙚𝙩𝙚𝙘𝙩𝙤𝙧\n𝙍𝙚𝙖𝙡 𝙩𝙞𝙢𝙚\n𝙇𝙞" +
    "𝙘𝙚𝙣𝙨𝙚 𝙥𝙡𝙖𝙩𝙚 𝙙𝙚𝙩𝙚𝙘𝙩\n\nClear Log\n\n";
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Object_Detection.Properties.Resources.YouCut_20210910_221358759_1;
            this.pictureBox4.Location = new System.Drawing.Point(4, 212);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(140, 165);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AliceBlue;
            this.button1.Location = new System.Drawing.Point(565, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 38);
            this.button1.TabIndex = 8;
            this.button1.Text = "Object Detect";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // voice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(685, 389);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.voice_but2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(703, 430);
            this.MinimumSize = new System.Drawing.Size(701, 428);
            this.Name = "voice";
            this.Text = "Voice Recognition";
            this.Load += new System.EventHandler(this.voice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button voice_but2;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button button1;
    }
}