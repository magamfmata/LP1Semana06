using System.Security.Cryptography.X509Certificates;

namespace MyGame
{
    public class Enemy
    {
    private string name;
    private float health;
    private float shield;
    // Construtor
    public Enemy(string name)
    
        {
        SetName(name);
        this.name = name; // Porque razao usamos "this"?
        health = 100;
        shield = 0;

        }
        public string TakeDamage(float damage)

        {
            shield -= damage;
            if (shield <= 0)
            {
                float damageLeft = -shield;
                shield = 0;
                health -= damageLeft;
                if (health < 0) health = 0;
            }

            return health + " " + shield;

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

        public string SetName(string newName)
        {
            string oldName = "";
            for (int i = 0; i < newName.Length && i < 8; i++)
            {
                oldName += newName[i];
            }
            name = oldName;
            return oldName;

        }
 }
    }


