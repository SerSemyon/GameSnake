namespace SnakeGame;

internal class ResourceStorage
{
    static Random random = new Random();
    public static Image GetHeadImage()
    {
        return Properties.Resources.SnakeHead;
    }
    public static Image GetFoodImage()
    {
        int x = random.Next(5);
        return x switch
        {
            0 => Properties.Resources.Ellipse0,
            1 => Properties.Resources.Ellipse1,
            2 => Properties.Resources.Ellipse2,
            3 => Properties.Resources.Ellipse3,
            4 => Properties.Resources.Ellipse4
        };
    }
    public static Image GetSnakeCellImage()
    {
        return Properties.Resources.redSquare;
    }
}