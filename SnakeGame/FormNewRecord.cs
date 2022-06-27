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
    public partial class FormNewRecord : Form
    {
        int recordID;
        int score;
        public FormNewRecord(int score)
        {
            InitializeComponent();
            this.score = score;
            recordID = BoardOfRecords.DetermineLocation(score);
            scoreList.ShowRecords(BoardOfRecords.records);
            scoreList.SelectedIndex = recordID;
            label.Text = "Вы набрали " + score + " и заняли " + (recordID + 1) + " место. Введите ваше имя:";
            scoreList.Items[recordID] = Convert.ToString(recordID + 1) + ". " + Convert.ToString(score) + " " + "Новая змейка";
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            BoardOfRecords.AddNewRecord(recordID, score, textBoxEnterName.Text);
            GameController.GameRestart();
            this.Close();
        }

        private void textBoxEnterName_TextChanged(object sender, EventArgs e)
        {
            scoreList.Items[recordID] = Convert.ToString(recordID + 1) + ". " + Convert.ToString(score) + " " + textBoxEnterName.Text;
        }
    }
}
