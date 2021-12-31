using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skill_Simulation
{
    public class MatchModel
    {
        public int ID { get; set; }
        public string Winner { get; set; }
        public string Loser { get; set; }
        public double WSkill { get; set; }
        public double WElo { get; set; }
        public double LSkill { get; set; }
        public double LElo { get; set; }
        public double EloChange { get; set; }
        public int WID { get; set; }          
        public int LID { get; set; }
        public int Round { get; set; }
    }
}
