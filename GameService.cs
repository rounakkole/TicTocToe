using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTocToe
{
    internal class GameService
    {

        public int GetPosition(int[] RepeatArray)
        {
            Random random = new Random();

            bool IsRepeat;
            int Position;
            do
            {
                IsRepeat = false;
                Position = random.Next(0, 9);
                if (RepeatArray[Position] > 0)
                {
                    IsRepeat = true;
                }


            } while (IsRepeat == true);
            return Position;
        }

        public bool GameOver(int[] RepeatArray)
        {
            bool IsOver = false;
            bool IsEmpty = false;
            foreach (int num in RepeatArray)
            {
                if (num < 1)
                {
                    IsEmpty = true;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                if (RepeatArray[i] == RepeatArray[i + 3] && RepeatArray[i] == RepeatArray[i + 6] && RepeatArray[i] != 0)
                {
                    IsOver = true;
                }

                if (RepeatArray[i * 3] == RepeatArray[i * 3 + 1] && RepeatArray[i * 3] == RepeatArray[i * 3 + 2] && RepeatArray[i * 3] != 0)
                {
                    IsOver = true;
                }
            }


            if (RepeatArray[0] == RepeatArray[4] && RepeatArray[0] == RepeatArray[8] && RepeatArray[0] != 0)
            {
                IsOver = true;
            }
            else if (RepeatArray[2] == RepeatArray[4] && RepeatArray[2] == RepeatArray[6] && RepeatArray[2] != 0)
            {
                IsOver = true;
            }


            if (IsEmpty == false)
            {
                IsOver = true;
            }
            return IsOver;
        }
    }
}
