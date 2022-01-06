using Sayer.Rand;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skill_Simulation
{
     static class Program
    {
        static Random rand = new Random();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        /// <summary>
        /// randomly generates a new player 
        /// </summary>
        /// <returns>Player</returns>
        public static PlayerModel GeneratePlayer()          //TODO: convert to constructor?
        {
            PlayerModel newPlayer = new PlayerModel { Name = GenerateName(), Skill = rand.Next(400, 1600), Elo = 1000, ReflectingElo = 1000, QueueChance = rand.NextDouble(), Consistency = rand.Next(20, 200), Played = 0, Drive = rand.Next(10, 600) / 1000d, Recharge = rand.Next(15, 400) / 1000d, PlayedLast = 0, SkillGain = rand.Next(35, 700) / 10d, SkillDecay = rand.Next(1, 100) / 10000d };
            return newPlayer;
        }
        /// <summary>
        /// random name generator
        /// Uses the most common english syllables and randomly concatenates 2-4 of them
        /// </summary>
        /// <returns>Name</returns>
        public static string GenerateName()
        {
            string[] syllables = new string[] { "TH", "HE", "AN", "ER", "IN", "RE", "ND", "OU", "EN", "ON", "ED", "TO", "IT", "AT", "HA", "THE", "AND", "ING", "HER", "YOU", "VER", "WAS", "HAT", "FOR", "NOT", "THI", "THA", "HIS", "ENT", "ION" };
            int sylAmount = rand.Next(2, 4);
            string name = "";
            for(int i = 0; i < sylAmount; i++)
            {
                name += syllables[rand.Next(0, syllables.Length)];
            }
            return name;
;        }
        /// <summary>
        /// randomly select winner of a match
        /// based on their win chances, which are calcutaled using their skill rating
        /// based on standard Elo calculation
        /// </summary>
        /// <param name="playerA"></param>
        /// <param name="playerB"></param>
        /// <returns>winner of the match</returns>
        public static PlayerModel DetermineWinner(PlayerModel playerA, PlayerModel playerB)
        {
            int currSkillDiffA = rand.Next(-playerA.Consistency, playerA.Consistency);      //temporarily adjust skill rating based on players consistency
            int currSkillDiffB = rand.Next(-playerB.Consistency, playerB.Consistency);
            double skillA = playerA.Skill+currSkillDiffA;
            double skillB = playerB.Skill+currSkillDiffB;
            double trSkillA = Math.Pow(10, (skillA / 400d));
            double trSkillB = Math.Pow(10, (skillB / 400d));
            double winChanceA = trSkillA / (trSkillA + trSkillB);
            if (rand.NextDouble().CompareTo(winChanceA) < 1)            //determine winner
                return playerA;
            else
                return playerB;
        }
        /// <summary>
        /// calculate the change of Elo for a match 
        /// </summary>
        /// <param name="eloW">winner Elo of the match</param>
        /// <param name="eloL">loser Elo of the match</param>
        /// <returns>Elo difference to be applied to both players Elo ratings</returns>
        public static double DetermineEloChange(double eloW, double eloL)
        {
            int k = 32;
            double trEloW = Math.Pow(10, (eloW / 400d));
            double trEloL = Math.Pow(10, (eloL / 400d));
            double winChanceA = trEloW / (trEloW + trEloL);
            double change = k * (1-winChanceA);
            return Math.Round(change, 2);
        }
        /// <summary>
        /// for all players determine if they want to play in the next round, based on their queue chance
        /// also adjust queue chance for all players which didnt enter the queue for the next round
        /// </summary>
        /// <param name="players">list of all players</param>
        /// <returns>list of all players that want to play</returns>
        public static List<PlayerModel> GetQueuedPlayers(List<PlayerModel> players)
        {
            List<PlayerModel> queuedPlayers = new List<PlayerModel>();
            foreach (PlayerModel player in players)
            {
                if (rand.NextDouble().CompareTo(player.QueueChance) < 1)        //determine if player queues
                {
                    queuedPlayers.Add(player); 
                }
                else            //all players that dont enter queue
                {
                    if (player.PlayedLast == 1)     //player stops playing

                        player.QueueChance = 0;
                    else                            //player might start playing again
                        player.QueueChance += player.Recharge;                  //TODO: queue chance can reach > 100%
                    player.PlayedLast = 0;
                    player.Skill =  Math.Round((player.Skill * (0.989 + player.SkillDecay)), 2);
                }
                    
            }
            return queuedPlayers;
        }
        /// <summary>
        /// create matches for all given players
        /// if odd number of players, ignore last player and adjust his queue chance
        /// </summary>
        /// <param name="players">list of players to start a match with</param>
        /// <param name="matchRound">round of the match to create</param>
        /// <returns>list of matches that happened</returns>
        public static List<MatchModel> CreateMatches(List<PlayerModel> players, int matchRound)
        {
            List<MatchModel> matchesNew = new List<MatchModel>();
            PlayerModel playerA;
            PlayerModel playerB;
            players.Shuffle();       //randomize player list as basic random matchmaking
            List<PlayerModel> playersUpdated = new List<PlayerModel>();
            while(players.Count() >= 2) //select matchups
            {
                playerA = players.FirstOrDefault();
                players.RemoveAt(0);
                playerB = players.FirstOrDefault();
                players.RemoveAt(0);
                var matchResult = StartMatch(playerA, playerB, matchRound);  //start the match
                playersUpdated.AddRange(matchResult.Item1); 
                matchesNew.Add(matchResult.Item2);             
            }
            if(players.Count() == 1)        //last leftover player
            {
                PlayerModel leftoverP = players.ElementAt(0);
                if (leftoverP.PlayedLast == 1)

                    leftoverP.QueueChance = 0;
                else
                    leftoverP.QueueChance += leftoverP.Recharge;
                leftoverP.PlayedLast = 0;
                leftoverP.Skill = Math.Round((leftoverP.Skill * (0.989 + leftoverP.SkillDecay)), 2);
                playersUpdated.Add(leftoverP);
            }
            return matchesNew;
        }
        /// <summary>
        /// process a match between two given players
        /// update values of both players
        /// </summary>
        /// <param name="playerA"></param>
        /// <param name="playerB"></param>     
        /// <param name="matchRound">round of the match to create</param>
        /// <returns>list of players in this match and the match object</returns>
        public static (List<PlayerModel>, MatchModel) StartMatch(PlayerModel playerA, PlayerModel playerB, int matchRound)
        {
            PlayerModel winner = DetermineWinner(playerA, playerB);
            PlayerModel loser;
            if (winner == playerA)
                loser = playerB;
            else
                loser = playerA;
            double eloChange = Program.DetermineEloChange(winner.Elo, loser.Elo);
            double reflEloChange = Program.DetermineEloChange(winner.ReflectingElo, loser.ReflectingElo);
            MatchModel match = new MatchModel() {   Winner = winner.Name, WSkill = winner.Skill, WElo = winner.Elo, //create match before updating players to preserve old values
                                                    Loser = loser.Name, LSkill = loser.Skill, LElo = loser.Elo, EloChange = eloChange,
                                                    WID = winner.ID, LID = loser.ID, Round = matchRound };
            winner.Elo += eloChange;
            loser.Elo -= eloChange;
            winner.ReflectingElo += reflEloChange;
            loser.ReflectingElo -= reflEloChange;
            winner.Skill += Math.Round((winner.SkillGain * ((2000 - winner.Skill) / 2000)),2);
            loser.Skill += Math.Round((loser.SkillGain * ((2000 - loser.Skill) / 2000)), 2);
            winner.Played++;
            loser.Played++;
            winner.PlayedLast = 1;
            loser.PlayedLast = 1;
            if (winner.QueueChance < winner.Drive)      //make sure queue chance doesn't go negative
                winner.QueueChance = 0;
            else
                winner.QueueChance -= winner.Drive;
            if (loser.QueueChance < loser.Drive)
                loser.QueueChance = 0;
            else
                loser.QueueChance -= loser.Drive;
            List<PlayerModel> playersUpdated = new List<PlayerModel> {winner, loser};
            return (playersUpdated, match);
        }
        /// <summary>
        /// calculates the average difference between the Elo Rank and Skill Rank for every player in a list of given players
        /// </summary>
        /// <param name="players">list of players</param>
        /// <returns>rounded double average difference</returns>
        public static double CalculateEloRankDiff(List<PlayerModel> players)
        {
            double playerCount = players.Count();
            double totalDifference = 0;
            foreach(PlayerModel player in players)
            {
                totalDifference += Math.Abs(player.SkillRank - player.EloRank);
            }
            return Math.Round((totalDifference/playerCount), 2);
        }

        public static void CalculateReflElo(List<MatchModel> lastRoundMatches, List<MatchModel> allMatches, List<PlayerModel> allPlayers)
        {
            int roundsToConsider = 10;          
            List<PlayerModel> currentPlayers = GetCurrentPlayers(lastRoundMatches, allPlayers);         //list of all players of this round
            List<MatchModel> relevantMatches = GetRelevantMatches(allMatches, roundsToConsider);        //list of all matches of all rounds to consider
            List<PlayerModel> affectedPlayers = new List<PlayerModel>();                                //list of all players to update ReflElo
            List<MatchModel> affectedMatches = new List<MatchModel>();                                  //list of all matches containing those players
            var toCalculate = GetAffectedPlayers(currentPlayers, relevantMatches, allPlayers);
            affectedPlayers.AddRange(toCalculate.Item1);
            affectedMatches.AddRange(lastRoundMatches);                                                 //add matches of this round
            affectedMatches.AddRange(toCalculate.Item2);                                                //add discovered matches
            affectedMatches = affectedMatches.OrderBy(m => m.Round).ToList();
            int currentRound = affectedMatches.Last().Round;
            foreach( MatchModel m in affectedMatches)
            {
                int relativeRound = m.Round - (currentRound - roundsToConsider);                          //round number only considering relevant Matches
                PlayerModel winner = affectedPlayers.Find(p => p.ID == m.WID);
                PlayerModel loser = affectedPlayers.Find(p => p.ID == m.LID);
                double ageFactor = (1 - Math.Pow(1 - (double)relativeRound / (double)roundsToConsider, 2));      // 1-(1-x/10)^2     -> asymptotic function: rate of change decreases with x
                double reflEloChange = Math.Round(DetermineEloChange(winner.ReflectingElo, loser.ReflectingElo) * ageFactor, 2);   //older matches are less important than newer matches   
                winner.ReflectingElo += reflEloChange;
                loser.ReflectingElo -= reflEloChange;
            }
        }
        /// <summary>
        /// get a list of all players participating in a given list of matches
        /// </summary>
        /// <param name="lastRoundMatches">list of matches in the last round</param>
        /// <param name="allPlayers">list of all players</param>
        /// <returns>list of players</returns>
        public static List<PlayerModel> GetCurrentPlayers(List<MatchModel> lastRoundMatches, List<PlayerModel> allPlayers)
        {
            List<PlayerModel> currentPlayers = new List<PlayerModel>();
            foreach( MatchModel match in lastRoundMatches)
            {
                currentPlayers.Add(allPlayers.Find(p => p.ID == match.WID));
                currentPlayers.Add(allPlayers.Find(p => p.ID == match.LID));
            }
            return currentPlayers;
        }
        /// <summary>
        /// get a list of all matches that happened in the last rounds 
        /// </summary>
        /// <param name="allMatches">list of all matches</param>
        /// <param name="rounds">amount of rounds to be considered</param>
        /// <returns>list of matches</returns>
        public static List<MatchModel> GetRelevantMatches(List<MatchModel> allMatches, int rounds)
        {
            int currentRound = allMatches.Last().Round;     //TODO: only works if allMatches is not Null
            int earliestRound = currentRound - rounds + 1;
            List<MatchModel> relevantMatches = new List<MatchModel>();
            foreach(MatchModel match in allMatches)
            {
                if (match.Round >= earliestRound) 
                    relevantMatches.Add(match);
            }
            return relevantMatches;
        }
        /// <summary>
        /// given a list of players and matches, find all players that participated in any match with any of the given players
        /// check for all new found players aswell, until no new players are found
        /// </summary>
        /// <param name="currentPlayers">list of players to check</param>
        /// <param name="relevantMatches">list of matches to check in</param>
        /// <param name="allPlayers">list of all players</param>
        /// <returns>list of relevant players and all additonal matches they play in</returns>
        public static (List<PlayerModel>, List<MatchModel>) GetAffectedPlayers(List<PlayerModel> currentPlayers, List<MatchModel> relevantMatches, List<PlayerModel> allPlayers)
        {
            List<MatchModel> affectedMatchesNew = new List<MatchModel>();
            List<PlayerModel> affectedPlayers = new List<PlayerModel>();
            affectedPlayers.AddRange(currentPlayers);
            List<PlayerModel> toConsider = new List<PlayerModel>();
            toConsider.AddRange(currentPlayers);
            List<MatchModel> relevMatchesToCheck = new List<MatchModel>();
            int currentRound = relevantMatches.Last().Round;
            foreach(MatchModel match in relevantMatches){       //filter out all matches of the current round
                if (match.Round != currentRound)
                    relevMatchesToCheck.Add(match);
            }
            while(toConsider.Count > 0)             //repeat until all players in relevant matches have been checked
            {
                PlayerModel currentP = toConsider.ElementAt(0);
                for (int i = 0; i < relevMatchesToCheck.Count; i++)       //check all relevant matches for current player
                {
                    MatchModel match = relevMatchesToCheck.ElementAt(i);
                    if(match.WID == currentP.ID)                    //relevant player is winner
                    {
                        if(!affectedPlayers.Any(p => p.ID == match.LID))                        //loser is new  
                        {
                            affectedPlayers.Add(allPlayers.Find(p => p.ID == match.LID));       //add opponent      TODO: searches all players, could search only players in relevMatchesToCheck
                            toConsider.Add(affectedPlayers.Last());
                        }
                        affectedMatchesNew.Add(match);                                          //add match
                        relevMatchesToCheck.Remove(match);                                      //prevents checking match again for loser 
                        i--;                                                                    //prevents skipping next match
                    }
                    if (match.LID == currentP.ID)                                               //relevant player is loser
                    {
                        if(!affectedPlayers.Any(p => p.ID == match.WID))
                        {
                            affectedPlayers.Add(allPlayers.Find(p => p.ID == match.WID));
                            toConsider.Add(affectedPlayers.Last());
                        }
                        affectedMatchesNew.Add(match);
                        relevMatchesToCheck.Remove(match);
                        i--;
                    }
                }
                toConsider.Remove(currentP);                         //checked all matches for this player
            }
            return (affectedPlayers, affectedMatchesNew);
        }
    }
}
