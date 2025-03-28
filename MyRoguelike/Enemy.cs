using System;

namespace MyRoguelike
{
    public class Enemy
    {
        private string name;
        private float health;
        private float shield;
        private static int totalPowerUps;

        public Enemy(string name)
        {
            this.name = name;
            health = 100;
        }
    }
}