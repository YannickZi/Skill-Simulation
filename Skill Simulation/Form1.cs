﻿using Sayer.Rand;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skill_Simulation
{
    public partial class Form1 : Form
    {
        List<PlayerModel> players = new List<PlayerModel>();
        List<MatchModel> matches = new List<MatchModel>();
        int addPlayerAmount = 0;            //amount of players to add
        int simulRoundAmount = 0;           //amount of rounds to simulate
        int matchRound;
        string idMatchFilter = "";          //ID of player to filter match history

        /// <summary>
        /// initialize GUI
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            matchRound = SqliteDataAccess.LoadMaxRound();
            LoadPlayerList();
            LoadMatchList();
        }

        /// <summary>
        /// load players from DB into GUI
        /// </summary>
        private void LoadPlayerList()
        {
            playerListView.Items.Clear();
            players = SqliteDataAccess.LoadPlayers(comboBox1.Text);         //filtered by dropdown list
            foreach (PlayerModel player in players)
            {
                ListViewItem nextPlayer = new ListViewItem(player.ID.ToString()); //add all relevant values of a player to the list
                nextPlayer.SubItems.Add(player.Name);
                nextPlayer.SubItems.Add(player.SkillRank.ToString());
                nextPlayer.SubItems.Add(player.EloRank.ToString());
                nextPlayer.SubItems.Add(player.ReflEloRank.ToString());
                nextPlayer.SubItems.Add(player.Skill.ToString());
                nextPlayer.SubItems.Add(player.Elo.ToString());
                nextPlayer.SubItems.Add(player.ReflectingElo.ToString());
                nextPlayer.SubItems.Add(player.Played.ToString());
                playerListView.Items.Add(nextPlayer);
            }
            var eloDiffs = Program.CalculateEloRankDiffs(players);
            label8.Text = eloDiffs.Item1.ToString();
            label12.Text = eloDiffs.Item2.ToString();   
        }
        /// <summary>
        /// load matches from DB into GUI
        /// </summary>
        private void LoadMatchList()
        {
            matchListView.Items.Clear();
            int roundFilter;            //check if round filter is empty
            if (string.IsNullOrEmpty(maxRoundDisplay.Text))
                roundFilter = 0;
            else
                try
                {
                   roundFilter = Int32.Parse(maxRoundDisplay.Text);
                }
                catch(FormatException exc)
                {
                   roundFilter = 0;
                }
            if (idMatchFilter == "")        //check if match history is filtered
                matches = SqliteDataAccess.LoadMatches(roundFilter, matchRound);
            else
                matches = SqliteDataAccess.LoadMatchesFiltered(idMatchFilter, roundFilter, matchRound);
            foreach (MatchModel match in matches)
            {
                ListViewItem nextMatch = new ListViewItem(match.ID.ToString());    //add all relevant values of a match to the list
                nextMatch.SubItems.Add(match.Winner);
                nextMatch.SubItems.Add(match.WSkill.ToString());
                nextMatch.SubItems.Add(match.WElo.ToString());
                nextMatch.SubItems.Add(match.Loser);
                nextMatch.SubItems.Add(match.LSkill.ToString());
                nextMatch.SubItems.Add(match.LElo.ToString());
                nextMatch.SubItems.Add(match.EloChange.ToString());
                nextMatch.SubItems.Add(match.Round.ToString());
                matchListView.Items.Add(nextMatch);
            }
        }

        /// <summary>
        /// change the amount of players to add
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if ((textBox1.Text) == "")
                addPlayerAmount = 0;
            else
                try
                {
                    addPlayerAmount = Int32.Parse(textBox1.Text);
                }
                catch(FormatException exc)
                {
                    addPlayerAmount = 0;
                }

        }
        /// <summary>
        /// table of players
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// create new players and add them to the DB
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            List<PlayerModel> newPlayers = new List<PlayerModel>();
            for (int i = 0; i < addPlayerAmount; i++)
            {
                PlayerModel newPlayer = Program.GeneratePlayer();
                newPlayers.Add(newPlayer);
            }
            SqliteDataAccess.SavePlayers(newPlayers);
            LoadPlayerList();

        }
        /// <summary>
        /// delete all data from DB
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            SqliteDataAccess.DeletePlayers();
            SqliteDataAccess.DeleteMatches();
            matchRound = 0;
            LoadPlayerList();
            LoadMatchList();
        }
        /// <summary>
        /// table of all matches
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// filter match history by player id
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            idMatchFilter = textBox4.Text;
            try                         //make sure ID is an integer
            {
                Int32.Parse(idMatchFilter);
            }
            catch (FormatException exc)
            {
                idMatchFilter = "";
            }
            LoadMatchList();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// change the amount of rounds to simulate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if ((textBox5.Text) == "")
                simulRoundAmount = 0;
            else
                try
                {
                    simulRoundAmount = Int32.Parse(textBox5.Text);
                }
                catch(FormatException exc)
                {
                    simulRoundAmount = 0;
                }
                
        }
        /// <summary>
        /// simulate specified amount of rounds
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            List<PlayerModel> queuedPlayers;
            List<MatchModel> matchesNewTotal = new List<MatchModel>();
            for (int i = 0; i < simulRoundAmount; i++)
            {
                List<MatchModel> matchesNewRound = new List<MatchModel>();
                queuedPlayers = Program.GetQueuedPlayers(players);
                if (queuedPlayers.Count >= 2)
                    matchRound++;
                for (int j = 0; j < queuedPlayers.Count; j++)
                {
                    matchesNewRound.AddRange(Program.CreateMatches(queuedPlayers, matchRound));
                }
                matchesNewTotal.AddRange(matchesNewRound);              //for saving into the DB
                matches.AddRange(matchesNewRound);                      //for immmediate use in calculations
                if(matchesNewRound.Count > 0)
                    Program.CalculateReflElo(matchesNewRound, matches, players);
            }
            SqliteDataAccess.SaveMatches(matchesNewTotal);
            SqliteDataAccess.UpdatePlayers(players);
            LoadMatchList();
            LoadPlayerList();

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Player list sort order dropdown
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPlayerList();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// match history max round filter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            LoadMatchList();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
    

}
