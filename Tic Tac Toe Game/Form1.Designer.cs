
namespace Tic_Tac_Toe_Game
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GameMechanics_MenuTool = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.A1 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.Scoreboard_lbl = new System.Windows.Forms.Label();
            this.PlayerX_lbl = new System.Windows.Forms.Label();
            this.PlayerO_lbl = new System.Windows.Forms.Label();
            this.Tie_lbl = new System.Windows.Forms.Label();
            this.XScore_lbl = new System.Windows.Forms.Label();
            this.OScore_lbl = new System.Windows.Forms.Label();
            this.TieScore_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(438, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.newGameToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GameMechanics_MenuTool,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // GameMechanics_MenuTool
            // 
            this.GameMechanics_MenuTool.Name = "GameMechanics_MenuTool";
            this.GameMechanics_MenuTool.Size = new System.Drawing.Size(165, 22);
            this.GameMechanics_MenuTool.Text = "Game Mechanics";
            this.GameMechanics_MenuTool.Click += new System.EventHandler(this.GameMechanics_MenuTool_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // A1
            // 
            this.A1.BackColor = System.Drawing.Color.HotPink;
            this.A1.FlatAppearance.BorderColor = System.Drawing.Color.HotPink;
            this.A1.FlatAppearance.BorderSize = 2;
            this.A1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.A1.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A1.Location = new System.Drawing.Point(12, 40);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(75, 75);
            this.A1.TabIndex = 1;
            this.A1.UseVisualStyleBackColor = false;
            this.A1.Click += new System.EventHandler(this.click_button);
            this.A1.MouseEnter += new System.EventHandler(this.enter_button);
            this.A1.MouseLeave += new System.EventHandler(this.leave_button);
            // 
            // B1
            // 
            this.B1.BackColor = System.Drawing.Color.HotPink;
            this.B1.FlatAppearance.BorderColor = System.Drawing.Color.HotPink;
            this.B1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B1.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B1.Location = new System.Drawing.Point(93, 40);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(75, 75);
            this.B1.TabIndex = 2;
            this.B1.UseVisualStyleBackColor = false;
            this.B1.Click += new System.EventHandler(this.click_button);
            this.B1.MouseEnter += new System.EventHandler(this.enter_button);
            this.B1.MouseLeave += new System.EventHandler(this.leave_button);
            // 
            // C1
            // 
            this.C1.BackColor = System.Drawing.Color.HotPink;
            this.C1.FlatAppearance.BorderColor = System.Drawing.Color.HotPink;
            this.C1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.C1.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C1.Location = new System.Drawing.Point(174, 40);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(75, 75);
            this.C1.TabIndex = 3;
            this.C1.UseVisualStyleBackColor = false;
            this.C1.Click += new System.EventHandler(this.click_button);
            this.C1.MouseEnter += new System.EventHandler(this.enter_button);
            this.C1.MouseLeave += new System.EventHandler(this.leave_button);
            // 
            // A2
            // 
            this.A2.BackColor = System.Drawing.Color.HotPink;
            this.A2.FlatAppearance.BorderColor = System.Drawing.Color.HotPink;
            this.A2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.A2.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A2.Location = new System.Drawing.Point(12, 121);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(75, 75);
            this.A2.TabIndex = 4;
            this.A2.UseVisualStyleBackColor = false;
            this.A2.Click += new System.EventHandler(this.click_button);
            this.A2.MouseEnter += new System.EventHandler(this.enter_button);
            this.A2.MouseLeave += new System.EventHandler(this.leave_button);
            // 
            // B2
            // 
            this.B2.BackColor = System.Drawing.Color.HotPink;
            this.B2.FlatAppearance.BorderColor = System.Drawing.Color.HotPink;
            this.B2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B2.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B2.Location = new System.Drawing.Point(93, 121);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(75, 75);
            this.B2.TabIndex = 5;
            this.B2.UseVisualStyleBackColor = false;
            this.B2.Click += new System.EventHandler(this.click_button);
            this.B2.MouseEnter += new System.EventHandler(this.enter_button);
            this.B2.MouseLeave += new System.EventHandler(this.leave_button);
            // 
            // C2
            // 
            this.C2.BackColor = System.Drawing.Color.HotPink;
            this.C2.FlatAppearance.BorderColor = System.Drawing.Color.HotPink;
            this.C2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.C2.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C2.Location = new System.Drawing.Point(174, 121);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(75, 75);
            this.C2.TabIndex = 6;
            this.C2.UseVisualStyleBackColor = false;
            this.C2.Click += new System.EventHandler(this.click_button);
            this.C2.MouseEnter += new System.EventHandler(this.enter_button);
            this.C2.MouseLeave += new System.EventHandler(this.leave_button);
            // 
            // A3
            // 
            this.A3.BackColor = System.Drawing.Color.HotPink;
            this.A3.FlatAppearance.BorderColor = System.Drawing.Color.HotPink;
            this.A3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.A3.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A3.Location = new System.Drawing.Point(12, 202);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(75, 75);
            this.A3.TabIndex = 7;
            this.A3.UseVisualStyleBackColor = false;
            this.A3.Click += new System.EventHandler(this.click_button);
            this.A3.MouseEnter += new System.EventHandler(this.enter_button);
            this.A3.MouseLeave += new System.EventHandler(this.leave_button);
            // 
            // B3
            // 
            this.B3.BackColor = System.Drawing.Color.HotPink;
            this.B3.FlatAppearance.BorderColor = System.Drawing.Color.HotPink;
            this.B3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B3.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B3.Location = new System.Drawing.Point(93, 202);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(75, 75);
            this.B3.TabIndex = 8;
            this.B3.UseVisualStyleBackColor = false;
            this.B3.Click += new System.EventHandler(this.click_button);
            this.B3.MouseEnter += new System.EventHandler(this.enter_button);
            this.B3.MouseLeave += new System.EventHandler(this.leave_button);
            // 
            // C3
            // 
            this.C3.BackColor = System.Drawing.Color.HotPink;
            this.C3.FlatAppearance.BorderColor = System.Drawing.Color.HotPink;
            this.C3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.C3.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C3.Location = new System.Drawing.Point(174, 202);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(75, 75);
            this.C3.TabIndex = 9;
            this.C3.UseVisualStyleBackColor = false;
            this.C3.Click += new System.EventHandler(this.click_button);
            this.C3.MouseEnter += new System.EventHandler(this.enter_button);
            this.C3.MouseLeave += new System.EventHandler(this.leave_button);
            // 
            // Scoreboard_lbl
            // 
            this.Scoreboard_lbl.AutoSize = true;
            this.Scoreboard_lbl.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scoreboard_lbl.ForeColor = System.Drawing.Color.HotPink;
            this.Scoreboard_lbl.Location = new System.Drawing.Point(281, 40);
            this.Scoreboard_lbl.Name = "Scoreboard_lbl";
            this.Scoreboard_lbl.Size = new System.Drawing.Size(133, 24);
            this.Scoreboard_lbl.TabIndex = 10;
            this.Scoreboard_lbl.Text = "Scoreboard";
            // 
            // PlayerX_lbl
            // 
            this.PlayerX_lbl.AutoSize = true;
            this.PlayerX_lbl.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerX_lbl.ForeColor = System.Drawing.Color.HotPink;
            this.PlayerX_lbl.Location = new System.Drawing.Point(281, 80);
            this.PlayerX_lbl.Name = "PlayerX_lbl";
            this.PlayerX_lbl.Size = new System.Drawing.Size(84, 19);
            this.PlayerX_lbl.TabIndex = 11;
            this.PlayerX_lbl.Text = "Player X:";
            // 
            // PlayerO_lbl
            // 
            this.PlayerO_lbl.AutoSize = true;
            this.PlayerO_lbl.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerO_lbl.ForeColor = System.Drawing.Color.HotPink;
            this.PlayerO_lbl.Location = new System.Drawing.Point(281, 110);
            this.PlayerO_lbl.Name = "PlayerO_lbl";
            this.PlayerO_lbl.Size = new System.Drawing.Size(83, 19);
            this.PlayerO_lbl.TabIndex = 12;
            this.PlayerO_lbl.Text = "Player O:";
            // 
            // Tie_lbl
            // 
            this.Tie_lbl.AutoSize = true;
            this.Tie_lbl.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tie_lbl.ForeColor = System.Drawing.Color.HotPink;
            this.Tie_lbl.Location = new System.Drawing.Point(281, 140);
            this.Tie_lbl.Name = "Tie_lbl";
            this.Tie_lbl.Size = new System.Drawing.Size(55, 19);
            this.Tie_lbl.TabIndex = 13;
            this.Tie_lbl.Text = "Tie/s:";
            // 
            // XScore_lbl
            // 
            this.XScore_lbl.AutoSize = true;
            this.XScore_lbl.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XScore_lbl.ForeColor = System.Drawing.Color.HotPink;
            this.XScore_lbl.Location = new System.Drawing.Point(371, 80);
            this.XScore_lbl.Name = "XScore_lbl";
            this.XScore_lbl.Size = new System.Drawing.Size(19, 19);
            this.XScore_lbl.TabIndex = 14;
            this.XScore_lbl.Text = "0";
            // 
            // OScore_lbl
            // 
            this.OScore_lbl.AutoSize = true;
            this.OScore_lbl.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OScore_lbl.ForeColor = System.Drawing.Color.HotPink;
            this.OScore_lbl.Location = new System.Drawing.Point(370, 110);
            this.OScore_lbl.Name = "OScore_lbl";
            this.OScore_lbl.Size = new System.Drawing.Size(19, 19);
            this.OScore_lbl.TabIndex = 15;
            this.OScore_lbl.Text = "0";
            // 
            // TieScore_lbl
            // 
            this.TieScore_lbl.AutoSize = true;
            this.TieScore_lbl.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TieScore_lbl.ForeColor = System.Drawing.Color.HotPink;
            this.TieScore_lbl.Location = new System.Drawing.Point(370, 140);
            this.TieScore_lbl.Name = "TieScore_lbl";
            this.TieScore_lbl.Size = new System.Drawing.Size(19, 19);
            this.TieScore_lbl.TabIndex = 16;
            this.TieScore_lbl.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.HotPink;
            this.label1.Location = new System.Drawing.Point(272, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "Whose Turn Is It?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.HotPink;
            this.label2.Location = new System.Drawing.Point(323, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 46);
            this.label2.TabIndex = 18;
            this.label2.Text = "X";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(438, 294);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TieScore_lbl);
            this.Controls.Add(this.OScore_lbl);
            this.Controls.Add(this.XScore_lbl);
            this.Controls.Add(this.Tie_lbl);
            this.Controls.Add(this.PlayerO_lbl);
            this.Controls.Add(this.PlayerX_lbl);
            this.Controls.Add(this.Scoreboard_lbl);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button C1;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.Button A3;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button C3;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GameMechanics_MenuTool;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label Scoreboard_lbl;
        private System.Windows.Forms.Label PlayerX_lbl;
        private System.Windows.Forms.Label PlayerO_lbl;
        private System.Windows.Forms.Label Tie_lbl;
        private System.Windows.Forms.Label XScore_lbl;
        private System.Windows.Forms.Label OScore_lbl;
        private System.Windows.Forms.Label TieScore_lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

