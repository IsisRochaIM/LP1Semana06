using System;

namespace MyGame
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string inp3 = args[0];
            int enemNum = int.Parse(inp3);

            Enemy[] enemies = new Enemy[enemNum];

            for(int i = 0; i < enemNum; i++)
            {
                Console.Write($"Nome do inimigo {i + 1}: ");
                string enemyName = Console.ReadLine();
                enemies[i] = new Enemy(enemyName);
            }
            for(int i = 0; i< enemies.Length; i++)
            {
                enemies[i].TakeDamage(50);
                enemies[i].PickupPowerUp(PowerUp.Health, 80);
                Console.WriteLine($"{enemies[i].GetName()} {enemies[i].GetHealth()} {enemies[i].GetShield()}" );
            }
        }
    }
}
