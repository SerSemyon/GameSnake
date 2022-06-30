using System.Collections.Generic;
namespace SnakeGame;

internal class Snake
{
    List<SnakeCell> cells;
    (int X, int Y) motionVector = (0, 1);
    (int X, int Y) headLocation = (1,1);
    (int X, int Y) lastHeadLocaton;
    Point tailLocation;
    CellRenderer? digested; //Съеденная еда
    public Snake((int X, int Y) startLocation, int size)
    {
        cells = new List<SnakeCell>();
        headLocation = startLocation;
        SnakeHead head = new SnakeHead(startLocation.X, startLocation.Y, size, this);
        cells.Add(head);
        PlayingField.Add(head, head.cellBox, startLocation);
    }
    public void Move() 
    {
        lastHeadLocaton = headLocation;
        tailLocation = cells[^1].cellBox.Location;
        (int X, int Y) currentLocation = (headLocation.X + motionVector.X, headLocation.Y + motionVector.Y);
        for (int i = 1; i < cells.Count; i++)
        {
            cells[^i].cellBox.Location = cells[^(i+1)].cellBox.Location;
        }
        PlayingField.Move(headLocation, currentLocation);
        PlayingField.Move(tailLocation, headLocation);
        headLocation = currentLocation;
        cells[0].cellBox.Location = new Point(headLocation.X * cells[0].cellBox.Width, headLocation.Y * cells[0].cellBox.Height);
        if (digested is not null)
        {
            SnakeCell newCell = new SnakeCell(digested, tailLocation);
            cells.Add(newCell);
            PlayingField.Add(newCell, tailLocation);
            digested = null;
        }
    }
    public void ChangeDirection((int X,int Y) newMotionVector)
    {
        //Проверка на попытку повенуть змейку "в себя"
        if ((newMotionVector.X+headLocation.X,newMotionVector.Y+headLocation.Y)!=lastHeadLocaton)
        {
            if (newMotionVector != motionVector)
            {
                if (motionVector.X > 0)
                {
                    if (newMotionVector.Y > 0)
                        cells[0].cellBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    else
                        cells[0].cellBox.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                }
                else if (motionVector.X < 0)
                {
                    if (newMotionVector.Y < 0)
                        cells[0].cellBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    else
                        cells[0].cellBox.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                }
                else if (motionVector.Y > 0)
                {
                    if (newMotionVector.X < 0)
                        cells[0].cellBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    else
                        cells[0].cellBox.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                }
                else if (motionVector.Y < 0)
                {
                    if (newMotionVector.X > 0)
                        cells[0].cellBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    else
                        cells[0].cellBox.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                }
                motionVector = newMotionVector;
            }
        }
    }
    public void AddCell(Food food)
    {
        digested = food.cellBox;
    }
    /// <summary>
    /// Возвращает длину без учёта головы.
    /// </summary>
    public int Length
    {
        get
        {
            return cells.Count-1;
        }
    }
}
