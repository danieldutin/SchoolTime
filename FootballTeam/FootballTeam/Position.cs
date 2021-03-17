using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeam
{
    public interface IPosition
    {
        public string GetSkill(Player player);
        public string Reaction(Player player);
    }
}
