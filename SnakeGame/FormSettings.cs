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
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            textBoxHeight.Text = SettingsHandler.height.ToString();
            textBoxWidth.Text = SettingsHandler.width.ToString();
            trackBarSpeed.Value = (int)((500.0 - SettingsHandler.timerInterval) / 47.5);
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            SettingsHandler.width = int.Parse(textBoxWidth.Text);
            SettingsHandler.height = int.Parse(textBoxHeight.Text);
            SettingsHandler.timerInterval = Convert.ToInt32(500 - 47.5 * trackBarSpeed.Value);
            SettingsHandler.isFileSettingsChanged = true;
            SettingsHandler.hasNewSettings = true;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }
    }
}
