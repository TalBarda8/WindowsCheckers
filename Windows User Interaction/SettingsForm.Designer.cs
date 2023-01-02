using System;

namespace Windows_User_Interaction
{
    partial class SettingsForm
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
            this.LabelBoardSize = new System.Windows.Forms.Label();
            this.RadioButtonSizeSix = new System.Windows.Forms.RadioButton();
            this.RadioButtonSizeEight = new System.Windows.Forms.RadioButton();
            this.RadioButtonSizeTen = new System.Windows.Forms.RadioButton();
            this.LabelPlayers = new System.Windows.Forms.Label();
            this.LabelPlayer1 = new System.Windows.Forms.Label();
            this.CheckBoxPlayer2 = new System.Windows.Forms.CheckBox();
            this.TextBoxPlayer1 = new System.Windows.Forms.TextBox();
            this.TextBoxPlayer2 = new System.Windows.Forms.TextBox();
            this.ButtonDone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelBoardSize
            // 
            this.LabelBoardSize.AutoSize = true;
            this.LabelBoardSize.Location = new System.Drawing.Point(21, 18);
            this.LabelBoardSize.Name = "LabelBoardSize";
            this.LabelBoardSize.Size = new System.Drawing.Size(91, 20);
            this.LabelBoardSize.TabIndex = 0;
            this.LabelBoardSize.Text = "Board Size:";
            // 
            // RadioButtonSizeSix
            // 
            this.RadioButtonSizeSix.AutoSize = true;
            this.RadioButtonSizeSix.Location = new System.Drawing.Point(25, 52);
            this.RadioButtonSizeSix.Name = "RadioButtonSizeSix";
            this.RadioButtonSizeSix.Size = new System.Drawing.Size(67, 24);
            this.RadioButtonSizeSix.TabIndex = 1;
            this.RadioButtonSizeSix.TabStop = true;
            this.RadioButtonSizeSix.Text = "6 x 6";
            this.RadioButtonSizeSix.UseVisualStyleBackColor = false;
            // 
            // RadioButtonSizeEight
            // 
            this.RadioButtonSizeEight.AutoSize = true;
            this.RadioButtonSizeEight.Location = new System.Drawing.Point(107, 52);
            this.RadioButtonSizeEight.Name = "RadioButtonSizeEight";
            this.RadioButtonSizeEight.Size = new System.Drawing.Size(67, 24);
            this.RadioButtonSizeEight.TabIndex = 2;
            this.RadioButtonSizeEight.TabStop = true;
            this.RadioButtonSizeEight.Text = "8 x 8";
            this.RadioButtonSizeEight.UseVisualStyleBackColor = false;
            // 
            // RadioButtonSizeTen
            // 
            this.RadioButtonSizeTen.AutoSize = true;
            this.RadioButtonSizeTen.Location = new System.Drawing.Point(190, 52);
            this.RadioButtonSizeTen.Name = "RadioButtonSizeTen";
            this.RadioButtonSizeTen.Size = new System.Drawing.Size(85, 24);
            this.RadioButtonSizeTen.TabIndex = 3;
            this.RadioButtonSizeTen.TabStop = true;
            this.RadioButtonSizeTen.Text = "10 x 10";
            this.RadioButtonSizeTen.UseVisualStyleBackColor = false;
            // 
            // LabelPlayers
            // 
            this.LabelPlayers.AutoSize = true;
            this.LabelPlayers.Location = new System.Drawing.Point(21, 95);
            this.LabelPlayers.Name = "LabelPlayers";
            this.LabelPlayers.Size = new System.Drawing.Size(64, 20);
            this.LabelPlayers.TabIndex = 4;
            this.LabelPlayers.Text = "Players:";
            // 
            // LabelPlayer1
            // 
            this.LabelPlayer1.AutoSize = true;
            this.LabelPlayer1.Location = new System.Drawing.Point(41, 125);
            this.LabelPlayer1.Name = "LabelPlayer1";
            this.LabelPlayer1.Size = new System.Drawing.Size(69, 20);
            this.LabelPlayer1.TabIndex = 5;
            this.LabelPlayer1.Text = "Player 1:";
            // 
            // CheckBoxPlayer2
            // 
            this.CheckBoxPlayer2.AutoSize = true;
            this.CheckBoxPlayer2.Location = new System.Drawing.Point(45, 158);
            this.CheckBoxPlayer2.Name = "CheckBoxPlayer2";
            this.CheckBoxPlayer2.Size = new System.Drawing.Size(95, 24);
            this.CheckBoxPlayer2.TabIndex = 7;
            this.CheckBoxPlayer2.Text = "Player 2:";
            this.CheckBoxPlayer2.UseVisualStyleBackColor = true;
            this.CheckBoxPlayer2.CheckedChanged += new System.EventHandler(this.CheckBoxPlayer2_CheckedChanged);
            // 
            // TextBoxPlayer1
            // 
            this.TextBoxPlayer1.Location = new System.Drawing.Point(151, 125);
            this.TextBoxPlayer1.Name = "TextBoxPlayer1";
            this.TextBoxPlayer1.Size = new System.Drawing.Size(121, 26);
            this.TextBoxPlayer1.TabIndex = 6;
            // 
            // TextBoxPlayer2
            // 
            this.TextBoxPlayer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TextBoxPlayer2.Enabled = false;
            this.TextBoxPlayer2.Location = new System.Drawing.Point(151, 156);
            this.TextBoxPlayer2.Name = "TextBoxPlayer2";
            this.TextBoxPlayer2.Size = new System.Drawing.Size(121, 26);
            this.TextBoxPlayer2.TabIndex = 8;
            this.TextBoxPlayer2.Text = "[Computer]";
            // 
            // ButtonDone
            // 
            this.ButtonDone.Location = new System.Drawing.Point(179, 200);
            this.ButtonDone.Name = "ButtonDone";
            this.ButtonDone.Size = new System.Drawing.Size(99, 29);
            this.ButtonDone.TabIndex = 9;
            this.ButtonDone.Text = "Done";
            this.ButtonDone.UseVisualStyleBackColor = true;
            this.ButtonDone.Click += new System.EventHandler(this.ButtonDone_Click);
            // 
            // GameSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 242);
            this.Controls.Add(this.ButtonDone);
            this.Controls.Add(this.TextBoxPlayer2);
            this.Controls.Add(this.TextBoxPlayer1);
            this.Controls.Add(this.CheckBoxPlayer2);
            this.Controls.Add(this.LabelPlayer1);
            this.Controls.Add(this.LabelPlayers);
            this.Controls.Add(this.RadioButtonSizeTen);
            this.Controls.Add(this.RadioButtonSizeEight);
            this.Controls.Add(this.RadioButtonSizeSix);
            this.Controls.Add(this.LabelBoardSize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameSettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelBoardSize;
        private System.Windows.Forms.RadioButton RadioButtonSizeSix;
        private System.Windows.Forms.RadioButton RadioButtonSizeEight;
        private System.Windows.Forms.RadioButton RadioButtonSizeTen;
        private System.Windows.Forms.Label LabelPlayers;
        private System.Windows.Forms.Label LabelPlayer1;
        private System.Windows.Forms.CheckBox CheckBoxPlayer2;
        private System.Windows.Forms.TextBox TextBoxPlayer1;
        private System.Windows.Forms.TextBox TextBoxPlayer2;
        private System.Windows.Forms.Button ButtonDone;
    }
}