using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_User_Interaction
{
    public class GameInitialize
    {
        public static void StartGame()
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog();

            if (settingsForm.DialogResult == DialogResult.OK)
            {
                Dictionary<string, string> gameSettingsData = settingsForm.SetGameDetails();

                GameForm damka = new GameForm(gameSettingsData["FirstPlayerName"], gameSettingsData["SecondPlayerName"], int.Parse(gameSettingsData["BoardSize"]));
                damka.ShowDialog();
            }
        }
    }
}
