namespace SnakeGame;

internal class SnakeController
{
    Snake snake;
    public SnakeController(Snake snake)
    {
        this.snake = snake;
        FormMain.Instance.KeyDown += new System.Windows.Forms.KeyEventHandler(KeyDown);
    }
    public void KeyDown(object sender, KeyEventArgs e)
    {
        switch (e.KeyCode)
        {
            case (Keys.Up):
                snake.ChangeDirection((0, -1));
                break;
            case (Keys.Down):
                snake.ChangeDirection((0, 1));
                break;
            case (Keys.Left):
                snake.ChangeDirection((-1, 0));
                break;
            case (Keys.Right):
                snake.ChangeDirection((1 ,0));
                break;
        }
    }

}

