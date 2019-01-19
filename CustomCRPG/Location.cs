using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCRPG
{
    public class Location
    {
        //Location Variables
        public int ID;
        public string Name;
        public char Icon;
        public int XPos;
        public int YPos;
        public int EncounterRate = 5; //This Value Is The Denominator Of The Probability (Example: 1/5)
        //public Enemy EncounterEnemy;
        public int EncounterID;

        public Location(int iD, string name, char icon, int xPos, int yPos, int encounterID)
        {
            ID = iD;
            Name = name;
            Icon = icon;
            XPos = xPos;
            YPos = yPos;
            EncounterID = encounterID;
        }
    }
}
