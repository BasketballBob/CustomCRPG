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
            Player _player = new Player(0, 0, 10, 10, 0f);

            //Game Loop
            while(true)
            {
                World.DrawMap();
                Console.ReadLine();
            }
        }
    }
}
