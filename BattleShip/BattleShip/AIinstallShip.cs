using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    class AIinstallShip
    {
        public bool Continue;

        public int AIcurse = 10;

        Random rnd = new Random();

        public void AIInstallBattleShip(int[,] Field)
        {
            int row, col;

            #region Четырехпалубный
            if (AIcurse == 10)
            {
                row = rnd.Next(1, 7);
                col = rnd.Next(1, 10);

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
                            return;
                        }
                    }
                }
                if (Continue)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        Field[row + i, col] = AIcurse;
                    }
                    AIcurse--;
                }
                else
                {
                    Continue = true;
                }
            }
            #endregion

            #region Трехпалубный
            else if (AIcurse > 7 && AIcurse < 10)
            {
                row = rnd.Next(1, 8);
                col = rnd.Next(1, 10);

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
                        Field[row + i, col] = AIcurse;
                    }
                    AIcurse--;
                }
                else
                {
                    Continue = true;
                }
            }
            #endregion

            #region Двухпалубный
            else if (AIcurse > 4 && AIcurse < 8)
            {
                row = rnd.Next(1, 9);
                col = rnd.Next(1, 10);

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
                if (Continue)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        Field[row + i, col] = AIcurse;
                    }
                    AIcurse--;
                }
                else
                {
                    Continue = true;
                }
            }
            #endregion

            #region Однопалубный
            else if (AIcurse > 0 && AIcurse < 5)
            {
                row = rnd.Next(1, 10);
                col = rnd.Next(1, 10);

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
                if (Continue)
                {
                    Field[row, col] = AIcurse;
                    AIcurse--;
                }
                else
                {
                    Continue = true;
                }
            }
            #endregion
        }

        public void AIInstallRotateBattleShip(int[,] Field)
        {
            int row, col;

            #region Четырехпалубный
            if (AIcurse == 10)
            {
                row = rnd.Next(1, 10);
                col = rnd.Next(1, 7);

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
                            return;
                        }
                    }
                }
                if (Continue)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        Field[row, col + i] = AIcurse;
                    }
                    AIcurse--;
                }
                else
                {
                    Continue = true;
                }
            }
            #endregion

            #region Трехпалубный
            else if (AIcurse > 7 && AIcurse < 10)
            {
                row = rnd.Next(1, 10);
                col = rnd.Next(1, 8);

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
                        Field[row, col + i] = AIcurse;
                    }
                    AIcurse--;
                }
                else
                {
                    Continue = true;
                }
            }
            #endregion

            #region Двухпалубный
            else if (AIcurse > 4 && AIcurse < 8)
            {
                row = rnd.Next(1, 10);
                col = rnd.Next(1, 9);

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
                if (Continue)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        Field[row, col + i] = AIcurse;
                    }
                    AIcurse--;
                }
                else
                {
                    Continue = true;
                }
            }
            #endregion

            #region Однопалубный
            else if (AIcurse > 0 && AIcurse < 5)
            {
                row = rnd.Next(1, 10);
                col = rnd.Next(1, 10);

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
                if (Continue)
                {
                    Field[row, col] = AIcurse;
                    AIcurse--;
                }
                else
                {
                    Continue = true;
                }
            }
            #endregion
        }
    }
}
