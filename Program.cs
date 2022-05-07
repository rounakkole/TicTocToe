// See https://aka.ms/new-console-template for more information
using System;

namespace TicTocToe
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("\t Tic Toc Toe");
            GamePlay();
        }


        public static void GamePlay()
        {
            int[] RepeatArray = new int[9];
            bool IsOver = false;
            bool PlayTurn = true;
            GameService gameService = new GameService();


            while (IsOver == false)
            {
                int Position = gameService.GetPosition(RepeatArray);

                if (PlayTurn)
                {
                    RepeatArray[Position] = 1;
                    PlayTurn = false;
                }
                else
                {
                    RepeatArray[Position] = 2;
                    PlayTurn = true;
                }

                IsOver = gameService.GameOver(RepeatArray);
            }


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
    }
}
