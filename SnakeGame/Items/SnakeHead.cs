using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame;


internal class SnakeHead : SnakeCell, ICollisionable
{
    public Snake snake;
    public SnakeHead(int X, int Y, int size, Snake snake) : base()
    {
        Point location = new Point(X * size, Y * size);
        cellBox = new CellRenderer(location, size);
        cellBox.Image = ResourceStorage.GetHeadImage();
        this.snake = snake;
    }
}