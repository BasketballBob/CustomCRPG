using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCRPG
{
    class World
    {
        //World Variables
        static int Height = 8;
        static int Width = 6;

        //Location List
        List<Location> Locations = new List<Location>();

        //Define Locations

        //Generate World Array
        static int LOCATION_WALGREENS = 0;
        





        public static Location LocationHere (int XPos, int YPos)
        {
            //Check All Locations In World
            foreach(Location currentLocation in Locations)
            {
                //Check If Location Is At Current Position
                if(currentLocation.XPos == XPos && currentLocation.YPos == YPos)
                {
                    return currentLocation;
                }
            }

            //Return Nothing If Nothing Is Found
            return null; 
        }

        public static void DrawMap()
        {
            for(int YP = Height - 1; YP > 0; YP--) 
            {
                for(int XP = 0; XP < Width; XP++)
                {
                    //Draw Map Symbol
                    if (LocationHere(XP,YP) != null)
                    {
                        Console.Write(LocationHere(XP, YP).Icon);
                    }
                    //Draw Default
                    else
                    {
                        Console.Write("_");
                    }
                }

                //Add Extra Line (For Each Row)
                Console.Write("\n");
            }
        }
    }
}
