namespace BattleShip
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MyPanel = new System.Windows.Forms.Panel();
            this.EnemyPanel = new System.Windows.Forms.Panel();
            this.TimerGame = new System.Windows.Forms.Timer(this.components);
            this.labelGame = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.играToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.начатьИгруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обАвтореToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.vsAIgame = new System.Windows.Forms.RadioButton();
            this.vsPlayerGame = new System.Windows.Forms.RadioButton();
            this.localeVSgame = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MyPanel
            // 
            this.MyPanel.Location = new System.Drawing.Point(12, 44);
            this.MyPanel.Name = "MyPanel";
            this.MyPanel.Size = new System.Drawing.Size(480, 480);
            this.MyPanel.TabIndex = 0;
            this.MyPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MyPanel_Paint);
            this.MyPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MyPanel_MouseClick);
            // 
            // EnemyPanel
            // 
            this.EnemyPanel.Location = new System.Drawing.Point(498, 44);
            this.EnemyPanel.Name = "EnemyPanel";
            this.EnemyPanel.Size = new System.Drawing.Size(480, 480);
            this.EnemyPanel.TabIndex = 0;
            this.EnemyPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.EnemyPanel_Paint);
            this.EnemyPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.EnemyPanel_MouseClick);
            // 
            // TimerGame
            // 
            this.TimerGame.Tick += new System.EventHandler(this.TimerGame_Tick);
            // 
            // labelGame
            // 
            this.labelGame.AutoSize = true;
            this.labelGame.Location = new System.Drawing.Point(697, 9);
            this.labelGame.Name = "labelGame";
            this.labelGame.Size = new System.Drawing.Size(77, 13);
            this.labelGame.TabIndex = 3;
            this.labelGame.Text = "Время игры:  ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.играToolStripMenuItem,
            this.обАвтореToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(987, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // играToolStripMenuItem
            // 
            this.играToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.начатьИгруToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.играToolStripMenuItem.Name = "играToolStripMenuItem";
            this.играToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.играToolStripMenuItem.Text = "Игра";
            // 
            // начатьИгруToolStripMenuItem
            // 
            this.начатьИгруToolStripMenuItem.Name = "начатьИгруToolStripMenuItem";
            this.начатьИгруToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.начатьИгруToolStripMenuItem.Text = "Начать игру";
            this.начатьИгруToolStripMenuItem.Click += new System.EventHandler(this.начатьИгруToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // обАвтореToolStripMenuItem
            // 
            this.обАвтореToolStripMenuItem.Name = "обАвтореToolStripMenuItem";
            this.обАвтореToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.обАвтореToolStripMenuItem.Text = "Об авторе";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(523, 8);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(111, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Расстановка ИИ";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // vsAIgame
            // 
            this.vsAIgame.AutoSize = true;
            this.vsAIgame.Location = new System.Drawing.Point(176, 7);
            this.vsAIgame.Name = "vsAIgame";
            this.vsAIgame.Size = new System.Drawing.Size(78, 17);
            this.vsAIgame.TabIndex = 6;
            this.vsAIgame.TabStop = true;
            this.vsAIgame.Text = "Игра с ИИ";
            this.vsAIgame.UseVisualStyleBackColor = true;
            this.vsAIgame.CheckedChanged += new System.EventHandler(this.vsAIgame_CheckedChanged);
            // 
            // vsPlayerGame
            // 
            this.vsPlayerGame.AutoSize = true;
            this.vsPlayerGame.Location = new System.Drawing.Point(271, 7);
            this.vsPlayerGame.Name = "vsPlayerGame";
            this.vsPlayerGame.Size = new System.Drawing.Size(105, 17);
            this.vsPlayerGame.TabIndex = 7;
            this.vsPlayerGame.TabStop = true;
            this.vsPlayerGame.Text = "Игра с игроком";
            this.vsPlayerGame.UseVisualStyleBackColor = true;
            this.vsPlayerGame.CheckedChanged += new System.EventHandler(this.vsPlayerGame_CheckedChanged);
            // 
            // localeVSgame
            // 
            this.localeVSgame.AutoSize = true;
            this.localeVSgame.Location = new System.Drawing.Point(395, 7);
            this.localeVSgame.Name = "localeVSgame";
            this.localeVSgame.Size = new System.Drawing.Size(122, 17);
            this.localeVSgame.TabIndex = 8;
            this.localeVSgame.TabStop = true;
            this.localeVSgame.Text = "Игра по локальной";
            this.localeVSgame.UseVisualStyleBackColor = true;
            this.localeVSgame.CheckedChanged += new System.EventHandler(this.localeVSgame_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 534);
            this.Controls.Add(this.localeVSgame);
            this.Controls.Add(this.vsPlayerGame);
            this.Controls.Add(this.vsAIgame);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.labelGame);
            this.Controls.Add(this.EnemyPanel);
            this.Controls.Add(this.MyPanel);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MyPanel;
        private System.Windows.Forms.Panel EnemyPanel;
        private System.Windows.Forms.Timer TimerGame;
        private System.Windows.Forms.Label labelGame;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem играToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem начатьИгруToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обАвтореToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RadioButton vsAIgame;
        private System.Windows.Forms.RadioButton vsPlayerGame;
        private System.Windows.Forms.RadioButton localeVSgame;
    }
}

