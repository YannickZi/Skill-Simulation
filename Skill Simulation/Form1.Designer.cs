
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
            this.queueChance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.consistency = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.played = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.drive = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.recharge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.playedLast = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.skillGain = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.skillDecay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
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
            this.reflectingElo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.reflEloRank = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Players";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Amount to add:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(98, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(37, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // playerListView
            // 
            this.playerListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Player,
            this.Skill,
            this.skillRank,
            this.Elo,
            this.eloRank,
            this.reflectingElo,
            this.reflEloRank,
            this.queueChance,
            this.consistency,
            this.played,
            this.drive,
            this.recharge,
            this.playedLast,
            this.skillGain,
            this.skillDecay});
            this.playerListView.HideSelection = false;
            this.playerListView.Location = new System.Drawing.Point(166, 41);
            this.playerListView.Name = "playerListView";
            this.playerListView.Size = new System.Drawing.Size(702, 441);
            this.playerListView.TabIndex = 3;
            this.playerListView.UseCompatibleStateImageBehavior = false;
            this.playerListView.View = System.Windows.Forms.View.Details;
            this.playerListView.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 26;
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
            this.Skill.Width = 36;
            // 
            // skillRank
            // 
            this.skillRank.Text = "Skill Rk";
            this.skillRank.Width = 48;
            // 
            // Elo
            // 
            this.Elo.Text = "Elo";
            this.Elo.Width = 36;
            // 
            // eloRank
            // 
            this.eloRank.Text = "Elo Rk";
            this.eloRank.Width = 48;
            // 
            // queueChance
            // 
            this.queueChance.Text = "Queue%";
            this.queueChance.Width = 53;
            // 
            // consistency
            // 
            this.consistency.Text = "Consistency";
            this.consistency.Width = 69;
            // 
            // played
            // 
            this.played.Text = "Played";
            this.played.Width = 45;
            // 
            // drive
            // 
            this.drive.Text = "Drive";
            this.drive.Width = 37;
            // 
            // recharge
            // 
            this.recharge.Text = "Recharge";
            this.recharge.Width = 59;
            // 
            // playedLast
            // 
            this.playedLast.Text = "Last";
            this.playedLast.Width = 32;
            // 
            // skillGain
            // 
            this.skillGain.Text = "S. Gain";
            this.skillGain.Width = 48;
            // 
            // skillDecay
            // 
            this.skillDecay.Text = "S. Decay";
            this.skillDecay.Width = 57;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Location = new System.Drawing.Point(12, 92);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 23);
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
            this.matchListView.Location = new System.Drawing.Point(907, 41);
            this.matchListView.Name = "matchListView";
            this.matchListView.Size = new System.Drawing.Size(530, 441);
            this.matchListView.TabIndex = 5;
            this.matchListView.UseCompatibleStateImageBehavior = false;
            this.matchListView.View = System.Windows.Forms.View.Details;
            this.matchListView.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // matchID
            // 
            this.matchID.Text = "ID";
            this.matchID.Width = 34;
            // 
            // winner
            // 
            this.winner.Text = "Winner";
            this.winner.Width = 61;
            // 
            // wSkill
            // 
            this.wSkill.Text = "Skill";
            this.wSkill.Width = 38;
            // 
            // wElo
            // 
            this.wElo.Text = "Elo";
            this.wElo.Width = 44;
            // 
            // loser
            // 
            this.loser.Text = "Loser";
            // 
            // lSkill
            // 
            this.lSkill.Text = "Skill";
            this.lSkill.Width = 39;
            // 
            // lElo
            // 
            this.lElo.Text = "Elo";
            this.lElo.Width = 43;
            // 
            // eloChange
            // 
            this.eloChange.Text = "EloChange";
            this.eloChange.Width = 68;
            // 
            // round
            // 
            this.round.Text = "Round";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Player List";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(904, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Match History";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 170);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(39, 20);
            this.textBox2.TabIndex = 8;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(81, 170);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(39, 20);
            this.textBox3.TabIndex = 9;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "vs";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Location = new System.Drawing.Point(27, 196);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "Play";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1061, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Filter by Player ID:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(1159, 19);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(37, 20);
            this.textBox4.TabIndex = 13;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(95, 254);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(40, 20);
            this.textBox5.TabIndex = 14;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Round amount:";
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Default;
            this.button4.Location = new System.Drawing.Point(12, 280);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "Simulate";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(163, 485);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Average Rank Difference of Elo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(330, 485);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "0";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(396, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Sort by";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1247, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Show the last          Rounds";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "SkillRank",
            "EloRank"});
            this.comboBox1.Location = new System.Drawing.Point(436, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 21;
            this.comboBox1.Text = "SkillRank";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // maxRoundDisplay
            // 
            this.maxRoundDisplay.Location = new System.Drawing.Point(1315, 19);
            this.maxRoundDisplay.Name = "maxRoundDisplay";
            this.maxRoundDisplay.Size = new System.Drawing.Size(26, 20);
            this.maxRoundDisplay.TabIndex = 22;
            this.maxRoundDisplay.Text = "10";
            this.maxRoundDisplay.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // reflectingElo
            // 
            this.reflectingElo.Text = "Refl Elo";
            // 
            // reflEloRank
            // 
            this.reflEloRank.Text = "Refl Elo Rk";
            this.reflEloRank.Width = 66;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1475, 640);
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
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.matchListView);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.playerListView);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
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
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ColumnHeader eloChange;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ColumnHeader queueChance;
        private System.Windows.Forms.ColumnHeader consistency;
        private System.Windows.Forms.ColumnHeader skillRank;
        private System.Windows.Forms.ColumnHeader eloRank;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ColumnHeader round;
        private System.Windows.Forms.ColumnHeader played;
        private System.Windows.Forms.ColumnHeader drive;
        private System.Windows.Forms.ColumnHeader recharge;
        private System.Windows.Forms.ColumnHeader playedLast;
        private System.Windows.Forms.ColumnHeader skillGain;
        private System.Windows.Forms.ColumnHeader skillDecay;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox maxRoundDisplay;
        private System.Windows.Forms.ColumnHeader reflectingElo;
        private System.Windows.Forms.ColumnHeader reflEloRank;
    }
}