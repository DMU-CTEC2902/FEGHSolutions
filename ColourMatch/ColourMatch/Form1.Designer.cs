namespace ColourMatch
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
            this.pictureBoxColour = new System.Windows.Forms.PictureBox();
            this.pictureBoxGuess = new System.Windows.Forms.PictureBox();
            this.labelRed = new System.Windows.Forms.Label();
            this.trackBarRed = new System.Windows.Forms.TrackBar();
            this.labelGreen = new System.Windows.Forms.Label();
            this.trackBarGreen = new System.Windows.Forms.TrackBar();
            this.labelBlue = new System.Windows.Forms.Label();
            this.trackBarBlue = new System.Windows.Forms.TrackBar();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelRedValue = new System.Windows.Forms.Label();
            this.labelGreenValue = new System.Windows.Forms.Label();
            this.labelBlueValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGuess)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxColour
            // 
            this.pictureBoxColour.Location = new System.Drawing.Point(13, 13);
            this.pictureBoxColour.Name = "pictureBoxColour";
            this.pictureBoxColour.Size = new System.Drawing.Size(775, 150);
            this.pictureBoxColour.TabIndex = 0;
            this.pictureBoxColour.TabStop = false;
            // 
            // pictureBoxGuess
            // 
            this.pictureBoxGuess.Location = new System.Drawing.Point(12, 169);
            this.pictureBoxGuess.Name = "pictureBoxGuess";
            this.pictureBoxGuess.Size = new System.Drawing.Size(775, 150);
            this.pictureBoxGuess.TabIndex = 0;
            this.pictureBoxGuess.TabStop = false;
            // 
            // labelRed
            // 
            this.labelRed.AutoSize = true;
            this.labelRed.Location = new System.Drawing.Point(21, 335);
            this.labelRed.Name = "labelRed";
            this.labelRed.Size = new System.Drawing.Size(27, 13);
            this.labelRed.TabIndex = 1;
            this.labelRed.Text = "Red";
            // 
            // trackBarRed
            // 
            this.trackBarRed.Location = new System.Drawing.Point(54, 325);
            this.trackBarRed.Maximum = 255;
            this.trackBarRed.Name = "trackBarRed";
            this.trackBarRed.Size = new System.Drawing.Size(650, 45);
            this.trackBarRed.TabIndex = 2;
            this.trackBarRed.TickFrequency = 0;
            this.trackBarRed.Scroll += new System.EventHandler(this.trackBarRed_Scroll);
            // 
            // labelGreen
            // 
            this.labelGreen.AutoSize = true;
            this.labelGreen.Location = new System.Drawing.Point(21, 370);
            this.labelGreen.Name = "labelGreen";
            this.labelGreen.Size = new System.Drawing.Size(36, 13);
            this.labelGreen.TabIndex = 1;
            this.labelGreen.Text = "Green";
            // 
            // trackBarGreen
            // 
            this.trackBarGreen.Location = new System.Drawing.Point(54, 360);
            this.trackBarGreen.Maximum = 255;
            this.trackBarGreen.Name = "trackBarGreen";
            this.trackBarGreen.Size = new System.Drawing.Size(650, 45);
            this.trackBarGreen.TabIndex = 2;
            this.trackBarGreen.TickFrequency = 0;
            this.trackBarGreen.Scroll += new System.EventHandler(this.trackBarGreen_Scroll);
            // 
            // labelBlue
            // 
            this.labelBlue.AutoSize = true;
            this.labelBlue.Location = new System.Drawing.Point(21, 405);
            this.labelBlue.Name = "labelBlue";
            this.labelBlue.Size = new System.Drawing.Size(28, 13);
            this.labelBlue.TabIndex = 1;
            this.labelBlue.Text = "Blue";
            // 
            // trackBarBlue
            // 
            this.trackBarBlue.Location = new System.Drawing.Point(54, 395);
            this.trackBarBlue.Maximum = 255;
            this.trackBarBlue.Name = "trackBarBlue";
            this.trackBarBlue.Size = new System.Drawing.Size(650, 45);
            this.trackBarBlue.TabIndex = 2;
            this.trackBarBlue.TickFrequency = 0;
            this.trackBarBlue.Scroll += new System.EventHandler(this.trackBarBlue_Scroll);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(364, 462);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 3;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(713, 462);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 4;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelRedValue
            // 
            this.labelRedValue.AutoSize = true;
            this.labelRedValue.Location = new System.Drawing.Point(710, 335);
            this.labelRedValue.Name = "labelRedValue";
            this.labelRedValue.Size = new System.Drawing.Size(13, 13);
            this.labelRedValue.TabIndex = 5;
            this.labelRedValue.Text = "0";
            this.labelRedValue.Click += new System.EventHandler(this.labelRedValue_Click);
            // 
            // labelGreenValue
            // 
            this.labelGreenValue.AutoSize = true;
            this.labelGreenValue.Location = new System.Drawing.Point(710, 370);
            this.labelGreenValue.Name = "labelGreenValue";
            this.labelGreenValue.Size = new System.Drawing.Size(13, 13);
            this.labelGreenValue.TabIndex = 5;
            this.labelGreenValue.Text = "0";
            this.labelGreenValue.Click += new System.EventHandler(this.labelRedValue_Click);
            // 
            // labelBlueValue
            // 
            this.labelBlueValue.AutoSize = true;
            this.labelBlueValue.Location = new System.Drawing.Point(710, 405);
            this.labelBlueValue.Name = "labelBlueValue";
            this.labelBlueValue.Size = new System.Drawing.Size(13, 13);
            this.labelBlueValue.TabIndex = 5;
            this.labelBlueValue.Text = "0";
            this.labelBlueValue.Click += new System.EventHandler(this.labelRedValue_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 497);
            this.Controls.Add(this.labelBlueValue);
            this.Controls.Add(this.labelGreenValue);
            this.Controls.Add(this.labelRedValue);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.trackBarBlue);
            this.Controls.Add(this.labelBlue);
            this.Controls.Add(this.trackBarGreen);
            this.Controls.Add(this.labelGreen);
            this.Controls.Add(this.trackBarRed);
            this.Controls.Add(this.labelRed);
            this.Controls.Add(this.pictureBoxGuess);
            this.Controls.Add(this.pictureBoxColour);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGuess)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxColour;
        private System.Windows.Forms.PictureBox pictureBoxGuess;
        private System.Windows.Forms.Label labelRed;
        private System.Windows.Forms.TrackBar trackBarRed;
        private System.Windows.Forms.Label labelGreen;
        private System.Windows.Forms.TrackBar trackBarGreen;
        private System.Windows.Forms.Label labelBlue;
        private System.Windows.Forms.TrackBar trackBarBlue;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelRedValue;
        private System.Windows.Forms.Label labelGreenValue;
        private System.Windows.Forms.Label labelBlueValue;
    }
}

