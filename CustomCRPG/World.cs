using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCRPG
{
    static class World
    {
        //World Variables
        static int Height = 8;
        static int Width = 6;

        //Important Lists
        static List<Location> Locations = new List<Location>();
        static List<Enemy> Enemies = new List<Enemy>();

        //Enemy References
        const int ENEMY_PROWLER =     0;
        const int ENEMY_CRISPYCRAB =  1;
        const int ENEMY_CRACKERHEAD = 2;
        const int ENEMY_SMARMYSMITH = 3;

        //Fill In Database
        static World()
        {
            AddLocations();
            AddEnemies();
        }
      
        public static Location LocationHere(int XPos, int YPos)
        {
            //Check All Locations In World
            foreach (Location currentLocation in Locations)
            {
                //Check If Location Is At Current Position
                if (currentLocation.XPos == XPos && currentLocation.YPos == YPos)
                {
                    return currentLocation;
                }
            }

            //Return Nothing If Nothing Is Found
            return null;
        }

        public static void DrawMap(int HereX, int HereY)
        {
            //Map Header
            Console.WriteLine("////MAP////////");
            //Console.WriteLine("YOU ARE HERE X");
            //Console.WriteLine("");

            for (int YP = Height; YP > 0; YP--) 
            {
                Console.Write("| ");

                for (int XP = 0; XP < Width; XP++)
                {
                    //Draw Here Position
                    if (XP == HereX && YP == HereY)
                    {
                        Console.Write("X");
                    }
                    //Draw Map Symbol
                    else if (LocationHere(XP, YP) != null)
                    {
                        Console.Write(LocationHere(XP, YP).Icon);
                    }
                    //Draw Default
                    else
                    {
                        Console.Write("-");
                    }

                    //Add Space
                    Console.Write(" ");
                }

                //Add Extra Line (For Each Row)
                Console.Write("|");
                Console.Write("\n");
            }

            //Map Footer
            //Console.WriteLine("");
            Console.WriteLine("///////////////");
        }

        private static void AddLocations()
        {
            //Grasslands
            Locations.Add(new Location(0, "Grasslands 1", 'g', 0, 8, ENEMY_PROWLER));
            Locations.Add(new Location(1, "Grasslands 2", 'g', 0, 7, ENEMY_PROWLER));
            Locations.Add(new Location(2, "Grasslands 3", 'g', 0, 6, ENEMY_PROWLER));
            Locations.Add(new Location(3, "Grasslands 4", 'g', 1, 6, ENEMY_PROWLER));
            Locations.Add(new Location(4, "Grasslands 5", 'g', 2, 6, ENEMY_PROWLER));

            //Waterfront
            Locations.Add(new Location(5, "Waterfront 1", 'w', 3, 8, ENEMY_CRISPYCRAB));
            Locations.Add(new Location(6, "Waterfront 2", 'w', 3, 7, ENEMY_CRISPYCRAB));
            Locations.Add(new Location(7, "Waterfront 3", 'w', 3, 6, ENEMY_CRISPYCRAB));
            Locations.Add(new Location(8, "Waterfront 4", 'w', 4, 7, ENEMY_CRISPYCRAB));
            Locations.Add(new Location(9, "Waterfront 5", 'w', 5, 7, ENEMY_CRISPYCRAB));
            Locations.Add(new Location(10, "Waterfront 6", 'w', 5, 6, ENEMY_CRISPYCRAB));

            //Crunchy Town
            Locations.Add(new Location(11, "CrunchyTown 1", 'c', 0, 1, ENEMY_CRACKERHEAD));
            Locations.Add(new Location(12, "CrunchyTown 2", 'c', 1, 1, ENEMY_CRACKERHEAD));
            Locations.Add(new Location(13, "CrunchyTown 3", 'c', 0, 2, ENEMY_CRACKERHEAD));
            Locations.Add(new Location(14, "CrunchyTown 4", 'c', 1, 2, ENEMY_CRACKERHEAD));
            Locations.Add(new Location(15, "CrunchyTown 5", 'c', 2, 2, ENEMY_CRACKERHEAD));
            Locations.Add(new Location(16, "CrunchyTown 6", 'c', 1, 3, ENEMY_CRACKERHEAD));
            Locations.Add(new Location(17, "CrunchyTown 7", 'c', 2, 3, ENEMY_CRACKERHEAD));
            Locations.Add(new Location(18, "CrunchyTown 8", 'c', 2, 4, ENEMY_CRACKERHEAD));

            //Metalworks
            Locations.Add(new Location(19, "Metalworks 1", 'm', 5, 3, ENEMY_SMARMYSMITH));
            Locations.Add(new Location(20, "Metalworks 2", 'm', 4, 3, ENEMY_SMARMYSMITH));
            Locations.Add(new Location(21, "Metalworks 3", 'm', 4, 4, ENEMY_SMARMYSMITH));
            Locations.Add(new Location(22, "Metalworks 4", 'm', 3, 4, ENEMY_SMARMYSMITH));
            Locations.Add(new Location(23, "Metalworks 5", 'm', 3, 5, ENEMY_SMARMYSMITH));
        }

        private static void AddEnemies()
        {
            //Grasslands
            Enemies.Add(new Enemy(ENEMY_PROWLER, "Prowler", 10, 10, 10, 8, 10));

            //Waterfront
            Enemies.Add(new Enemy(ENEMY_CRISPYCRAB, "Crispy Crab", 10, 10, 13, 9, 10));

            //Crunchytown
            Enemies.Add(new Enemy(ENEMY_CRACKERHEAD, "Crackerhead", 10, 10, 17, 10, 10));

            //Metalworks
            Enemies.Add(new Enemy(ENEMY_SMARMYSMITH, "Smarmy Smith", 10, 10, 50, 10, 10));
        }

        static public Enemy EnemyByID(int ID)
        {
            foreach(Enemy enemy in Enemies)
            {
                //Check For Enemy With ID
                if(enemy.ID == ID)
                {
                    return enemy;
                }
            }

            //Return Nothing If Nothing
            return null;
        }
    }
}
