using System;

namespace SnakeGame;

/// <summary>
/// Визуализатор игрового поля.
/// </summary>
internal class RendererPlayingField : Panel
{
    static bool drawCellsBackground = true;
    static Color backColor = Color.Aquamarine;
    static Color borderColor = Color.Black;
    int sizeOfCell;
    public PictureBox backgroundPicture;
    public int SizeOfCell
    {
        get { return sizeOfCell; }
    }
    public static void SetSettings(bool DrawCellsBackground, Color BackColor, Color BorderColor)
    {
        drawCellsBackground = DrawCellsBackground;
        backColor = BackColor;
        borderColor = BorderColor;
    }
    public RendererPlayingField() : base()
    {
        Dock = DockStyle.Fill;
        backgroundPicture = new PictureBox();
        //backgroundPicture.SizeMode = PictureBoxSizeMode.Zoom;
        backgroundPicture.Dock = DockStyle.Fill;
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
        DrawBackground(fieldWidth, fieldHeight);
    }
    public void DrawBackground(int fieldWidth, int fieldHeight)
    {
        Bitmap background = new Bitmap(fieldWidth*sizeOfCell, fieldHeight* sizeOfCell);
        for (int i = 0; i< background.Width; i++)
        {
            background.SetPixel(i, 0, borderColor);
            background.SetPixel(i, background.Height - 1, borderColor);
        }
        for (int i = 0; i < background.Height; i++)
        {
            background.SetPixel(0, i, borderColor);
            background.SetPixel(background.Width - 1, i, borderColor);
        }
        if (drawCellsBackground)
        {
            for (int y = 1; y <= fieldHeight - 1; y++)
            {
                for (int x = 1; x< background.Width-1; x++)
                {
                    background.SetPixel(x, y * sizeOfCell, backColor);
                }
            }
            for (int x = 1; x <= fieldWidth - 1; x++)
            {
                for (int y = 1; y< background.Height-1; y++)
                {
                    background.SetPixel(x * sizeOfCell, y, backColor);
                }
            }
        }
        backgroundPicture.Image = background;
        Controls.Add(backgroundPicture);
    }
}
