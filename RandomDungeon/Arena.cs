using System;
using System.Collections.Generic;

namespace RandomDungeon
{
    public class Arena
    {
        private List<Enemy> enemies;

        public Arena(List<Enemy> enemies)
        {
            this.enemies = enemies;
        }

        public List<Enemy> GetEnemies()
        {
            return enemies;
        }

        public void SetEnemies(List<Enemy> value)
        {
            enemies = value;
        }

        public void AddEnemy(Enemy enemy)
        {
            enemies.Add(enemy);
        }

        public void RemoveEnemy(Enemy enemy)
        {
            enemies.Remove(enemy);
        }

        // Método Para Mostrar Todos os Inimigos Atuais
        // Exemplo: "Arena: Troll, Skeleton, Ogre"
        public void ShowEnemies()
        {
            Console.WriteLine($"Arena: {enemies}");
        }
        
        // Simula uma Batalha Entre Dois Inimigos
        public void Battle(Enemy attacker, Enemy defender)
        {
            // Subtrai o Ataque do Atacante à Vida do Defensor
            int defHealth = defender.GetHealth();
            int attATK = attacker.GetAttack();

            defHealth -= attATK;
            if(defHealth < 0)
            {
                defHealth = 0;
            }
            defender.SetHealth(defHealth);

            // Garante que a Vida Não Fique Negativa
            // CÓDIGO AQUI
            if(defHealth == 0)
            {
                RemoveEnemy(defender);
            }
            // Se a Vida do Defensor Chegar a 0, Remove-o da Arena
            // CÓDIGO AQUI
        }
    }
}