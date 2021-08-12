
namespace Assessment_Game
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tmrDragon = new System.Windows.Forms.Timer(this.components);
            this.tmrMarshmallow = new System.Windows.Forms.Timer(this.components);
            this.MnuStrip = new System.Windows.Forms.MenuStrip();
            this.MnuStart = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuStop = new System.Windows.Forms.ToolStripMenuItem();
            this.LblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblScore = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblLives = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.tmrShoot = new System.Windows.Forms.Timer(this.components);
            this.PnlGame = new System.Windows.Forms.Panel();
            this.selectDifficultyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuEasy = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuMedium = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuHard = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.LblDifficulty = new System.Windows.Forms.Label();
            this.MnuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrDragon
            // 
            this.tmrDragon.Interval = 50;
            this.tmrDragon.Tick += new System.EventHandler(this.tmrDragon_Tick);
            // 
            // tmrMarshmallow
            // 
            this.tmrMarshmallow.Tick += new System.EventHandler(this.tmrMarshmallow_Tick);
            // 
            // MnuStrip
            // 
            this.MnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuStart,
            this.MnuStop,
            this.selectDifficultyToolStripMenuItem});
            this.MnuStrip.Location = new System.Drawing.Point(0, 0);
            this.MnuStrip.Name = "MnuStrip";
            this.MnuStrip.Size = new System.Drawing.Size(644, 24);
            this.MnuStrip.TabIndex = 0;
            this.MnuStrip.Text = "menuStrip1";
            // 
            // MnuStart
            // 
            this.MnuStart.Name = "MnuStart";
            this.MnuStart.Size = new System.Drawing.Size(43, 20);
            this.MnuStart.Text = "Start";
            this.MnuStart.Click += new System.EventHandler(this.MnuStart_Click);
            // 
            // MnuStop
            // 
            this.MnuStop.Name = "MnuStop";
            this.MnuStop.Size = new System.Drawing.Size(43, 20);
            this.MnuStop.Text = "Stop";
            this.MnuStop.Click += new System.EventHandler(this.MnuStop_Click);
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.Location = new System.Drawing.Point(481, 94);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(46, 16);
            this.LblName.TabIndex = 1;
            this.LblName.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(481, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Score:";
            // 
            // LblScore
            // 
            this.LblScore.AutoSize = true;
            this.LblScore.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblScore.Location = new System.Drawing.Point(527, 188);
            this.LblScore.Name = "LblScore";
            this.LblScore.Size = new System.Drawing.Size(15, 16);
            this.LblScore.TabIndex = 4;
            this.LblScore.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(481, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lives:";
            // 
            // LblLives
            // 
            this.LblLives.AutoSize = true;
            this.LblLives.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLives.Location = new System.Drawing.Point(525, 217);
            this.LblLives.Name = "LblLives";
            this.LblLives.Size = new System.Drawing.Size(15, 16);
            this.LblLives.TabIndex = 6;
            this.LblLives.Text = "5";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(525, 94);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(42, 16);
            this.label.TabIndex = 8;
            this.label.Text = "label1";
            // 
            // tmrShoot
            // 
            this.tmrShoot.Tick += new System.EventHandler(this.tmrShoot_Tick);
            // 
            // PnlGame
            // 
            this.PnlGame.BackColor = System.Drawing.Color.MintCream;
            this.PnlGame.BackgroundImage = global::Assessment_Game.Properties.Resources.ice_cave;
            this.PnlGame.Location = new System.Drawing.Point(12, 45);
            this.PnlGame.Name = "PnlGame";
            this.PnlGame.Size = new System.Drawing.Size(450, 419);
            this.PnlGame.TabIndex = 7;
            this.PnlGame.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlGame_Paint);
            this.PnlGame.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlGame_MouseDown);
            // 
            // selectDifficultyToolStripMenuItem
            // 
            this.selectDifficultyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuEasy,
            this.MnuMedium,
            this.MnuHard});
            this.selectDifficultyToolStripMenuItem.Name = "selectDifficultyToolStripMenuItem";
            this.selectDifficultyToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.selectDifficultyToolStripMenuItem.Text = "Select Difficulty:";
            // 
            // MnuEasy
            // 
            this.MnuEasy.Name = "MnuEasy";
            this.MnuEasy.Size = new System.Drawing.Size(180, 22);
            this.MnuEasy.Text = "Easy";
            this.MnuEasy.Click += new System.EventHandler(this.MnuEasy_Click);
            // 
            // MnuMedium
            // 
            this.MnuMedium.Name = "MnuMedium";
            this.MnuMedium.Size = new System.Drawing.Size(180, 22);
            this.MnuMedium.Text = "Medium";
            this.MnuMedium.Click += new System.EventHandler(this.MnuMedium_Click);
            // 
            // MnuHard
            // 
            this.MnuHard.Name = "MnuHard";
            this.MnuHard.Size = new System.Drawing.Size(180, 22);
            this.MnuHard.Text = "Hard";
            this.MnuHard.Click += new System.EventHandler(this.MnuHard_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(481, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Difficulty:";
            // 
            // LblDifficulty
            // 
            this.LblDifficulty.AutoSize = true;
            this.LblDifficulty.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDifficulty.Location = new System.Drawing.Point(548, 127);
            this.LblDifficulty.Name = "LblDifficulty";
            this.LblDifficulty.Size = new System.Drawing.Size(38, 16);
            this.LblDifficulty.TabIndex = 10;
            this.LblDifficulty.Text = "Easy";
            this.LblDifficulty.Click += new System.EventHandler(this.LblDifficulty_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(231)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(644, 480);
            this.Controls.Add(this.LblDifficulty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.PnlGame);
            this.Controls.Add(this.LblLives);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LblScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.MnuStrip);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.MnuStrip;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.MnuStrip.ResumeLayout(false);
            this.MnuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrDragon;
        private System.Windows.Forms.Timer tmrMarshmallow;
        private System.Windows.Forms.MenuStrip MnuStrip;
        private System.Windows.Forms.ToolStripMenuItem MnuStart;
        private System.Windows.Forms.ToolStripMenuItem MnuStop;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblScore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblLives;
        private System.Windows.Forms.Panel PnlGame;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Timer tmrShoot;
        private System.Windows.Forms.ToolStripMenuItem selectDifficultyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuEasy;
        private System.Windows.Forms.ToolStripMenuItem MnuMedium;
        private System.Windows.Forms.ToolStripMenuItem MnuHard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblDifficulty;
    }
}

