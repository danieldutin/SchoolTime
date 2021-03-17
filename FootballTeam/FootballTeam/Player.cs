using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace FootballTeam
{
    public class Player
    {
        public int Number { get; set; }
        public IPosition Position { get; set; }

        

        public string React()
        {
            return Position.Reaction(this);
        }

        public string WhatYouDo()
        {
            return Position.GetSkill(this);
        }

    }
}
