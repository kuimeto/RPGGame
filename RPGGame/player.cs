using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame
{
    internal class player
    {
        public string Name;
        private int STRENGTH, DEXTERITY, CONSTITUTION, INTELIGENCE, WISDOM, CHARISMA;
        
        public player(string name, int str, int dex, int con, int intl, int wis, int cha)
        {
            Name = name;
            STRENGTH = str;
            DEXTERITY = dex;
            CONSTITUTION = con;
            INTELIGENCE = intl;
            WISDOM = wis;
            CHARISMA = cha;
        }
    }
}
