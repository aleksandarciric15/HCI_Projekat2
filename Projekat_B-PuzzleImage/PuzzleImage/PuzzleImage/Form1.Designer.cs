namespace PuzzleImage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.originalImage = new System.Windows.Forms.PictureBox();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.im1 = new System.Windows.Forms.PictureBox();
            this.im2 = new System.Windows.Forms.PictureBox();
            this.im3 = new System.Windows.Forms.PictureBox();
            this.im4 = new System.Windows.Forms.PictureBox();
            this.im5 = new System.Windows.Forms.PictureBox();
            this.im6 = new System.Windows.Forms.PictureBox();
            this.im7 = new System.Windows.Forms.PictureBox();
            this.im8 = new System.Windows.Forms.PictureBox();
            this.im9 = new System.Windows.Forms.PictureBox();
            this.btnQuit = new System.Windows.Forms.Button();
            this.lblMovesMade = new System.Windows.Forms.Label();
            this.lblTimeElapsed = new System.Windows.Forms.Label();
            this.timerElapsedTime = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.originalImage)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.im1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.im2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.im3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.im4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.im5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.im6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.im7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.im8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.im9)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(16, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(221, 204);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 0);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // originalImage
            // 
            this.originalImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.originalImage.Location = new System.Drawing.Point(858, 24);
            this.originalImage.Margin = new System.Windows.Forms.Padding(4);
            this.originalImage.Name = "originalImage";
            this.originalImage.Size = new System.Drawing.Size(635, 522);
            this.originalImage.TabIndex = 10;
            this.originalImage.TabStop = false;
            // 
            // btnShuffle
            // 
            this.btnShuffle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnShuffle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShuffle.Location = new System.Drawing.Point(858, 741);
            this.btnShuffle.Margin = new System.Windows.Forms.Padding(4);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(163, 66);
            this.btnShuffle.TabIndex = 13;
            this.btnShuffle.TabStop = false;
            this.btnShuffle.Text = "PROMIJESAJ";
            this.btnShuffle.UseVisualStyleBackColor = false;
            this.btnShuffle.Click += new System.EventHandler(this.Shuffle_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.Location = new System.Drawing.Point(1096, 741);
            this.btnPause.Margin = new System.Windows.Forms.Padding(4);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(165, 66);
            this.btnPause.TabIndex = 12;
            this.btnPause.TabStop = false;
            this.btnPause.Text = "PAUZIRAJ";
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.im1);
            this.groupBox1.Controls.Add(this.im2);
            this.groupBox1.Controls.Add(this.im3);
            this.groupBox1.Controls.Add(this.im4);
            this.groupBox1.Controls.Add(this.im5);
            this.groupBox1.Controls.Add(this.im6);
            this.groupBox1.Controls.Add(this.im7);
            this.groupBox1.Controls.Add(this.im8);
            this.groupBox1.Controls.Add(this.im9);
            this.groupBox1.Location = new System.Drawing.Point(1, 1);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(780, 676);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // im1
            // 
            this.im1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.im1.Location = new System.Drawing.Point(84, 23);
            this.im1.Margin = new System.Windows.Forms.Padding(4);
            this.im1.Name = "im1";
            this.im1.Size = new System.Drawing.Size(220, 203);
            this.im1.TabIndex = 1;
            this.im1.TabStop = false;
            this.im1.Click += new System.EventHandler(this.ClickPictureBoxEvent);
            // 
            // im2
            // 
            this.im2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.im2.Location = new System.Drawing.Point(313, 23);
            this.im2.Margin = new System.Windows.Forms.Padding(4);
            this.im2.Name = "im2";
            this.im2.Size = new System.Drawing.Size(220, 203);
            this.im2.TabIndex = 2;
            this.im2.TabStop = false;
            this.im2.Click += new System.EventHandler(this.ClickPictureBoxEvent);
            // 
            // im3
            // 
            this.im3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.im3.Location = new System.Drawing.Point(543, 23);
            this.im3.Margin = new System.Windows.Forms.Padding(4);
            this.im3.Name = "im3";
            this.im3.Size = new System.Drawing.Size(220, 203);
            this.im3.TabIndex = 3;
            this.im3.TabStop = false;
            this.im3.Click += new System.EventHandler(this.ClickPictureBoxEvent);
            // 
            // im4
            // 
            this.im4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.im4.Location = new System.Drawing.Point(84, 235);
            this.im4.Margin = new System.Windows.Forms.Padding(4);
            this.im4.Name = "im4";
            this.im4.Size = new System.Drawing.Size(220, 203);
            this.im4.TabIndex = 4;
            this.im4.TabStop = false;
            this.im4.Click += new System.EventHandler(this.ClickPictureBoxEvent);
            // 
            // im5
            // 
            this.im5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.im5.Location = new System.Drawing.Point(313, 235);
            this.im5.Margin = new System.Windows.Forms.Padding(4);
            this.im5.Name = "im5";
            this.im5.Size = new System.Drawing.Size(220, 203);
            this.im5.TabIndex = 5;
            this.im5.TabStop = false;
            this.im5.Click += new System.EventHandler(this.ClickPictureBoxEvent);
            // 
            // im6
            // 
            this.im6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.im6.Location = new System.Drawing.Point(543, 235);
            this.im6.Margin = new System.Windows.Forms.Padding(4);
            this.im6.Name = "im6";
            this.im6.Size = new System.Drawing.Size(220, 203);
            this.im6.TabIndex = 6;
            this.im6.TabStop = false;
            this.im6.Click += new System.EventHandler(this.ClickPictureBoxEvent);
            // 
            // im7
            // 
            this.im7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.im7.Location = new System.Drawing.Point(84, 447);
            this.im7.Margin = new System.Windows.Forms.Padding(4);
            this.im7.Name = "im7";
            this.im7.Size = new System.Drawing.Size(220, 203);
            this.im7.TabIndex = 7;
            this.im7.TabStop = false;
            this.im7.Click += new System.EventHandler(this.ClickPictureBoxEvent);
            // 
            // im8
            // 
            this.im8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.im8.Location = new System.Drawing.Point(313, 447);
            this.im8.Margin = new System.Windows.Forms.Padding(4);
            this.im8.Name = "im8";
            this.im8.Size = new System.Drawing.Size(220, 203);
            this.im8.TabIndex = 8;
            this.im8.TabStop = false;
            this.im8.Click += new System.EventHandler(this.ClickPictureBoxEvent);
            // 
            // im9
            // 
            this.im9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.im9.Location = new System.Drawing.Point(543, 447);
            this.im9.Margin = new System.Windows.Forms.Padding(4);
            this.im9.Name = "im9";
            this.im9.Size = new System.Drawing.Size(220, 203);
            this.im9.TabIndex = 9;
            this.im9.TabStop = false;
            this.im9.Click += new System.EventHandler(this.ClickPictureBoxEvent);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.Location = new System.Drawing.Point(1322, 741);
            this.btnQuit.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(171, 66);
            this.btnQuit.TabIndex = 16;
            this.btnQuit.Text = "KRAJ";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.Quit_Click);
            // 
            // lblMovesMade
            // 
            this.lblMovesMade.AutoSize = true;
            this.lblMovesMade.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovesMade.Location = new System.Drawing.Point(113, 755);
            this.lblMovesMade.Name = "lblMovesMade";
            this.lblMovesMade.Size = new System.Drawing.Size(155, 29);
            this.lblMovesMade.TabIndex = 17;
            this.lblMovesMade.Text = "Broj poteza: ";
            // 
            // lblTimeElapsed
            // 
            this.lblTimeElapsed.AutoSize = true;
            this.lblTimeElapsed.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeElapsed.Location = new System.Drawing.Point(981, 582);
            this.lblTimeElapsed.Name = "lblTimeElapsed";
            this.lblTimeElapsed.Size = new System.Drawing.Size(368, 95);
            this.lblTimeElapsed.TabIndex = 18;
            this.lblTimeElapsed.Text = "00:00:00";
            // 
            // timerElapsedTime
            // 
            this.timerElapsedTime.Enabled = true;
            this.timerElapsedTime.Interval = 999;
            this.timerElapsedTime.Tick += new System.EventHandler(this.timerElapsedTime_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1596, 855);
            this.Controls.Add(this.lblTimeElapsed);
            this.Controls.Add(this.lblMovesMade);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.originalImage);
            this.Controls.Add(this.btnShuffle);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Slika puzle";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.originalImage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.im1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.im2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.im3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.im4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.im5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.im6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.im7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.im8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.im9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox originalImage;
        private System.Windows.Forms.Button btnShuffle;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox im4;
        private System.Windows.Forms.PictureBox im1;
        private System.Windows.Forms.PictureBox im9;
        private System.Windows.Forms.PictureBox im3;
        private System.Windows.Forms.PictureBox im7;
        private System.Windows.Forms.PictureBox im5;
        private System.Windows.Forms.PictureBox im6;
        private System.Windows.Forms.PictureBox im8;
        private System.Windows.Forms.PictureBox im2;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblMovesMade;
        private System.Windows.Forms.Label lblTimeElapsed;
        private System.Windows.Forms.Timer timerElapsedTime;
    }
}

