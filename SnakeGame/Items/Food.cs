using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame;

internal class Food : ICollisionable
{
    public CellRenderer cellBox;
    public Food(Point location, int sizeOfSides)
    {
        cellBox = new CellRenderer(location, sizeOfSides);
        cellBox.Image = ResourceStorage.GetFoodImage();
    }
    public void CollideWith(ICollisionable gameObject)
    {
        GameController.EatFood(this, gameObject);
    }
}
