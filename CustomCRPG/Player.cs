using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCRPG
{
    public class Player
    {
        //Player Variables
        public int XPos = 0;
        public int YPos = 0;
        public int Health = 100;
        public int MaxHealth = 100;
        public float Cash = 0f;

        public Player(int xPos, int yPos, int health, int maxHealth, float cash)
        {
            XPos = xPos;
            YPos = yPos;
            Health = health;
            MaxHealth = maxHealth;
            Cash = cash;
        }
    }
}
