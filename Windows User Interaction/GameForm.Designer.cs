using System;

namespace Windows_User_Interaction
{
    partial class GameForm
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
            this.LabelFirstPlayer = new System.Windows.Forms.Label();
            this.LabelSecondPlayer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelFirstPlayer
            // 
            this.LabelFirstPlayer.AutoSize = true;
            this.LabelFirstPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LabelFirstPlayer.Location = new System.Drawing.Point(113, 37);
            this.LabelFirstPlayer.Name = "LabelFirstPlayer";
            this.LabelFirstPlayer.Size = new System.Drawing.Size(57, 20);
            this.LabelFirstPlayer.TabIndex = 1;
            this.LabelFirstPlayer.Text = "label1";
            // 
            // LabelSecondPlayer
            // 
            this.LabelSecondPlayer.AutoSize = true;
            this.LabelSecondPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LabelSecondPlayer.Location = new System.Drawing.Point(372, 37);
            this.LabelSecondPlayer.Name = "LabelSecondPlayer";
            this.LabelSecondPlayer.Size = new System.Drawing.Size(57, 20);
            this.LabelSecondPlayer.TabIndex = 2;
            this.LabelSecondPlayer.Text = "label2";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 524);
            this.Controls.Add(this.LabelSecondPlayer);
            this.Controls.Add(this.LabelFirstPlayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Damka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelFirstPlayer;
        private System.Windows.Forms.Label LabelSecondPlayer;
    }
}