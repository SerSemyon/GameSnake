using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame;
internal class SnakeCell : ICollisionable
{
    public CellRenderer cellBox;
    protected SnakeCell() { }
    public SnakeCell(int X, int Y, int sizeOfSides)
    {
        Point location = new Point(X, Y);
        cellBox = new CellRenderer(location, sizeOfSides);
        cellBox.Image = ResourceStorage.GetSnakeCellImage();
    }
    public SnakeCell(CellRenderer cellBox, Point location)
    {
        this.cellBox = cellBox;
        cellBox.Location = location;
    }
    public void CollideWith(ICollisionable gameObject)    
    {
        GameController.CollideWithWall(gameObject);
    }
}
