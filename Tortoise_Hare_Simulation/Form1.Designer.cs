namespace Tortoise_Hare_Simulation
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnStartRace = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblScoreT = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblScoreH = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lboxCommentary = new System.Windows.Forms.ListBox();
            this.trckSpeed = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trckSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(16, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(700, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // btnStartRace
            // 
            this.btnStartRace.Location = new System.Drawing.Point(293, 118);
            this.btnStartRace.Name = "btnStartRace";
            this.btnStartRace.Size = new System.Drawing.Size(75, 23);
            this.btnStartRace.TabIndex = 1;
            this.btnStartRace.Text = "Start";
            this.btnStartRace.UseVisualStyleBackColor = true;
            this.btnStartRace.Click += new System.EventHandler(this.btnStartRace_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(374, 118);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tortoise:";
            // 
            // lblScoreT
            // 
            this.lblScoreT.AutoSize = true;
            this.lblScoreT.Location = new System.Drawing.Point(54, 21);
            this.lblScoreT.Name = "lblScoreT";
            this.lblScoreT.Size = new System.Drawing.Size(0, 13);
            this.lblScoreT.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Hare:";
            // 
            // lblScoreH
            // 
            this.lblScoreH.AutoSize = true;
            this.lblScoreH.Location = new System.Drawing.Point(42, 39);
            this.lblScoreH.Name = "lblScoreH";
            this.lblScoreH.Size = new System.Drawing.Size(0, 13);
            this.lblScoreH.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblScoreH);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblScoreT);
            this.groupBox1.Location = new System.Drawing.Point(479, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(108, 70);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Scoreboard";
            // 
            // lboxCommentary
            // 
            this.lboxCommentary.FormattingEnabled = true;
            this.lboxCommentary.Location = new System.Drawing.Point(16, 118);
            this.lboxCommentary.Name = "lboxCommentary";
            this.lboxCommentary.Size = new System.Drawing.Size(120, 69);
            this.lboxCommentary.TabIndex = 5;
            // 
            // trckSpeed
            // 
            this.trckSpeed.Location = new System.Drawing.Point(479, 212);
            this.trckSpeed.Minimum = 1;
            this.trckSpeed.Name = "trckSpeed";
            this.trckSpeed.Size = new System.Drawing.Size(104, 45);
            this.trckSpeed.TabIndex = 6;
            this.trckSpeed.Value = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(479, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Speed";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 269);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trckSpeed);
            this.Controls.Add(this.lboxCommentary);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStartRace);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Tortoise and Hare Race";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trckSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnStartRace;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblScoreT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblScoreH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lboxCommentary;
        private System.Windows.Forms.TrackBar trckSpeed;
        private System.Windows.Forms.Label label2;
    }
}

