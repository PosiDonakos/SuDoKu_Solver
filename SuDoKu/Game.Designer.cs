namespace SuDoKu
{
    partial class Game
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
            this.Pnl = new System.Windows.Forms.Panel();
            this.txtEdit = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblSt = new System.Windows.Forms.Label();
            this.btnSolve = new System.Windows.Forms.Button();
            this.btnNGame = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblTimeValue = new System.Windows.Forms.Label();
            this.Pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl
            // 
            this.Pnl.BackColor = System.Drawing.SystemColors.Window;
            this.Pnl.Controls.Add(this.txtEdit);
            this.Pnl.Location = new System.Drawing.Point(13, 13);
            this.Pnl.Name = "Pnl";
            this.Pnl.Size = new System.Drawing.Size(452, 432);
            this.Pnl.TabIndex = 0;
            this.Pnl.Paint += new System.Windows.Forms.PaintEventHandler(this.Pnl_Paint);
            this.Pnl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Pnl_MouseClick);
            // 
            // txtEdit
            // 
            this.txtEdit.BackColor = System.Drawing.Color.Gainsboro;
            this.txtEdit.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdit.Location = new System.Drawing.Point(3, 412);
            this.txtEdit.Name = "txtEdit";
            this.txtEdit.Size = new System.Drawing.Size(31, 29);
            this.txtEdit.TabIndex = 8;
            this.txtEdit.Visible = false;
            this.txtEdit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEdit_KeyPress);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(544, 418);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(65, 27);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Exit";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(474, 68);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(103, 13);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "Time Elapsed (sec) :";
            // 
            // lblSt
            // 
            this.lblSt.AutoSize = true;
            this.lblSt.Location = new System.Drawing.Point(474, 34);
            this.lblSt.Name = "lblSt";
            this.lblSt.Size = new System.Drawing.Size(43, 13);
            this.lblSt.TabIndex = 3;
            this.lblSt.Text = "Status :";
            // 
            // btnSolve
            // 
            this.btnSolve.Location = new System.Drawing.Point(477, 127);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(75, 23);
            this.btnSolve.TabIndex = 4;
            this.btnSolve.Text = "Solve";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // btnNGame
            // 
            this.btnNGame.Location = new System.Drawing.Point(477, 178);
            this.btnNGame.Name = "btnNGame";
            this.btnNGame.Size = new System.Drawing.Size(75, 23);
            this.btnNGame.TabIndex = 5;
            this.btnNGame.Text = "New Game";
            this.btnNGame.UseVisualStyleBackColor = true;
            this.btnNGame.Click += new System.EventHandler(this.btnNGame_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(523, 34);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(37, 13);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Status";
            // 
            // lblTimeValue
            // 
            this.lblTimeValue.AutoSize = true;
            this.lblTimeValue.Location = new System.Drawing.Point(583, 68);
            this.lblTimeValue.Name = "lblTimeValue";
            this.lblTimeValue.Size = new System.Drawing.Size(26, 13);
            this.lblTimeValue.TabIndex = 7;
            this.lblTimeValue.Text = "Sec";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 456);
            this.Controls.Add(this.lblTimeValue);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnNGame);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.lblSt);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.Pnl);
            this.Name = "Game";
            this.Text = "SuDoKu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Game_FormClosed);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Game_MouseClick);
            this.Pnl.ResumeLayout(false);
            this.Pnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblSt;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.Button btnNGame;
        public System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblTimeValue;
        private System.Windows.Forms.TextBox txtEdit;
    }
}

