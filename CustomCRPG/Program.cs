using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create Player
            Player _player = new Player("Jeremy", 2, 6, 10, 10, 12, 15, 10, 0f);

            //Create Test Enemy
            //Enemy testEnemy = new Enemy("Dummy", 10, 10, 10, 10, 1);

            //Game Loop
            while(true)
            {
                //TEST BATTLE 
                //BattleManager.Battle(_player, testEnemy);


                //Draw Player UI
                //Console.WriteLine("///////////////");
                Console.WriteLine("---------------");
                Console.WriteLine("HEALTH: {0} / {1}", _player.Health, _player.MaxHealth);
                Console.WriteLine("---------------");
                World.DrawMap(_player.XPos,_player.YPos);

                //Get Player Input
                Console.WriteLine();
                string playerInput = Console.ReadLine().ToLower();
                
                //PLAYER COMMANDS
                //MOVEMENT
                if(playerInput.Contains("up") || playerInput == "u")
                {
                    _player.movePlayer(0, 1);
                }
                else if (playerInput.Contains("down") || playerInput == "d")
                {
                    _player.movePlayer(0, -1);
                }
                else if (playerInput.Contains("right") || playerInput == "r")
                {
                    _player.movePlayer(1, 0);
                }
                else if (playerInput.Contains("left") || playerInput == "l")
                {
                    _player.movePlayer(-1, 0);
                }

                //Clear Console
                Console.Clear();
            }
        }
    }
}
