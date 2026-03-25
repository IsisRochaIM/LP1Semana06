using System;

namespace RandDice
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string inp1 = args[0];
            int n = int.Parse(inp1);

            string inp2 = args[1];
            int s = int.Parse(inp2);

            Random dice = new Random(s);
            
            int sum = 0;

            for(int i = 0; i < n; i++)
            {
                sum += dice.Next(1, 7);
            }

            Console.WriteLine(sum);
        }
    }
}
