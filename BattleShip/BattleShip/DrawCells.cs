using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BattleShip
{
    class DrawCells
    {
        const int WidthCell = 40;
        const int HeightCell = 40;

        public void ShowCell(int[,] Field, Graphics graphics, int row, int col)
        {
            if (Field[row, col] == 10)
            {
                graphics.FillRectangle(Brushes.Red, row * WidthCell, col * HeightCell, WidthCell, HeightCell);
            }
            if (Field[row, col] == 20)
            {
                graphics.FillRectangle(Brushes.Black, row * WidthCell, col * HeightCell, WidthCell, HeightCell);
            }
            if (Field[row, col] == 9 || Field[row, col] == 8)
            {
                graphics.FillRectangle(Brushes.Green, row * WidthCell, col * HeightCell, WidthCell, HeightCell);
            }

            if (Field[row, col] < 8 && Field[row, col] > 4)
            {
                graphics.FillRectangle(Brushes.Brown, row * WidthCell, col * HeightCell, WidthCell, HeightCell);
            }

            if (Field[row, col] > 0 && Field[row, col] < 5)
            {
                graphics.FillRectangle(Brushes.Purple, row * WidthCell, col * HeightCell, WidthCell, HeightCell);
            }
            if (Field[row, col] == 0)
            {
                graphics.FillRectangle(Brushes.Blue, row * WidthCell, col * HeightCell, WidthCell, HeightCell);
            }
            graphics.DrawRectangle(Pens.Black, row * WidthCell, col * HeightCell, WidthCell, HeightCell);
        }
    }
}
