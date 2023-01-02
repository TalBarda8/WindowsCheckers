using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_User_Interaction
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void ButtonDone_Click(object sender, EventArgs e)
        {
           if (TextBoxPlayer1.Text.Equals(String.Empty) || TextBoxPlayer2.Text.Equals(String.Empty) || (TextBoxPlayer2.Text.Equals("[Computer]") && CheckBoxPlayer2.Checked) 
                || TextBoxPlayer1.Text.Equals(TextBoxPlayer2.Text))
           {
                if (TextBoxPlayer2.Text.Equals("[Computer]") && CheckBoxPlayer2.Checked)
                {
                    MessageBox.Show("Player can't be name \"[Computer]\".\nPlease choose another name");
                }
                else
                {
                    MessageBox.Show("Not all names were fill correctly.");
                }
                
                return;
           }
           
           this.DialogResult = DialogResult.OK;
           this.Close();
        }

        private void CheckBoxPlayer2_CheckedChanged(object sender, EventArgs e)
        {
            if (this.CheckBoxPlayer2.Checked)
            {
                this.TextBoxPlayer2.Enabled = true;
                this.TextBoxPlayer2.BackColor = Color.White;
                this.TextBoxPlayer2.Text = string.Empty;
            } 
            else
            {
                this.TextBoxPlayer2.Enabled = false;
                this.TextBoxPlayer2.BackColor = Color.FromArgb(224, 224, 224);
                this.TextBoxPlayer2.Text = "[Computer]";
            }
        }

        public Dictionary<string, string> SetGameDetails ()
        {
            Dictionary<string, string> gameDetails = new Dictionary<string, string> ();

            if (this.RadioButtonSizeSix.Checked)
            {
                gameDetails["BoardSize"] = "6";
            }
            else if (this.RadioButtonSizeEight.Checked)
            {
                gameDetails["BoardSize"] = "8";
            }
            else
            {
                gameDetails["BoardSize"] = "10";
            }
            
            gameDetails["FirstPlayerName"] = this.TextBoxPlayer1.Text;
            gameDetails["SecondPlayerName"] = this.TextBoxPlayer2.Text;

            return gameDetails;
        }
    }
}
