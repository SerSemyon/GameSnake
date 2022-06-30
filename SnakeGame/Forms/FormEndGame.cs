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
        public static FormEndGame? Instance;
        public FormEndGame(int score)
        {
            InitializeComponent();
            labelScore.Text = score.ToString();
            Instance = this;
        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            GameController.GameRestart();
            Instance = null;
            this.Close();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            FormMain.Instance.Close();
        }

        private void FormEndGame_Load(object sender, EventArgs e)
        {

        }
    }
}
