using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCRPG
{
    public static class BattleManager
    {
        //Battle Variables
        static Random Rand = new Random();
        static bool PlayerTurn;

        //Battle Loop
        public static void Battle(Player player, Enemy enemy)
        {
            //Initialize Battle
            PlayerTurn = false;
            if (player.Speed >= enemy.Speed)
            {
                PlayerTurn = true;
            }
            Console.Clear();
            Console.WriteLine("{0} has encountered a {1} in combat!", player.Name, enemy.Name);
            Console.WriteLine("The battle begins!");

            //Battle Loop
            while (true)
            {
                //Await Player Input
                Console.ReadLine();

                //Player Attack
                if (PlayerTurn)
                {
                    //Determine / Execute Attack
                    int halfAttack = (int)Math.Round((double)player.Attack / 2);
                    int attackVal = (halfAttack+Rand.Next(halfAttack,player.Attack))-enemy.Defense;
                    if (attackVal < 0) attackVal = 0;
                    enemy.Health -= attackVal;
                    Console.WriteLine("Player {0} attacks the {1} for {2} damage!", player.Name, enemy.Name, attackVal);

                }
                //Enemy Attack
                else
                {
                    //Determine / Execute Attack
                    int halfAttack = (int)Math.Round((double)enemy.Attack / 2);
                    int attackVal = (halfAttack + Rand.Next(halfAttack, enemy.Attack))-player.Defense;
                    if (attackVal < 0) attackVal = 0;
                    player.Health -= attackVal;
                    Console.WriteLine("The {0} hits {1} for {2} damage!", enemy.Name, player.Name, attackVal);
                }

                //SWITCH TURNS!
                PlayerTurn = !PlayerTurn;

                //End Battle Once One Is Dead
                if (player.Health <= 0 || enemy.Health <= 0)
                {
                    //Player Victory 
                    if(enemy.Health <= 0)
                    {
                        Console.WriteLine("\n{0} has defeated the {1} and won the battle!", player.Name, enemy.Name);
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    }

                    //Enemy Victory (Loss)
                    else
                    {
                        Console.WriteLine("\n{0} HAS BEEN DEFEATED! GAME OVER!", player.Name.ToUpper());
                        Console.ReadLine();
                        Environment.Exit(0);
                        Console.Clear();
                        break;
                    }
                }
            }
        }
    }
}
