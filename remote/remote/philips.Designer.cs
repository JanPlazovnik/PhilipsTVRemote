namespace remote
{
    partial class philipsremote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(philipsremote));
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.ipadr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnVolumeDown = new System.Windows.Forms.Button();
            this.btnVolumeUp = new System.Windows.Forms.Button();
            this.btnRed = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnYellow = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnSource = new System.Windows.Forms.Button();
            this.errortxt = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(51, 72);
            this.trackBar1.Maximum = 60;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(123, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // ipadr
            // 
            this.ipadr.AllowDrop = true;
            this.ipadr.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ipadr.Location = new System.Drawing.Point(15, 29);
            this.ipadr.Name = "ipadr";
            this.ipadr.Size = new System.Drawing.Size(195, 20);
            this.ipadr.TabIndex = 1;
            this.ipadr.Text = "192.168.0.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter TV IP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Set volume:";
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.Location = new System.Drawing.Point(82, 123);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(61, 23);
            this.btnPause.TabIndex = 16;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Location = new System.Drawing.Point(149, 123);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(61, 23);
            this.btnPlay.TabIndex = 17;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Location = new System.Drawing.Point(15, 123);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(61, 23);
            this.btnStop.TabIndex = 18;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnVolumeDown
            // 
            this.btnVolumeDown.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnVolumeDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolumeDown.Location = new System.Drawing.Point(15, 73);
            this.btnVolumeDown.Name = "btnVolumeDown";
            this.btnVolumeDown.Size = new System.Drawing.Size(30, 30);
            this.btnVolumeDown.TabIndex = 19;
            this.btnVolumeDown.Text = "-";
            this.btnVolumeDown.UseVisualStyleBackColor = false;
            this.btnVolumeDown.Click += new System.EventHandler(this.btnVolumeDown_Click);
            // 
            // btnVolumeUp
            // 
            this.btnVolumeUp.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnVolumeUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolumeUp.Location = new System.Drawing.Point(180, 73);
            this.btnVolumeUp.Name = "btnVolumeUp";
            this.btnVolumeUp.Size = new System.Drawing.Size(30, 30);
            this.btnVolumeUp.TabIndex = 20;
            this.btnVolumeUp.Text = "+";
            this.btnVolumeUp.UseVisualStyleBackColor = false;
            this.btnVolumeUp.Click += new System.EventHandler(this.btnVolumeUp_Click);
            // 
            // btnRed
            // 
            this.btnRed.BackColor = System.Drawing.Color.Red;
            this.btnRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRed.Location = new System.Drawing.Point(16, 152);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(44, 23);
            this.btnRed.TabIndex = 21;
            this.btnRed.UseVisualStyleBackColor = false;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // btnGreen
            // 
            this.btnGreen.BackColor = System.Drawing.Color.Green;
            this.btnGreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGreen.Location = new System.Drawing.Point(66, 152);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(44, 23);
            this.btnGreen.TabIndex = 22;
            this.btnGreen.UseVisualStyleBackColor = false;
            this.btnGreen.Click += new System.EventHandler(this.btnGreen_Click);
            // 
            // btnYellow
            // 
            this.btnYellow.BackColor = System.Drawing.Color.Yellow;
            this.btnYellow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYellow.Location = new System.Drawing.Point(116, 152);
            this.btnYellow.Name = "btnYellow";
            this.btnYellow.Size = new System.Drawing.Size(44, 23);
            this.btnYellow.TabIndex = 23;
            this.btnYellow.UseVisualStyleBackColor = false;
            this.btnYellow.Click += new System.EventHandler(this.btnYellow_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.BackColor = System.Drawing.Color.Blue;
            this.btnBlue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlue.Location = new System.Drawing.Point(166, 152);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(44, 23);
            this.btnBlue.TabIndex = 24;
            this.btnBlue.UseVisualStyleBackColor = false;
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUp.Location = new System.Drawing.Point(93, 181);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(40, 40);
            this.btnUp.TabIndex = 25;
            this.btnUp.Text = "⌃";
            this.btnUp.UseVisualStyleBackColor = false;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Location = new System.Drawing.Point(93, 227);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(40, 40);
            this.btnOk.TabIndex = 26;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnDown
            // 
            this.btnDown.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDown.Location = new System.Drawing.Point(93, 273);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(40, 40);
            this.btnDown.TabIndex = 27;
            this.btnDown.Text = "˅";
            this.btnDown.UseVisualStyleBackColor = false;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnRight
            // 
            this.btnRight.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRight.Location = new System.Drawing.Point(139, 227);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(40, 40);
            this.btnRight.TabIndex = 28;
            this.btnRight.Text = "˃";
            this.btnRight.UseVisualStyleBackColor = false;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeft.Location = new System.Drawing.Point(47, 227);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(40, 40);
            this.btnLeft.TabIndex = 29;
            this.btnLeft.Text = "˂";
            this.btnLeft.UseVisualStyleBackColor = false;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnSource
            // 
            this.btnSource.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSource.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSource.Location = new System.Drawing.Point(15, 322);
            this.btnSource.Name = "btnSource";
            this.btnSource.Size = new System.Drawing.Size(61, 23);
            this.btnSource.TabIndex = 30;
            this.btnSource.Text = "Source";
            this.btnSource.UseVisualStyleBackColor = false;
            this.btnSource.Click += new System.EventHandler(this.btnSource_Click);
            // 
            // errortxt
            // 
            this.errortxt.AutoSize = true;
            this.errortxt.Location = new System.Drawing.Point(16, 193);
            this.errortxt.Name = "errortxt";
            this.errortxt.Size = new System.Drawing.Size(0, 13);
            this.errortxt.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(137, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Jan Plazovnik";
            // 
            // philipsremote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(226, 357);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.errortxt);
            this.Controls.Add(this.btnSource);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnBlue);
            this.Controls.Add(this.btnYellow);
            this.Controls.Add(this.btnGreen);
            this.Controls.Add(this.btnRed);
            this.Controls.Add(this.btnVolumeUp);
            this.Controls.Add(this.btnVolumeDown);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ipadr);
            this.Controls.Add(this.trackBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "philipsremote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Philips TV Remote";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TextBox ipadr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnVolumeDown;
        private System.Windows.Forms.Button btnVolumeUp;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button btnYellow;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnSource;
        private System.Windows.Forms.Label errortxt;
        private System.Windows.Forms.Label label3;
    }
}

