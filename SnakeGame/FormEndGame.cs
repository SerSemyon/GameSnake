using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class FormEndGame : Form
    {
        static FormEndGame? instance;
        public static FormEndGame Instance
        {
            get { return instance; }
        }
        private FormEndGame()
        {
            InitializeComponent();
        }
        public static void ShowForm(int score)
        {
            if (instance == null)
            {
                instance = new FormEndGame();
                instance.Show();
                instance.labelScore.Text = score.ToString();
            }
        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            GameController.GameRestart();
            instance = null;
            this.Close();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            FormMain.Instance.Close();
        }
    }
}
