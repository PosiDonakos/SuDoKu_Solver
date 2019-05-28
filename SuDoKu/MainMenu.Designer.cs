namespace SuDoKu
{
    partial class MainMenu
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnEz = new System.Windows.Forms.Button();
            this.BtnMed = new System.Windows.Forms.Button();
            this.BtnHard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAbout = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.Font = new System.Drawing.Font("Algerian", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(13, 13);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(259, 48);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "SuDoKu";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(216, 224);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(56, 25);
            this.BtnExit.TabIndex = 1;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnEz
            // 
            this.BtnEz.Location = new System.Drawing.Point(13, 119);
            this.BtnEz.Name = "BtnEz";
            this.BtnEz.Size = new System.Drawing.Size(75, 23);
            this.BtnEz.TabIndex = 2;
            this.BtnEz.Text = "Easy";
            this.BtnEz.UseVisualStyleBackColor = true;
            this.BtnEz.Click += new System.EventHandler(this.BtnEz_Click);
            // 
            // BtnMed
            // 
            this.BtnMed.Location = new System.Drawing.Point(106, 119);
            this.BtnMed.Name = "BtnMed";
            this.BtnMed.Size = new System.Drawing.Size(75, 23);
            this.BtnMed.TabIndex = 3;
            this.BtnMed.Text = "Medium";
            this.BtnMed.UseVisualStyleBackColor = true;
            this.BtnMed.Click += new System.EventHandler(this.BtnMed_Click);
            // 
            // BtnHard
            // 
            this.BtnHard.Location = new System.Drawing.Point(197, 119);
            this.BtnHard.Name = "BtnHard";
            this.BtnHard.Size = new System.Drawing.Size(75, 23);
            this.BtnHard.TabIndex = 4;
            this.BtnHard.Text = "Hard";
            this.BtnHard.UseVisualStyleBackColor = true;
            this.BtnHard.Click += new System.EventHandler(this.BtnHard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Chose Difficulty";
            // 
            // lblAbout
            // 
            this.lblAbout.Location = new System.Drawing.Point(10, 239);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(171, 13);
            this.lblAbout.TabIndex = 6;
            this.lblAbout.Text = "Made From George Vournas 2017";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblAbout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnHard);
            this.Controls.Add(this.BtnMed);
            this.Controls.Add(this.BtnEz);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.lbl1);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnEz;
        private System.Windows.Forms.Button BtnMed;
        private System.Windows.Forms.Button BtnHard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAbout;
    }
}