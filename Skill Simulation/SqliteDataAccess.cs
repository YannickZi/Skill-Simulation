using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Transactions;

namespace Skill_Simulation
{
    public class SqliteDataAccess
    {
        /// <summary>
        /// load all players from the DB
        /// </summary>
        /// /// <param name="sortColumn">column to sort by</param>
        /// <returns>list of all players</returns>
        public static List<PlayerModel> LoadPlayers(string sortColumn)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<PlayerModel>("select * from vPlayerFull order by " + sortColumn, new DynamicParameters()).ToList();
                return output;
            }
        }
        /// <summary>
        /// save a player into the DB
        /// </summary>
        /// <param name="player"></param>
        public static void SavePlayers(List<PlayerModel> players)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Open();
                using (var transaction = cnn.BeginTransaction())
                {
                    cnn.Execute("insert into Player (Name, Skill, Elo, ReflectingElo, QueueChance, Consistency, Played, Drive, Recharge, PlayedLast, SkillGain, SkillDecay) values (@Name, @Skill, @Elo, @ReflectingElo, @QueueChance, @Consistency, @Played, @Drive, @Recharge, @PlayedLast, @SkillGain, @SkillDecay)", players, transaction: transaction);
                    transaction.Commit();
                }
            }

        }
        /// <summary>
        /// delete all player entries from the DB
        /// </summary>
        public static void DeletePlayers()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("delete from Player");
            }

        }
        /// <summary>
        /// load a specific player from the DB
        /// </summary>
        /// <param name="id">id of the player to be loaded</param>
        /// <returns>one player</returns>
        public static PlayerModel GetPlayer(string id)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.QuerySingle<PlayerModel>("select * from Player where ID = " + id, new DynamicParameters());
                return output;
            }
        }     
        /// <summary>
        /// update a specific player in the DB
        /// </summary>
        /// <param name="player">player to be updated</param>
        public static void UpdatePlayer(PlayerModel player)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("update Player set Skill = @SKill, Elo = @Elo, ReflectingElo = @ReflectingElo, QueueChance = @QueueChance, Played = @Played, PlayedLast = @PlayedLast where ID = @ID", player);       //works?
            }
        }
        /// <summary>
        /// update a list of players in the DB
        /// </summary>
        /// <param name="players">players to be updated</param>
        public static void UpdatePlayers(List<PlayerModel> players)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Open();
                using (var transaction = cnn.BeginTransaction())
                {
                    cnn.Execute("update Player set Skill = @SKill, Elo = @Elo, ReflectingElo = @ReflectingElo, QueueChance = @QueueChance, Played = @Played, PlayedLast = @PlayedLast where ID = @ID", players, transaction: transaction);       //works?
                    transaction.Commit();
                }

            }
        }
        /// <summary>
        /// update the elo value from a specific player in the DB
        /// </summary>
        /// <param name="id">id of the player to be updated</param>
        /// <param name="elo">elo of the player to be updated</param>
        public static void UpdatePlayerElo(string id, int elo)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("update Player set Elo = " + elo + " where ID = " + id);
            }

        }
        /// <summary>
        /// load all matches from the DB
        /// </summary>
        /// <param name="roundAmount">amount of rounds to be loaded</param>
        /// <param name="matchRound">last played round</param>
        /// <returns>list of matches</returns>
        public static List<MatchModel> LoadMatches(int roundAmount, int matchRound)
        {
            int lastToHide = 0;
            if (roundAmount != 0)
                lastToHide = matchRound - roundAmount;
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<MatchModel>("select * from Match where Round > " + lastToHide, new DynamicParameters());
                return output.ToList();
            }
        }
        /// <summary>
        /// load amount of rounds already simulated
        /// </summary>
        /// <returns>round amount</returns>
        public static int LoadMaxRound()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.QuerySingle<int>("select IfNull(Max(Round),0) from Match", new DynamicParameters());
                return output;
            }
        }
        /// <summary>
        /// load all matches of a specific player from the DB
        /// </summary>
        /// <param name="id">id of the player to be loaded</param>
        /// <param name="roundAmount">amount of rounds to be loaded</param>
        /// <param name="matchRound">last played round</param>
        /// <returns>list of matches</returns>
        public static List<MatchModel> LoadMatchesFiltered(string id, int roundAmount, int matchRound)      //TODO: combine with LoadMatches
        {
            int lastToHide = 0;
            if (roundAmount != 0)
                lastToHide = matchRound - roundAmount;
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<MatchModel>("select * from Match where (WID = " + id + " or LID = " + id + ") and Round > " + lastToHide, new DynamicParameters());
                return output.ToList();
            }
        }
        /// <summary>
        /// save a match to the DB
        /// </summary>
        /// <param name="match"></param>
        public static void SaveMatch(MatchModel match)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Match (Winner, WSkill, WElo, Loser, LSkill, LElo, EloChange, WID, LID, Round) values (@Winner, @WSkill, @WElo, @Loser, @LSkill, @LElo, @EloChange, @WID, @LID, @Round)", match);
            }

        }
        /// <summary>
        /// save a list of matches into the DB
        /// </summary>
        /// <param name="matches"></param>
        public static void SaveMatches(List<MatchModel> matches)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Open();
                using (var transaction = cnn.BeginTransaction())
                {
                    cnn.Execute("insert into Match (Winner, WSkill, WElo, Loser, LSkill, LElo, EloChange, WID, LID, Round) values (@Winner, @WSkill, @WElo, @Loser, @LSkill, @LElo, @EloChange, @WID, @LID, @Round)", matches, transaction: transaction);
                    transaction.Commit();
                }
            }

        }
        /// <summary>
        /// delet all match entries from the DB
        /// </summary>
        public static void DeleteMatches()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("delete from Match");
            }

        }
        /// <summary>
        /// load the connection string of the DB from the config
        /// </summary>
        /// <param name="id">name of the connection string</param>
        /// <returns>connection string</returns>
        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
