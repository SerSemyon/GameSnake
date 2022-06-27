using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame;
/// <summary>
/// Определяет столкновения объектов.
/// </summary>
internal class CollisionField
{
    ICollisionable?[,] cells;
    Random random;
    public CollisionField(int width, int height)
    {
        cells = new ICollisionable?[width, height];
        random = new Random();
    }
    public void Add(ICollisionable newCell, int X, int Y)
    {
        cells[X, Y] = newCell;
    }
    public void Move((int X, int Y) oldLocation, (int X, int Y) newLocation)
    {
        if (newLocation.X >= 0 && newLocation.Y >= 0 && newLocation.X < cells.GetLength(0) && newLocation.Y < cells.GetLength(1))
        {
            if (cells[newLocation.X, newLocation.Y] is not null)
            {
                cells[newLocation.X, newLocation.Y].CollideWith(cells[oldLocation.X, oldLocation.Y]);
            }
            cells[newLocation.X, newLocation.Y] = cells[oldLocation.X, oldLocation.Y];
            cells[oldLocation.X, oldLocation.Y] = null;
        }
        else
        {
            try
            {
                GameController.CollideWithWall(cells[oldLocation.X, oldLocation.Y]);
            }
            catch
            {

            }
        }
    }
    public void Remove((int X, int Y) location)
    {
        cells[location.X, location.Y] = null;
    }
    public (int X, int Y) RandomEmptyCell()
    {
        int x, y;
        do
        {
            x = random.Next(cells.GetLength(0));
            y = random.Next(cells.GetLength(1));
        }
        while (cells[x,y] is not null);
        return (x, y);
    }
}
