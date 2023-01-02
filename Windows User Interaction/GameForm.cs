using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Windows_User_Interaction
{
    public partial class GameForm : Form
    {
        private Button[,] m_ButtonMatrix;
        private Player m_FirstPlayer;
        private Player m_SecondPlayer;
        private Player m_CurrentTurnPlayer;
        private Player m_NotTurnPlayer;
        private Board m_Board;
        private Button m_ChosenButton = null;

        public GameForm(string i_FirstPlayerName, string i_SecondPlayerName, int i_BoardSize)
        {
            InitializeComponent();
            initializeGame(i_FirstPlayerName, i_SecondPlayerName, i_BoardSize);
            updateButtonsBoard();
        }

        private void initializeGame(string i_FirstPlayerName, string i_SecondPlayerName, int i_BoardSize)
        {
            m_FirstPlayer = new Player(i_FirstPlayerName, 'X');
            m_SecondPlayer = new Player(i_SecondPlayerName, 'O');
            LabelFirstPlayer.Text = $"{m_FirstPlayer.Name}: {m_FirstPlayer.Points}";
            LabelSecondPlayer.Text = $"{m_SecondPlayer.Name}: {m_SecondPlayer.Points}";
            m_Board = new Board(i_BoardSize);
            m_ButtonMatrix = new Button[m_Board.Length, m_Board.Length];

            for (int i = 0; i < m_Board.Length; i++)
            {
                for (int j = 0; j < m_Board.Length; j++)
                {
                    createButton(i, j);
                }
            }

            this.Size = new Size(60 + (40 * m_Board.Length), 120 + (40 * m_Board.Length));
            this.LabelFirstPlayer.Left = 100 - LabelFirstPlayer.Width;
            this.LabelSecondPlayer.Left = this.Size.Width - 80 - LabelSecondPlayer.Width;

            m_FirstPlayer.UpdatePlayer(m_Board);
            m_SecondPlayer.UpdatePlayer(m_Board);
            m_CurrentTurnPlayer = m_FirstPlayer;
            m_NotTurnPlayer = m_SecondPlayer;
        }

        private void createButton(int i_RowIndex, int i_ColumnIndex)
        {
            Button button = new Button();
            button.Size = new Size(40, 40);
            button.Top = 70 + (40 * i_RowIndex);
            button.Left = 20 + (40 * i_ColumnIndex);
            button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            button.TextAlign = ContentAlignment.MiddleCenter;
            button.Name = m_Board.GetCharLocationByIndexes(i_ColumnIndex, i_RowIndex);
            m_ButtonMatrix[i_RowIndex, i_ColumnIndex] = button;
            button.Click += new System.EventHandler(this.BoardButton_clicked);
            this.Controls.Add(button);

            if ((i_RowIndex % 2 == 0) && (i_ColumnIndex % 2 == 1) || (i_RowIndex % 2 == 1) && (i_ColumnIndex % 2 == 0))
            {
                button.BackColor = Color.White;
            }
            else
            {
                button.BackColor = Color.Gray;
                button.Enabled = false;
            }
        }

        private void updateButtonsBoard()
        {
            for (int i = 0; i < m_Board.Length; i++)
            {
                for (int j = 0; j < m_Board.Length; j++)
                {
                    if (m_Board.GetBoardMatrix()[i, j].ToString().Equals("X"))
                    {
                        m_ButtonMatrix[i, j].BackgroundImage = Properties.Resources.whiteReg;
                    }
                    else if (m_Board.GetBoardMatrix()[i, j].ToString().Equals("O"))
                    {
                        m_ButtonMatrix[i, j].BackgroundImage = Properties.Resources.blackReg;
                    }
                    else if (m_Board.GetBoardMatrix()[i, j].ToString().Equals("Z"))
                    {
                        m_ButtonMatrix[i, j].BackgroundImage = Properties.Resources.whiteKing;
                    }
                    else if (m_Board.GetBoardMatrix()[i, j].ToString().Equals("Q"))
                    {
                        m_ButtonMatrix[i, j].BackgroundImage = Properties.Resources.blackKing;
                    }
                    else
                    {
                        m_ButtonMatrix[i, j].BackgroundImage = null;
                    }

                    m_ButtonMatrix[i, j].BackgroundImageLayout = ImageLayout.Stretch;
                }
            }
        }

        private void BoardButton_clicked(object sender, EventArgs e)
        {
            if (m_ChosenButton == null)
            {
                chooseFirstButton(sender as Button);
            }
            else
            {
                chooseSecondButton(sender as Button);
            } 
        }

        private void chooseFirstButton(Button i_Button)
        {
            m_ChosenButton = i_Button;
            i_Button.BackColor = Color.PaleTurquoise;
        }

        private void chooseSecondButton(Button i_Button)
        {
            Player temporaryPlayer = null;
            bool gameEnds = false;

            if (i_Button.BackColor != Color.PaleTurquoise)
            {
                string move = bulidCurrentMove(i_Button);
                bool switchTurn = makeMove(move);
                updateButtonsBoard();
                
                if (switchTurn)
                {
                    gameEnds = checkIfGameEnds();
                    temporaryPlayer = m_CurrentTurnPlayer;
                    m_CurrentTurnPlayer = m_NotTurnPlayer;
                    m_NotTurnPlayer = temporaryPlayer;
                }
            }

            m_ChosenButton.BackColor = Color.White;
            m_ChosenButton = null;

            if (m_CurrentTurnPlayer.Name.Equals("[Computer]") && !gameEnds)
            {
                makeComputerMove();
                checkIfGameEnds();

                temporaryPlayer = m_CurrentTurnPlayer;
                m_CurrentTurnPlayer = m_NotTurnPlayer;
                m_NotTurnPlayer = temporaryPlayer;
            }
        }

        private string bulidCurrentMove(Button i_Button)
        {
            StringBuilder move = new StringBuilder();
            move.Append(m_ChosenButton.Name);
            move.Append('>');
            move.Append(i_Button.Name);
            return move.ToString();
        }
       
        private bool makeMove(string i_Move)
        {
            bool turnSuccess = false;

            if (m_CurrentTurnPlayer.EatingValidMoves.Count == 0)
            {
                if (m_CurrentTurnPlayer.NonEatingValidMoves.Contains(i_Move))
                {
                    m_Board.MakeMove(i_Move);
                    m_CurrentTurnPlayer.UpdatePlayer(m_Board);
                    m_NotTurnPlayer.UpdatePlayer(m_Board);
                    turnSuccess = true;
                }
                else
                {
                    MessageBox.Show("Invalid Move, please try again.");
                }
            }
            else
            {
                if (m_CurrentTurnPlayer.EatingValidMoves.Contains(i_Move))
                {
                    m_Board.MakeMove(i_Move);
                    m_CurrentTurnPlayer.UpdatePlayer(m_Board);
                    m_NotTurnPlayer.UpdatePlayer(m_Board);
                    bool v_TurnState = false;
                    m_CurrentTurnPlayer.ExtraEating(m_Board, i_Move.Substring(3, 2), ref v_TurnState);

                    if (!v_TurnState)
                    {
                        turnSuccess = true;
                    }
                }
                else if (m_CurrentTurnPlayer.NonEatingValidMoves.Contains(i_Move))
                {
                    MessageBox.Show("There is a better move to make (eating move)");
                }
                else
                {
                    MessageBox.Show("Invalid Move, please try again.");
                }
            }

            return turnSuccess;
        }

        private bool checkIfGameEnds()
        {
            bool gameEnd = false;

            if (m_CurrentTurnPlayer.NonEatingValidMoves.Count + m_CurrentTurnPlayer.EatingValidMoves.Count == 0 && m_NotTurnPlayer.NonEatingValidMoves.Count + m_NotTurnPlayer.EatingValidMoves.Count == 0)
            {
                DialogResult tieMessege = MessageBox.Show("Tie!\nAnother Round?", "Damka", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                gameEnd = checksIfAnotherRound(tieMessege);
            }
            else if (m_NotTurnPlayer.RegularPieces.Count + m_NotTurnPlayer.KingPieces.Count == 0 || m_NotTurnPlayer.NonEatingValidMoves.Count + m_NotTurnPlayer.EatingValidMoves.Count == 0)
            {
                DialogResult winMessege = MessageBox.Show($"{m_CurrentTurnPlayer.Name} Won!\nAnother Round?",
                                   "Damka", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                m_CurrentTurnPlayer.Points += Math.Abs(m_CurrentTurnPlayer.RegularPieces.Count + (4 * m_CurrentTurnPlayer.KingPieces.Count) - (m_NotTurnPlayer.RegularPieces.Count + (4 * m_NotTurnPlayer.KingPieces.Count)));
                gameEnd = checksIfAnotherRound(winMessege);
            }

            return gameEnd;
        }

        private bool checksIfAnotherRound(DialogResult i_Messege)
        {
            bool gameEnds = false;

            if (i_Messege == DialogResult.Yes)
            {
                startNewGame();
            }
            else
            {
                if (m_CurrentTurnPlayer.Points > m_NotTurnPlayer.Points)
                {
                    MessageBox.Show($"Game over,\n{m_CurrentTurnPlayer.Name} won by the score of {m_CurrentTurnPlayer.Points}-{m_NotTurnPlayer.Points}.");
                }
                else if (m_CurrentTurnPlayer.Points < m_NotTurnPlayer.Points)
                {
                    MessageBox.Show($"Game over,\n{m_NotTurnPlayer.Name} won by the score of {m_NotTurnPlayer.Points}-{m_CurrentTurnPlayer.Points}.");
                }
                else
                {
                    MessageBox.Show($"Game over,\nThe is a tie with the score of {m_NotTurnPlayer.Points}-{m_CurrentTurnPlayer.Points}.");
                }

                this.Close();
                gameEnds = true;
            }

            return gameEnds;
        }

        private void startNewGame()
        {
            m_Board = new Board(m_Board.Length);
            updateButtonsBoard();
            m_FirstPlayer.UpdatePlayer(m_Board);
            m_SecondPlayer.UpdatePlayer(m_Board);
            LabelFirstPlayer.Text = $"{m_FirstPlayer.Name}: {m_FirstPlayer.Points}";
            LabelSecondPlayer.Text = $"{m_SecondPlayer.Name}: {m_SecondPlayer.Points}";
            m_CurrentTurnPlayer = m_SecondPlayer;
            m_NotTurnPlayer = m_FirstPlayer;
        }

        private void makeComputerMove()
        {
            string computerMove = m_CurrentTurnPlayer.ComputerMove();
            bool switchTurn = makeMove(computerMove);
            updateButtonsBoard();

            if (!switchTurn)
            {
                makeComputerMove();
            }
        }
    }
}