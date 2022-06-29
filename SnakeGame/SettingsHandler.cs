using System.IO;
namespace SnakeGame;

internal static class SettingsHandler
{
    static int width;
    static int height;
    static int timerInterval;
    static bool isChanged = false;
    /// <summary>
    /// Читает настройки из файла. Если файла настроек нет, задаёт их по умолчанию.
    /// </summary>
    public static void ReadSettings()
    {
        try
        {
            StreamReader reader = new StreamReader("Settings.txt");
            string[] input = reader.ReadToEnd().Split('\n');
            width = int.Parse(input[0]);
            height = int.Parse(input[1]);
            timerInterval = int.Parse(input[2]);
            reader.Close();
        }
        catch //настройки по умолчанию
        {
            width = 25;
            height = 25;
            timerInterval = 100;
            isChanged = true;
        }
        GameController.GameCreate(width ,height, timerInterval);
    }
    /// <summary>
    /// Сохраняет изменения настроек.
    /// </summary>
    public static void SaveSettings()
    {
        if (isChanged)
        {
            StreamWriter writer = new StreamWriter("Settings.txt");
            writer.Write(width.ToString()+'\n'+height+'\n'+timerInterval);
            writer.Close();
        }
    }
}
