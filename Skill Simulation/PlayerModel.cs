using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skill_Simulation
{
    public class PlayerModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Skill { get; set; }
        public double Elo { get; set; }
        public double ReflectingElo { get; set; }
        public double QueueChance { get; set; }
        public int Consistency { get; set; }
        public int SkillRank { get; set; }
        public int EloRank { get; set; }
        public int ReflEloRank { get; set; }
        public int Played { get; set; }
        public double Drive { get; set; }
        public double Recharge { get; set; }
        public int PlayedLast { get; set; }
        public double SkillGain { get; set; }
        public double SkillDecay { get; set; }

    }
}
