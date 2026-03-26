using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Threading.Tasks;

namespace MyGame
{
    public class Enemy
    {
        private string name;
        private float health;
        private float shield;

        private static int powerUpCount;

        static Enemy()
        {
            powerUpCount = 0;
        }
        public Enemy(string name)
        {
            SetName(name);
            health = 100;
            shield = 0;
        }

        public string GetName()
        {
            return name;
        }

        public float GetHealth()
        {
            return health;
        }

         public float GetShield()
        {
            return shield;
        }
        public void TakeDamage(float damage)
        {
            shield -= damage;
            if (shield < 0)
            {
                float damageStillToInflict = -shield;
                shield = 0;
                health -= damageStillToInflict;
                if (health< 0) health = 0;
            }
        }

        public void SetName(string newName)
        {
            if(newName.Length > 8)
            {
                name = newName.Substring(0,8);
            } 
        }

        public void PickupPowerUp(PowerUp powerUp, float value)
        {
            if(powerUp == PowerUp.Health)
            {
                health += value;
                if( health > 100)
                {
                    health = 100;
                }
            }
            else if(powerUp == PowerUp.Shield)
            {
                shield += value;
                if(shield > 100)
                {
                    shield = 100;
                }
            }
            powerUpCount ++;
        }

        public static int getPowerUpNumber()
        {
            return powerUpCount;
        }
    }
}