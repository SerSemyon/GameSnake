namespace SnakeGame;

internal class SnakeController
{
    Keys upKey = Keys.Up;
    Keys downKey = Keys.Down;
    Keys leftKey = Keys.Left;
    Keys rightKey = Keys.Right;
    Snake snake;
    public SnakeController(Snake snake)
    {
        this.snake = snake;
        FormMain.Instance.KeyDown += new System.Windows.Forms.KeyEventHandler(KeyDown);
    }
    public SnakeController(Snake snake, Keys[] keys) : this(snake)
    {
        upKey = keys[0];
        downKey = keys[1];
        leftKey = keys[2];
        rightKey = keys[3];
    }
    public void KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == upKey)
        {
            snake.ChangeDirection((0, -1));
        }
        if (e.KeyCode == downKey)
        {
            snake.ChangeDirection((0, 1));
        }
        if (e.KeyCode == leftKey)
        {
            snake.ChangeDirection((-1, 0));
        }
        if (e.KeyCode == rightKey)
        {
            snake.ChangeDirection((1, 0));
        }
    }
}

