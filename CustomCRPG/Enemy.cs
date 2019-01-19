using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCRPG
{
    public class Enemy
    {
        //Enemy Variables
        public int ID;
        public string Name;
        public int Health;
        public int MaxHealth;
        public int Attack;
        public int Defense;
        public int Speed;

        public Enemy(int iD, string name, int health, int maxHealth, int attack, int defense, int speed)
        {
            ID = iD;
            Name = name;
            Health = health;
            MaxHealth = maxHealth;
            Attack = attack;
            Defense = defense;
            Speed = speed;
        }

        public Enemy(Enemy clone)
        {
            ID = clone.ID;
            Name = clone.Name;
            Health = clone.Health;
            MaxHealth = clone.MaxHealth;
            Attack = clone.Attack;
            Defense = clone.Defense;
            Speed = clone.Speed;
        }
    }
}
