using System.IO;
namespace SnakeGame;

internal static class SettingsHandler
{
    public static int width;
    public static int height;
    public static int timerInterval;
    public static bool drawCellsBackground;
    public static Color backColor;
    public static Color borderColor;
    public static bool hasNewSettings = false;
    public static bool isFileSettingsChanged = false;
    /// <summary>
    /// Читает настройки из файла. Если файла настроек нет, задаёт их по умолчанию.
    /// </summary>
    public static void ReadSettings()
    {
        width = Properties.Settings.Default.width;
        height = Properties.Settings.Default.height;
        timerInterval = Properties.Settings.Default.timerInterval;
        drawCellsBackground = Properties.Settings.Default.drawCellsBackground;
        backColor = Properties.Settings.Default.backColor;
        borderColor = Properties.Settings.Default.borderColor;
        GameController.GameCreate(timerInterval);
    }
    /// <summary>
    /// Сохраняет изменения настроек.
    /// </summary>
    public static void SaveSettings()
    {
        if (isFileSettingsChanged)
        {
            Properties.Settings.Default.width = width;
            Properties.Settings.Default.height = height;
            Properties.Settings.Default.timerInterval = timerInterval;
            Properties.Settings.Default.drawCellsBackground = drawCellsBackground;
            Properties.Settings.Default.backColor = backColor;
            Properties.Settings.Default.borderColor = borderColor;
            Properties.Settings.Default.Save();
        }
    }
}
