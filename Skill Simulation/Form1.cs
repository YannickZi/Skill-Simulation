using Sayer.Rand;
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
        string idA = "";                    //ID of player 1 in a match                         TODO: just use text boxes
        string idB = "";                    //ID of player 2 in a match
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
            players = SqliteDataAccess.LoadPlayers(comboBox1.Text);
            foreach (PlayerModel player in players)
            {
                ListViewItem nextPlayer = new ListViewItem(player.ID.ToString()); //add all relevant values of a player to the list
                nextPlayer.SubItems.Add(player.Name);
                nextPlayer.SubItems.Add(player.Skill.ToString());
                nextPlayer.SubItems.Add(player.SkillRank.ToString());
                nextPlayer.SubItems.Add(player.Elo.ToString());
                nextPlayer.SubItems.Add(player.EloRank.ToString());
                nextPlayer.SubItems.Add(player.ReflectingElo.ToString());
                nextPlayer.SubItems.Add(player.ReflEloRank.ToString());
                double queuePerc = Math.Round(player.QueueChance * 100, 1);  //transform percentage 
                nextPlayer.SubItems.Add(queuePerc.ToString() + "%");
                nextPlayer.SubItems.Add(player.Consistency.ToString());
                nextPlayer.SubItems.Add(player.Played.ToString());
                nextPlayer.SubItems.Add(player.Drive.ToString());
                nextPlayer.SubItems.Add(player.Recharge.ToString());
                nextPlayer.SubItems.Add(player.PlayedLast.ToString());
                nextPlayer.SubItems.Add(player.SkillGain.ToString());
                nextPlayer.SubItems.Add(player.SkillDecay.ToString());
                playerListView.Items.Add(nextPlayer);
            }
            label8.Text = Program.CalculateEloRankDiff(players).ToString();           
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
                roundFilter = Int32.Parse(maxRoundDisplay.Text);
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
                addPlayerAmount = Int32.Parse(textBox1.Text);
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

        private void label4_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// start match between two chosen players
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)      //TODO take StartMatch output, update other players aswell
        {
            matchRound++;
            Program.StartMatch(SqliteDataAccess.GetPlayer(idA), SqliteDataAccess.GetPlayer(idB), matchRound);
            LoadMatchList();
            LoadPlayerList();
        }
        /// <summary>
        /// pick first player
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            idA = textBox2.Text;
        }
        /// <summary>
        /// pick second player
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            idB = textBox3.Text;
        }
        /// <summary>
        /// filter match history by player id
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            idMatchFilter = textBox4.Text;
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
                simulRoundAmount = Int32.Parse(textBox5.Text);
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
                matchesNewTotal.AddRange(matchesNewRound);
                matches.AddRange(matchesNewRound);
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
    }
    

}
