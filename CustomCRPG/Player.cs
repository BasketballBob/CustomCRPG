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
        public string Name;
        public int XPos;
        public int YPos;
        public int Health;
        public int MaxHealth;
        public int Attack;
        public int Defense;
        public int Speed;
        public float Cash;
        Random rand = new Random();

        public Player(string name, int xPos, int yPos, int health, int maxHealth, int attack, int defense, int speed, float cash)
        {
            Name = name;
            XPos = xPos;
            YPos = yPos;
            Health = health;
            MaxHealth = maxHealth;
            Attack = attack;
            Defense = defense;
            Speed = speed;
            Cash = cash;
        }

        public void movePlayer(int xPos, int yPos)
        {
            //Move Player If Possible
            if(World.LocationHere(XPos+xPos,YPos+yPos) != null)
            {
                //Move Player
                XPos += xPos;
                YPos += yPos;

                //Roll For Encounter 
                if(rand.Next(1,World.LocationHere(XPos,YPos).EncounterRate) == 1)
                {
                    Console.WriteLine("YOU ENCOUNTER AN ENEMY!");
                    Console.ReadLine();
                    BattleManager.Battle(this, new Enemy(World.EnemyByID(World.LocationHere(XPos, YPos).EncounterID)));
                }

                //Show Moved To Location
                //Console.WriteLine("You have move to {0}", World.LocationHere(XPos, YPos));

            }
            //Don't Move Otherwise
            else
            {
                //Console.WriteLine("You're unable to move there.");
            }
        }
    }
}
