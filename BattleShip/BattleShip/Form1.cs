using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleShip
{
    public partial class Form1 : Form
    {
        System.Drawing.Graphics graph, graphAI;
        Bitmap EmptyCell, WarshipCell;

        public bool VariantSort = false;
        public bool vsAi = false;
        public bool vsPlayer = false;
        public bool localeVS = false;

        AIinstallShip AIinstall;
        InstallShip UserInstall;
        DrawCells drCell;

        const int height = 10;
        const int width = 10;
        const int WidthCell = 40;
        const int HeightCell = 40;

        bool Continue = true;


        Random rnd = new Random();

        int[,] MyField = new int[width + 2, height + 2];
        int[,] EnemyField = new int[width + 2, height + 2];

        public Form1()
        {
            InitializeComponent();

            graph = MyPanel.CreateGraphics();
            graphAI = EnemyPanel.CreateGraphics();

            AIinstall = new AIinstallShip();
            UserInstall = new InstallShip();
            drCell = new DrawCells();

            TimerGame.Interval = 1000;
        }

        private void NewGame()
        {
            int Select = 0;

            if(vsAi)
            {
                while (AIinstall.AIcurse != 0)
                {
                    Select = rnd.Next(0, 2);
                    if (Select == 0)
                    {
                        AIinstall.AIInstallBattleShip(EnemyField);
                    }
                    else
                    {
                        AIinstall.AIInstallRotateBattleShip(EnemyField);
                    }
                }
            }

            if (VariantSort)
            {
                AIinstall.AIcurse = 10;
                while (AIinstall.AIcurse != 0)
                {
                    Select = rnd.Next(0, 2);
                    if (Select == 0)
                    {
                        AIinstall.AIInstallBattleShip(MyField);
                    }
                    else
                    {
                        AIinstall.AIInstallRotateBattleShip(MyField);
                    }
                }

                for (int row = 1; row < width + 1; row++)
                {
                    for (int col = 1; col < height + 1; col++)
                    {
                        drCell.ShowCell(MyField, graph, row, col);
                    }
                }
            }
        }

        private void DrawFields(Graphics graphics, int[,] Field)
        {
            for (int row = 1; row < width + 1; row++)
            {
                for (int col = 1; col < height + 1; col++)
                {
                    drCell.ShowCell(Field, graphics, row, col);
                }
            }
        }

        private void MyPanel_MouseClick(object sender, MouseEventArgs e)
        {
            if(VariantSort == false)
            {
                if(e.Button == MouseButtons.Left)
                {
                    UserInstall.InstallBattleShip(MyField, graph, (int)(e.X / WidthCell), (int)(e.Y / HeightCell));
                }
                else if(e.Button == MouseButtons.Right)
                {
                    UserInstall.InstallRotateBattleShip(MyField, graph, (int)(e.X / WidthCell), (int)(e.Y / HeightCell));
                }
            }
        }

        private void MyPanel_Paint(object sender, PaintEventArgs e)
        { 
            DrawFields(graph, MyField);
        }

        private void EnemyPanel_Paint(object sender, PaintEventArgs e)
        {
            DrawFields(graphAI, EnemyField);
        }

        private void EnemyPanel_MouseClick(object sender, MouseEventArgs e)
        {
            if (vsPlayer)
            {
                if (e.Button == MouseButtons.Left)
                {
                    UserInstall.InstallBattleShip(EnemyField, graphAI, (int)(e.X / WidthCell), (int)(e.Y / HeightCell));
                }
                else if (e.Button == MouseButtons.Right)
                {
                    UserInstall.InstallRotateBattleShip(EnemyField, graphAI, (int)(e.X / WidthCell), (int)(e.Y / HeightCell));
                }
            }
            if(Continue == false)
            {
                AtackToEnemy((int)(e.X / WidthCell), (int)(e.Y / HeightCell));
            }
        }

        private void AtackToEnemy(int row, int col)
        {
            while(Continue)
            {
                if(EnemyField[row, col] == 20)
                {
                    return;
                }
                if(EnemyField[row, col] == 0)
                {
                    EnemyField[row, col] = 11;
                    drCell.ShowCell(EnemyField, graphAI, row, col);
                    Continue = true;
                }
                else
                {
                    drCell.ShowCell(EnemyField, graphAI, row, col);
                    MyField[row, col] = 20;
                }
            }
        }

        public void AtackToPlayers()
        {
            int row, col;
            while (Continue == false)
            {
                row = rnd.Next(1, 10);
                col = rnd.Next(1, 10);

                if (MyField[row, col] == 20)
                {
                    return;
                }

                if (MyField[row, col] == 0)
                {
                    MyField[row, col] = 20;
                    drCell.ShowCell(MyField, graph, row, col);
                    Continue = false;
                }

                else
                {
                    drCell.ShowCell(MyField, graph, row, col);
                    MyField[row, col] = 20;
                    Continue = true;
                }
            }
        }
        
        double Time = 0, TimeToAtack = 0;

        private void update()
        {
            this.labelGame.Text = "Время игры:  " + (int)Time + ".  До конца хода: " + (30-(int)TimeToAtack);
            if(TimeToAtack > 30)
            {
                AtackToPlayers();
                Continue = true;
                TimeToAtack = 0;
            }
        }

        private void TimerGame_Tick(object sender, EventArgs e)
        {
            update();
            Time += 0.001*TimerGame.Interval;
            TimeToAtack += 0.001*TimerGame.Interval;
        }

        private void начатьИгруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();
            TimerGame.Enabled = true;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void vsAIgame_CheckedChanged(object sender, EventArgs e)
        {
            if (vsAIgame.Checked == true)
                vsAi = true;
            else
                vsAi = false;

        }

        private void vsPlayerGame_CheckedChanged(object sender, EventArgs e)
        {
            if (vsPlayerGame.Checked == true)
                vsPlayer = true;
            else
                vsPlayer = false;
        }

        private void localeVSgame_CheckedChanged(object sender, EventArgs e)
        {
            if (localeVSgame.Checked == true)
                localeVS = true;
            else
                localeVS = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                VariantSort = true;
                checkBox1.Text = "Расстановка игроком";
            }
            else
            {
                VariantSort = false;
                checkBox1.Text = "Расстановка ИИ";
            }
        }
    }
}
