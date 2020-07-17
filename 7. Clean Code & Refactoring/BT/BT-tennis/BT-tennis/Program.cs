using System;

namespace BT_tennis
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = TennisGame.GetScore("tung", "vui", 0, 1);
            Console.WriteLine(result);
        }
    }
}
