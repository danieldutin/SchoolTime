using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeam
{
    public class AttackPlayer : IPosition
    {
        public string GetSkill()
        {
            return "I am scoring";
        }

        public string Reaction()
        {
            return "Shoot";
        }
    }
}
