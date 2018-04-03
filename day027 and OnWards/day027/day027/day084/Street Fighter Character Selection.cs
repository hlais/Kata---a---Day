using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars6Kata
{
    class Street_Fighter_Character_Selection
    {
        public static string[] StreetFighterSelection(string[][] fighters, int[] position, string[] moves)
        {
            int x = 0;
            int y = 0;

            string[] fightersIteration = new string[moves.Length];
            string selection = "";

            for (int i = 0; i < moves.Length; i++)
            {
                selection = moves[i];
                switch (selection)
                {
                    case "left":
                        x--;
                        if (x == -1)
                        {
                            x = fighters[y].Length - 1;
                        }
                        if (x == fighters[y].Length)
                        {
                            x = 0;
                        }
                        fightersIteration[i] = fighters[y][x];
                        break;

                    case "right":
                        x++;
                        if (x == -1)
                        {
                            x = fighters[y].Length;
                        }
                        if (x == fighters[y].Length)
                        {
                            x = 0;
                        }
                        fightersIteration[i] = fighters[y][x];
                        break;

                    case "up":
                        y--;
                        if (y == -1)
                        {
                            y = 0;
                        }
                        fightersIteration[i] = fighters[y][x];
                        break;

                    case "down":
                        y++;
                        if (y == 2)
                        {
                            y = 1;
                        }
                        fightersIteration[i] = fighters[y][x];
                        break;

                }
            }
            return fightersIteration;
        }
    }   
}
