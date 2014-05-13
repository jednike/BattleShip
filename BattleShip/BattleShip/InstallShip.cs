using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace BattleShip
{
    class InstallShip: DrawCells
    {
        bool Continue;
        public int clicksNumber = 10;

        public void InstallBattleShip(int[,] Field, Graphics graph, int row, int col)
        {
            #region Четырехпалубный

            if (clicksNumber == 10)
            {
                if (row < 8)
                {
                    for (int i = 0; i < 6; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            if (Field[row - 1 + i, col - 1 + j] == 0)
                            {
                                Continue = true;
                            }
                            else
                            {
                                Continue = false;
                            }
                        }
                    }
                    if (Continue)
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            Field[row + i, col] = clicksNumber;
                            ShowCell(Field, graph, row + i, col);
                        }
                        clicksNumber--;
                    }
                    else
                    {
                        Continue = true;
                    }
                }
            }
            #endregion

            #region Трехпалубный

            if (clicksNumber > 7 && clicksNumber < 10)
            {
                if (row < 9)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            if (Field[row - 1 + i, col - 1 + j] == 0)
                            {
                                Continue = true;
                            }
                            else
                            {
                                Continue = false;
                                return;
                            }
                        }
                    }
                    if (Continue)
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            Field[row + i, col] = clicksNumber;
                            ShowCell(Field, graph, row + i, col);
                        }
                        clicksNumber--;
                    }
                    else
                    {
                        Continue = true;
                    }
                }
            }
            #endregion

            #region Двухпалубный
            if (clicksNumber > 4 && clicksNumber < 8)
            {
                if (row < 8)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            if (Field[row - 1 + i, col - 1 + j] == 0)
                            {
                                Continue = true;
                            }
                            else
                            {
                                Continue = false;
                                return;
                            }
                        }
                    }
                    if (Continue == true)
                    {
                        for (int i = 0; i < 2; i++)
                        {
                            Field[row + i, col] = clicksNumber;
                            ShowCell(Field, graph, row + i, col);
                        }
                        clicksNumber--;

                    }
                    else
                    {
                        Continue = true;
                    }
                }
            }
            #endregion

            #region Однопалубный

            if (clicksNumber > 0 && clicksNumber < 5)
            {
                if (row < 11)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            if (Field[row - 1 + i, col - 1 + j] == 0)
                            {
                                Continue = true;
                            }
                            else
                            {
                                Continue = false;
                                return;
                            }
                        }
                    }
                    if (Continue)
                    {
                        Field[row, col] = clicksNumber;
                        ShowCell(Field, graph, row, col);
                        clicksNumber--;
                    }
                    else
                    {
                        Continue = true;
                    }
                }
            }
            #endregion

        }

        public void InstallRotateBattleShip(int[,] Field, Graphics graph, int row, int col)
        {

            #region Четырехпалубный

            if (clicksNumber == 10)
            {
                if (col < 8)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 6; j++)
                        {
                            if (Field[row - 1 + i, col - 1 + j] == 0)
                            {
                                Continue = true;
                            }
                            else
                            {
                                Continue = false;
                            }
                        }
                    }
                    if (Continue)
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            Field[row, col + i] = clicksNumber;
                            ShowCell(Field, graph, row, col + i);
                        }
                        clicksNumber--;
                    }
                    else
                    {
                        Continue = true;
                    }
                }
            }
            #endregion

            #region Трехпалубный

            if (clicksNumber > 7 && clicksNumber < 10)
            {
                if (col < 9)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            if (Field[row - 1 + i, col - 1 + j] == 0)
                            {
                                Continue = true;
                            }
                            else
                            {
                                Continue = false;
                                return;
                            }
                        }
                    }
                    if (Continue)
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            Field[row, col + i] = clicksNumber;
                            ShowCell(Field, graph, row, col + i);
                        }
                        clicksNumber--;
                    }
                    else
                    {
                        Continue = true;
                    }
                }
            }
            #endregion

            #region Двухпалубный
            if (clicksNumber > 4 && clicksNumber < 8)
            {
                if (col < 10)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            if (Field[row - 1 + i, col - 1 + j] == 0)
                            {
                                Continue = true;
                            }
                            else
                            {
                                Continue = false;
                                return;
                            }
                        }
                    }
                    if (Continue == true)
                    {
                        for (int i = 0; i < 2; i++)
                        {
                            Field[row, col + i] = clicksNumber;
                            ShowCell(Field, graph, row, col + i);
                        }
                        clicksNumber--;

                    }
                    else
                    {
                        Continue = true;
                    }
                }
            }
            #endregion

            #region Однопалубный

            if (clicksNumber > 0 && clicksNumber < 5)
            {
                if (col < 11)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            if (Field[row - 1 + i, col - 1 + j] == 0)
                            {
                                Continue = true;
                            }
                            else
                            {
                                Continue = false;
                                return;
                            }
                        }
                    }
                    if (Continue)
                    {
                        Field[row, col] = clicksNumber;
                        ShowCell(Field, graph, row, col);
                        clicksNumber--;
                    }
                    else
                    {
                        Continue = true;
                    }
                }
            }
            #endregion
        }
    }
}
