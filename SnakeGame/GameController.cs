namespace SnakeGame;
internal class GameController
{
    private static GameController gameController;
    Snake snake;
    //Snake snake2;
    SnakeController controller;
    //SnakeController controller2;
    System.Windows.Forms.Timer timer;
    private GameController(int time)
    {
        timer = new System.Windows.Forms.Timer();
        timer.Interval = time;
        timer.Tick += Step;
    }
    public static void GameCreate(int width, int height, int time)
    {
        if (gameController == null) 
        {
            gameController = new GameController(time);
        }
        PlayingField.CreateField(width, height);
    }
    private void Step(object? sender, EventArgs e)
    {
        snake.Move();
        //snake2.Move();
    }
    public static void GameStart()
    {
        gameController.snake = new Snake(PlayingField.GetCenter(), PlayingField.Size);
        //gameController.snake2 = new Snake((2, 2), PlayingField.Size);
        //gameController.controller2 = new SnakeController(gameController.snake2);
        gameController.controller = new SnakeController(gameController.snake);
        gameController.timer.Enabled = true;
        PlayingField.CreateFood();
    }
    public static void GameEnd(Snake snake)
    {
        gameController.timer.Stop();
        int score = snake.Length;
        if (BoardOfRecords.CheckResult(score))
        {
            FormNewRecord form = new FormNewRecord(score);
            form.ShowDialog();
        }
        else
        {
            FormEndGame.ShowForm(snake.Length);
        }
    }
    public static void GameRestart()
    {
        PlayingField.ReviewField();
        GameStart();
    }
    public static void GamePause()
    {
        gameController.timer.Stop();
    }
    public static void GameResume()
    {
        gameController.timer.Start();
    }
    public static void EatFood(Food food, ICollisionable gameObject)
    {
        if (gameObject is SnakeHead snakeHead)
        {
            snakeHead.snake.AddCell(food);
            PlayingField.CreateFood();
        }
    }
    public static void CollideWithWall(ICollisionable gameObject)
    {
        gameController.timer.Stop();
        if (gameObject is SnakeHead snakeHead)
        {
            GameEnd(snakeHead.snake);
        }
    }
}