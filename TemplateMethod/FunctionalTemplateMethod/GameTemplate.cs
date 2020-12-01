using System;

namespace TemplateMethod.FunctionalTemplateMethod
{
    public static class GameTemplate
    {
        public static void Run(
            Action start,
            Action takeTurn,
            Func<bool> haveWinner,
            Func<int> winningPlayer)
        {
            start();
            while (!haveWinner())
                takeTurn();
            Console.WriteLine($"Player {winningPlayer()} wins.");
        }
    }
}