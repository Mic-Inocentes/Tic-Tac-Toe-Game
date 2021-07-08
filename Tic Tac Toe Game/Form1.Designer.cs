
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
            this.Scoreboard_lbl = new System.Windows.Forms.Label();
            this.XScore_lbl = new System.Windows.Forms.Label();
            this.OScore_lbl = new System.Windows.Forms.Label();
            this.TieScore_lbl = new System.Windows.Forms.Label();
            this.A1_bttn = new System.Windows.Forms.Button();
            this.PlayerX_lbl = new System.Windows.Forms.Label();
            this.PlayerO_lbl = new System.Windows.Forms.Label();
            this.Tie_lbl = new System.Windows.Forms.Label();
            this.A2_bttn = new System.Windows.Forms.Button();
            this.A3_bttn = new System.Windows.Forms.Button();
            this.B1_bttn = new System.Windows.Forms.Button();
            this.B2_bttn = new System.Windows.Forms.Button();
            this.B3_bttn = new System.Windows.Forms.Button();
            this.C1_bttn = new System.Windows.Forms.Button();
            this.C2_bttn = new System.Windows.Forms.Button();
            this.C3_bttn = new System.Windows.Forms.Button();
            this.Turn2_lbl = new System.Windows.Forms.Label();
            this.Turn1_lbl = new System.Windows.Forms.Label();
            this.NewGame_bttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            // A1_bttn
            // 
            this.A1_bttn.BackColor = System.Drawing.Color.HotPink;
            this.A1_bttn.FlatAppearance.BorderColor = System.Drawing.Color.HotPink;
            this.A1_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.A1_bttn.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A1_bttn.Location = new System.Drawing.Point(12, 24);
            this.A1_bttn.Name = "A1_bttn";
            this.A1_bttn.Size = new System.Drawing.Size(75, 75);
            this.A1_bttn.TabIndex = 17;
            this.A1_bttn.UseVisualStyleBackColor = false;
            this.A1_bttn.Click += new System.EventHandler(this.A1_bttn_Click);
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
            // A2_bttn
            // 
            this.A2_bttn.BackColor = System.Drawing.Color.HotPink;
            this.A2_bttn.FlatAppearance.BorderColor = System.Drawing.Color.HotPink;
            this.A2_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.A2_bttn.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A2_bttn.Location = new System.Drawing.Point(93, 24);
            this.A2_bttn.Name = "A2_bttn";
            this.A2_bttn.Size = new System.Drawing.Size(75, 75);
            this.A2_bttn.TabIndex = 18;
            this.A2_bttn.UseVisualStyleBackColor = false;
            this.A2_bttn.Click += new System.EventHandler(this.A2_bttn_Click);
            // 
            // A3_bttn
            // 
            this.A3_bttn.BackColor = System.Drawing.Color.HotPink;
            this.A3_bttn.FlatAppearance.BorderColor = System.Drawing.Color.HotPink;
            this.A3_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.A3_bttn.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A3_bttn.Location = new System.Drawing.Point(174, 24);
            this.A3_bttn.Name = "A3_bttn";
            this.A3_bttn.Size = new System.Drawing.Size(75, 75);
            this.A3_bttn.TabIndex = 19;
            this.A3_bttn.UseVisualStyleBackColor = false;
            this.A3_bttn.Click += new System.EventHandler(this.A3_bttn_Click);
            // 
            // B1_bttn
            // 
            this.B1_bttn.BackColor = System.Drawing.Color.HotPink;
            this.B1_bttn.FlatAppearance.BorderColor = System.Drawing.Color.HotPink;
            this.B1_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B1_bttn.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B1_bttn.Location = new System.Drawing.Point(12, 105);
            this.B1_bttn.Name = "B1_bttn";
            this.B1_bttn.Size = new System.Drawing.Size(75, 75);
            this.B1_bttn.TabIndex = 20;
            this.B1_bttn.UseVisualStyleBackColor = false;
            this.B1_bttn.Click += new System.EventHandler(this.B1_bttn_Click);
            // 
            // B2_bttn
            // 
            this.B2_bttn.BackColor = System.Drawing.Color.HotPink;
            this.B2_bttn.FlatAppearance.BorderColor = System.Drawing.Color.HotPink;
            this.B2_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B2_bttn.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B2_bttn.Location = new System.Drawing.Point(93, 105);
            this.B2_bttn.Name = "B2_bttn";
            this.B2_bttn.Size = new System.Drawing.Size(75, 75);
            this.B2_bttn.TabIndex = 21;
            this.B2_bttn.UseVisualStyleBackColor = false;
            this.B2_bttn.Click += new System.EventHandler(this.B2_bttn_Click);
            // 
            // B3_bttn
            // 
            this.B3_bttn.BackColor = System.Drawing.Color.HotPink;
            this.B3_bttn.FlatAppearance.BorderColor = System.Drawing.Color.HotPink;
            this.B3_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B3_bttn.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B3_bttn.Location = new System.Drawing.Point(174, 105);
            this.B3_bttn.Name = "B3_bttn";
            this.B3_bttn.Size = new System.Drawing.Size(75, 75);
            this.B3_bttn.TabIndex = 22;
            this.B3_bttn.UseVisualStyleBackColor = false;
            this.B3_bttn.Click += new System.EventHandler(this.B3_bttn_Click);
            // 
            // C1_bttn
            // 
            this.C1_bttn.BackColor = System.Drawing.Color.HotPink;
            this.C1_bttn.FlatAppearance.BorderColor = System.Drawing.Color.HotPink;
            this.C1_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.C1_bttn.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C1_bttn.Location = new System.Drawing.Point(12, 186);
            this.C1_bttn.Name = "C1_bttn";
            this.C1_bttn.Size = new System.Drawing.Size(75, 75);
            this.C1_bttn.TabIndex = 23;
            this.C1_bttn.UseVisualStyleBackColor = false;
            this.C1_bttn.Click += new System.EventHandler(this.C1_bttn_Click);
            // 
            // C2_bttn
            // 
            this.C2_bttn.BackColor = System.Drawing.Color.HotPink;
            this.C2_bttn.FlatAppearance.BorderColor = System.Drawing.Color.HotPink;
            this.C2_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.C2_bttn.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C2_bttn.Location = new System.Drawing.Point(93, 186);
            this.C2_bttn.Name = "C2_bttn";
            this.C2_bttn.Size = new System.Drawing.Size(75, 75);
            this.C2_bttn.TabIndex = 24;
            this.C2_bttn.UseVisualStyleBackColor = false;
            this.C2_bttn.Click += new System.EventHandler(this.C2_bttn_Click);
            // 
            // C3_bttn
            // 
            this.C3_bttn.BackColor = System.Drawing.Color.HotPink;
            this.C3_bttn.FlatAppearance.BorderColor = System.Drawing.Color.HotPink;
            this.C3_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.C3_bttn.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C3_bttn.Location = new System.Drawing.Point(174, 186);
            this.C3_bttn.Name = "C3_bttn";
            this.C3_bttn.Size = new System.Drawing.Size(75, 75);
            this.C3_bttn.TabIndex = 25;
            this.C3_bttn.UseVisualStyleBackColor = false;
            this.C3_bttn.Click += new System.EventHandler(this.C3_bttn_Click);
            // 
            // Turn2_lbl
            // 
            this.Turn2_lbl.AutoSize = true;
            this.Turn2_lbl.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Turn2_lbl.ForeColor = System.Drawing.Color.HotPink;
            this.Turn2_lbl.Location = new System.Drawing.Point(272, 200);
            this.Turn2_lbl.Name = "Turn2_lbl";
            this.Turn2_lbl.Size = new System.Drawing.Size(154, 19);
            this.Turn2_lbl.TabIndex = 26;
            this.Turn2_lbl.Text = "Whose Turn Is It?";
            // 
            // Turn1_lbl
            // 
            this.Turn1_lbl.AutoSize = true;
            this.Turn1_lbl.Font = new System.Drawing.Font("Cooper Black", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Turn1_lbl.ForeColor = System.Drawing.Color.HotPink;
            this.Turn1_lbl.Location = new System.Drawing.Point(328, 219);
            this.Turn1_lbl.Name = "Turn1_lbl";
            this.Turn1_lbl.Size = new System.Drawing.Size(47, 42);
            this.Turn1_lbl.TabIndex = 27;
            this.Turn1_lbl.Text = "X";
            // 
            // NewGame_bttn
            // 
            this.NewGame_bttn.BackColor = System.Drawing.Color.HotPink;
            this.NewGame_bttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewGame_bttn.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewGame_bttn.Location = new System.Drawing.Point(60, 281);
            this.NewGame_bttn.Name = "NewGame_bttn";
            this.NewGame_bttn.Size = new System.Drawing.Size(129, 31);
            this.NewGame_bttn.TabIndex = 28;
            this.NewGame_bttn.Text = "New Game";
            this.NewGame_bttn.UseVisualStyleBackColor = false;
            this.NewGame_bttn.Click += new System.EventHandler(this.NewGame_bttn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(438, 336);
            this.Controls.Add(this.NewGame_bttn);
            this.Controls.Add(this.Turn1_lbl);
            this.Controls.Add(this.Turn2_lbl);
            this.Controls.Add(this.C3_bttn);
            this.Controls.Add(this.C2_bttn);
            this.Controls.Add(this.C1_bttn);
            this.Controls.Add(this.B3_bttn);
            this.Controls.Add(this.B2_bttn);
            this.Controls.Add(this.B1_bttn);
            this.Controls.Add(this.A3_bttn);
            this.Controls.Add(this.A2_bttn);
            this.Controls.Add(this.A1_bttn);
            this.Controls.Add(this.TieScore_lbl);
            this.Controls.Add(this.OScore_lbl);
            this.Controls.Add(this.XScore_lbl);
            this.Controls.Add(this.Tie_lbl);
            this.Controls.Add(this.PlayerO_lbl);
            this.Controls.Add(this.PlayerX_lbl);
            this.Controls.Add(this.Scoreboard_lbl);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Scoreboard_lbl;
        private System.Windows.Forms.Label XScore_lbl;
        private System.Windows.Forms.Label OScore_lbl;
        private System.Windows.Forms.Label TieScore_lbl;
        private System.Windows.Forms.Button A1_bttn;
        private System.Windows.Forms.Label PlayerX_lbl;
        private System.Windows.Forms.Label PlayerO_lbl;
        private System.Windows.Forms.Label Tie_lbl;
        private System.Windows.Forms.Button A2_bttn;
        private System.Windows.Forms.Button A3_bttn;
        private System.Windows.Forms.Button B1_bttn;
        private System.Windows.Forms.Button B2_bttn;
        private System.Windows.Forms.Button B3_bttn;
        private System.Windows.Forms.Button C1_bttn;
        private System.Windows.Forms.Button C2_bttn;
        private System.Windows.Forms.Button C3_bttn;
        private System.Windows.Forms.Label Turn2_lbl;
        private System.Windows.Forms.Label Turn1_lbl;
        private System.Windows.Forms.Button NewGame_bttn;
    }
}

