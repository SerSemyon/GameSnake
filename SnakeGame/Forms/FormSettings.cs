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
        Color backColor;
        Color borderColor;
        public FormSettings()
        {
            InitializeComponent();
            backColor = SettingsHandler.backColor;
            borderColor = SettingsHandler.borderColor;
            checkBox.Checked = SettingsHandler.drawCellsBackground;
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
            SettingsHandler.borderColor = borderColor;
            SettingsHandler.backColor = backColor;
            SettingsHandler.drawCellsBackground = checkBox.Checked;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonBackColor_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = backColor;
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            backColor = colorDialog1.Color;
        }

        private void buttonBorderColor_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = borderColor;
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            borderColor = colorDialog1.Color;
        }

        private void buttonResource1_Click(object sender, EventArgs e)
        {

        }

        private void buttonResource2_Click(object sender, EventArgs e)
        {

        }
    }
}
