namespace SnakeGame;

internal class PlayingField
{
    static PlayingField playingField;
    static RendererPlayingField renderer;
    public static RendererPlayingField Renderer
    {
        set
        {
            renderer = value;
        }
    }
    CollisionField collisionField;
    int width, height;
    /// <summary>
    /// Размер одной ячейки.
    /// </summary>
    public static int Size
    {
        get { return renderer.SizeOfCell; }
    }
    private PlayingField(int width, int height)
    {
        this.width = width;
        this.height = height;
        renderer.DrawField(width, height);
        collisionField = new CollisionField(width, height);
    }
    public static void CreateField(int width, int height)
    {
        if (playingField is null)
        {
            playingField = new PlayingField(width, height);
        }
        renderer.DrawField(width, height);
        playingField.collisionField = new CollisionField(width, height);
    }
    public static void ReviewField()
    {
        CreateField(playingField.width, playingField.height);
    }
    public static void Add(ICollisionable gameObject, CellRenderer cellRenderer, (int X, int Y) location)
    {
        renderer.Controls.Add(cellRenderer);
        cellRenderer.BringToFront();
        playingField.collisionField.Add(gameObject, location.X, location.Y);
    }
    public static void Add(ICollisionable gameObject, Point location)
    {
        playingField.collisionField.Add(gameObject, location.X / Size, location.Y / Size);
    }
    public static void Move((int X, int Y) oldLocation, (int X, int Y) newLocation)
    {
        playingField.collisionField.Move(oldLocation, newLocation);
    }
    public static void Move(Point oldLocation, (int X, int Y) newLocation)
    {
        (int X, int Y) location = (oldLocation.X / Size, oldLocation.Y / Size);
        playingField.collisionField.Move(location, newLocation);
    }
    public static void Remove(CellRenderer cellRenderer, (int X, int Y) location)
    {
        renderer.Controls.Remove(cellRenderer);
        playingField.collisionField.Remove(location);
    }
    public static void CreateFood()
    {
        (int X, int Y) location = playingField.collisionField.RandomEmptyCell();
        Food food = new Food(new Point(location.X*Size, location.Y*Size), renderer.SizeOfCell);
        Add(food, food.cellBox, location);
    }
    public static Point PointFromCoordinates(int X, int Y)
    {
        return new Point(X * renderer.SizeOfCell, Y * renderer.SizeOfCell);
    }
    public static (int X, int Y) CoordinatesFromPoint(Point location)
    {
        return (location.X / Size, location.Y / Size);
    }
    public static (int X, int Y) GetCenter()
    {
        return (playingField.width / 2, playingField.height / 2);
    }
}
