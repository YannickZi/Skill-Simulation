
namespace Skill_Simulation
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.playerListView = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Player = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Skill = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.skillRank = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Elo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.eloRank = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.reflectingElo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.reflEloRank = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.played = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.matchListView = new System.Windows.Forms.ListView();
            this.matchID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.winner = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.wSkill = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.wElo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.loser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lSkill = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lElo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.eloChange = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.round = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.maxRoundDisplay = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 50);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Players";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Amount to add:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(131, 23);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(48, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // playerListView
            // 
            this.playerListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Player,
            this.skillRank,
            this.eloRank,
            this.reflEloRank,
            this.Skill,
            this.Elo,
            this.reflectingElo,
            this.played});
            this.playerListView.HideSelection = false;
            this.playerListView.Location = new System.Drawing.Point(221, 50);
            this.playerListView.Margin = new System.Windows.Forms.Padding(4);
            this.playerListView.Name = "playerListView";
            this.playerListView.Size = new System.Drawing.Size(675, 557);
            this.playerListView.TabIndex = 3;
            this.playerListView.UseCompatibleStateImageBehavior = false;
            this.playerListView.View = System.Windows.Forms.View.Details;
            this.playerListView.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 38;
            // 
            // Player
            // 
            this.Player.Text = "Player";
            this.Player.Width = 76;
            // 
            // Skill
            // 
            this.Skill.Text = "Skill";
            this.Skill.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Skill.Width = 55;
            // 
            // skillRank
            // 
            this.skillRank.Text = "Skill Rk";
            this.skillRank.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.skillRank.Width = 48;
            // 
            // Elo
            // 
            this.Elo.Text = "Elo";
            this.Elo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Elo.Width = 55;
            // 
            // eloRank
            // 
            this.eloRank.Text = "Elo Rk";
            this.eloRank.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.eloRank.Width = 48;
            // 
            // reflectingElo
            // 
            this.reflectingElo.Text = "Refl Elo";
            this.reflectingElo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.reflectingElo.Width = 55;
            // 
            // reflEloRank
            // 
            this.reflEloRank.Text = "Refl Elo Rk";
            this.reflEloRank.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.reflEloRank.Width = 66;
            // 
            // played
            // 
            this.played.Text = "Played";
            this.played.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.played.Width = 45;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(16, 97);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 28);
            this.button2.TabIndex = 4;
            this.button2.Text = "Remove all Players";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // matchListView
            // 
            this.matchListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.matchID,
            this.winner,
            this.wSkill,
            this.wElo,
            this.loser,
            this.lSkill,
            this.lElo,
            this.eloChange,
            this.round});
            this.matchListView.HideSelection = false;
            this.matchListView.Location = new System.Drawing.Point(962, 50);
            this.matchListView.Margin = new System.Windows.Forms.Padding(4);
            this.matchListView.Name = "matchListView";
            this.matchListView.Size = new System.Drawing.Size(749, 557);
            this.matchListView.TabIndex = 5;
            this.matchListView.UseCompatibleStateImageBehavior = false;
            this.matchListView.View = System.Windows.Forms.View.Details;
            this.matchListView.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // matchID
            // 
            this.matchID.Text = "ID";
            this.matchID.Width = 38;
            // 
            // winner
            // 
            this.winner.Text = "Winner";
            this.winner.Width = 78;
            // 
            // wSkill
            // 
            this.wSkill.Text = "Skill";
            this.wSkill.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.wSkill.Width = 55;
            // 
            // wElo
            // 
            this.wElo.Text = "Elo";
            this.wElo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.wElo.Width = 55;
            // 
            // loser
            // 
            this.loser.Text = "Loser";
            this.loser.Width = 78;
            // 
            // lSkill
            // 
            this.lSkill.Text = "Skill";
            this.lSkill.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lSkill.Width = 55;
            // 
            // lElo
            // 
            this.lElo.Text = "Elo";
            this.lElo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lElo.Width = 55;
            // 
            // eloChange
            // 
            this.eloChange.Text = "EloChange";
            this.eloChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.eloChange.Width = 68;
            // 
            // round
            // 
            this.round.Text = "Round";
            this.round.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Player List";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(959, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Match History";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1167, 23);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Filter by Player ID:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(1298, 20);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(48, 22);
            this.textBox4.TabIndex = 13;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(131, 221);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(52, 22);
            this.textBox5.TabIndex = 14;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 224);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Round amount:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Default;
            this.button4.Location = new System.Drawing.Point(16, 253);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(144, 28);
            this.button4.TabIndex = 16;
            this.button4.Text = "Simulate";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(218, 611);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(211, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Average Rank Difference of Elo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(465, 610);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "0";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(675, 23);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Sort by";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1416, 23);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(181, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "Show the last          Rounds";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "SkillRank",
            "EloRank",
            "ReflEloRank"});
            this.comboBox1.Location = new System.Drawing.Point(736, 18);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 21;
            this.comboBox1.Text = "SkillRank";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // maxRoundDisplay
            // 
            this.maxRoundDisplay.Location = new System.Drawing.Point(1507, 20);
            this.maxRoundDisplay.Margin = new System.Windows.Forms.Padding(4);
            this.maxRoundDisplay.Name = "maxRoundDisplay";
            this.maxRoundDisplay.Size = new System.Drawing.Size(33, 22);
            this.maxRoundDisplay.TabIndex = 22;
            this.maxRoundDisplay.Text = "10";
            this.maxRoundDisplay.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(218, 632);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(240, 17);
            this.label11.TabIndex = 23;
            this.label11.Text = "Average Rank Difference of Refl Elo:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(465, 632);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(16, 17);
            this.label12.TabIndex = 24;
            this.label12.Text = "0";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1763, 681);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.maxRoundDisplay);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.matchListView);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.playerListView);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "View";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView playerListView;
        private System.Windows.Forms.ColumnHeader Player;
        private System.Windows.Forms.ColumnHeader Skill;
        private System.Windows.Forms.ColumnHeader Elo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ListView matchListView;
        private System.Windows.Forms.ColumnHeader matchID;
        private System.Windows.Forms.ColumnHeader winner;
        private System.Windows.Forms.ColumnHeader wSkill;
        private System.Windows.Forms.ColumnHeader wElo;
        private System.Windows.Forms.ColumnHeader loser;
        private System.Windows.Forms.ColumnHeader lSkill;
        private System.Windows.Forms.ColumnHeader lElo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader eloChange;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ColumnHeader skillRank;
        private System.Windows.Forms.ColumnHeader eloRank;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ColumnHeader round;
        private System.Windows.Forms.ColumnHeader played;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox maxRoundDisplay;
        private System.Windows.Forms.ColumnHeader reflectingElo;
        private System.Windows.Forms.ColumnHeader reflEloRank;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}