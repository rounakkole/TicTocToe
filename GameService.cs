using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTocToe
{
    internal class GameService
    {



        public int IsOver(int[] RepeatArray)
        {
            int Winner = 3;

            foreach (int num in RepeatArray)
            {
                if (num < 1)
                {
                    Winner = 0;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                //147 258 369
                if (RepeatArray[i] == RepeatArray[i + 3] && RepeatArray[i] == RepeatArray[i + 6] && RepeatArray[i] != 0)
                {
                    Winner = RepeatArray[i];
                }
                //123 456 789
                else if (RepeatArray[i * 3] == RepeatArray[i * 3 + 1] && RepeatArray[i * 3] == RepeatArray[i * 3 + 2] && RepeatArray[i * 3] != 0)
                {
                    Winner = RepeatArray[i * 3];
                }

            }

            //159 357
            if (RepeatArray[4] == RepeatArray[4 - 4] && RepeatArray[4] == RepeatArray[4 + 4] && RepeatArray[4] != 0)
            {
                Winner = RepeatArray[4];
            }
            else if (RepeatArray[4] == RepeatArray[4 - 2] && RepeatArray[4] == RepeatArray[4 + 2] && RepeatArray[4] != 0)
            {
                Winner = RepeatArray[4];
            }

            return Winner;
        }




        public void Print(int[] RepeatArray)
        {

            for (int i = 0; i < 9; i++)
            {
                Console.Write("\t{0}", RepeatArray[i]);
                if ((i + 3) % 3 == 2)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                }
            }
        }




        public int GetPosition(int[] RepeatArray, bool PlayTurn)
        {
            int Position;
            Random random = new Random();
            int[] RepeatArrayLocal = new int[9];

            do
            {
                if (PlayTurn)
                {
                    Position = random.Next(0, 9);
                    for (int k = 0; k < 9; k++)
                    {
                        RepeatArray.CopyTo(RepeatArrayLocal, 0);
                        if (RepeatArrayLocal[k] == 0)
                        {
                            RepeatArrayLocal[k] = 2;
                        }
                        int Winner = 0;

                        Winner = this.IsOver(RepeatArrayLocal);
                        if (Winner == 2)
                        {
                            Position = k;
                            break;
                        }
                    }
                }
                else
                {
                    Console.Write("enter: ");
                    Position = ((Convert.ToInt32(Console.ReadLine()) - 1) % 9);
                }

            } while (RepeatArray[Position] > 0);
            return Position;
        }

    }
}
