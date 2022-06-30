using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame;

internal class CellRenderer : PictureBox
{
    public CellRenderer(Point location, int sizeOfSides) : base()
    {
        Height = sizeOfSides;
        Width = sizeOfSides;
        Location = location;
        SizeMode = PictureBoxSizeMode.Zoom;
    }
    public void SetLocation(Point newLocation)
    {
        Location = newLocation;
    }
}