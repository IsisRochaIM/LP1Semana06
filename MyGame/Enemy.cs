using System;
using System.Collections.Generic;
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

        public Enemy(string name)
        {
            this.name = SetName(name);
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

        public string SetName(string newName)
        {
            if(newName.Length > 8 )
            {
                return name.Substring(8);
            }
            else
            {
                return name;
            }
        }
    }
}