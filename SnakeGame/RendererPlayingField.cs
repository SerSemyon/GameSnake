using System;

namespace SnakeGame;

/// <summary>
/// Визуализатор игрового поля.
/// </summary>
internal class RendererPlayingField : Panel
{
    int sizeOfCell;
    public int SizeOfCell
    {
        get { return sizeOfCell; }
    }
    public RendererPlayingField() : base()
    {
        Dock = DockStyle.Fill;
    }
    /// <summary>
    /// Отрисовывает поле.
    /// </summary>
    /// <param name="fieldWidth"> Количество клеток по горизонтали </param>
    /// <param name="fieldHeight"> Количество клеток по вертикали </param>
    public void DrawField(int fieldWidth, int fieldHeight)
    {
        Controls.Clear();
        {
            double newWidth = (double)Width / fieldWidth;
            double newHeight = (double)Height / fieldHeight;
            if (newHeight > newWidth) sizeOfCell = (int)newWidth;
            else sizeOfCell = (int)newHeight;
        }
        for (int i = 0; i <= fieldHeight; i++)
        {
            PictureBox pic = new PictureBox();
            pic.BackColor = Color.Black;
            pic.Location = new Point(0, sizeOfCell * i);
            pic.Size = new Size(fieldWidth * sizeOfCell, 1);
            Controls.Add(pic);
        }
        for (int i = 0; i <= fieldWidth; i++)
        {
            PictureBox pic = new PictureBox();
            pic.BackColor = Color.Black;
            pic.Location = new Point(sizeOfCell * i, 0);
            pic.Size = new Size(1, fieldHeight * sizeOfCell);
            Controls.Add(pic);
        }
    }
}
