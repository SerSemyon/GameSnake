using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame;

public partial class FormPause : Form
{
    static FormPause? instance;
    public static FormPause Instance
    {
        get { return instance; }
    }
    private FormPause()
    {
        InitializeComponent();
    }
    public static void ShowForm()
    {
        if (instance is null)
        {
            instance = new FormPause();
            instance.ShowDialog();
        }
    }

    private void buttonResume_Click(object sender, EventArgs e)
    {
        GameController.GameResume();
        instance.Close();
    }

    private void buttonNewGame_Click(object sender, EventArgs e)
    {
        GameController.GameRestart();
        instance.Close();
    }

    private void buttonRecords_Click(object sender, EventArgs e)
    {
        FormRecords formRecords = new FormRecords();
        formRecords.ShowDialog();
    }

    private void buttonSettings_Click(object sender, EventArgs e)
    {

    }

    private void FormPause_FormClosed(object sender, FormClosedEventArgs e)
    {
        instance = null;
    }

    private void buttonExit_Click(object sender, EventArgs e)
    {
        FormMain.Instance.Close();
    }
}
