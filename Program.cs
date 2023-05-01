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
            int Winner = 0;
            bool PlayTurn = true;
            GameService gameService = new GameService();


            while (Winner < 1)
            {
                int Position = 0;
                Position = gameService.GetPosition(RepeatArray, PlayTurn);

                if (PlayTurn)
                {
                    RepeatArray[Position] = 1;
                    gameService.Print(RepeatArray);
                    PlayTurn = false;
                }
                else
                {
                    RepeatArray[Position] = 2;
                    PlayTurn = true;
                }

                Winner = gameService.IsOver(RepeatArray);

            }
            gameService.Print(RepeatArray);
            Console.WriteLine("winner: {0}", Winner);

        }
    }
}

