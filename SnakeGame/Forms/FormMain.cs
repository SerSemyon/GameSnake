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
    public partial class FormMain : Form
    {
        public static FormMain Instance;
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Instance = this;
            PlayingField.Renderer = playingField;
            SettingsHandler.ReadSettings();
            BoardOfRecords.ReadRecords();
            GameController.GameStart();
        }
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            SettingsHandler.SaveSettings();
            BoardOfRecords.SaveRecords();
        }

        private void FormMain_Activated(object sender, EventArgs e)
        {
            if (FormEndGame.Instance is null)
            {
                GameController.GameResume();
            }
        }
        private void FormMain_Deactivate(object sender, EventArgs e)
        {
            GameController.GamePause();
        }
        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                FormPause.ShowForm();
            }
        }
    }
}
