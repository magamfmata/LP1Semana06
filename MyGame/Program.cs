using System;
using System.Globalization;

namespace MyGame
{
    public class Program
    {
        private static void Main(string[] args)
        {
          int Enemies = int.Parse(args[0]);
          Enemy[] enemies = new Enemy[Enemies];

          for (int i = 0; i < Enemies; i++)
          {
            Console.Write($"Nome do inimigo {i + 1}: ");
            string name = Console.ReadLine();
            enemies[i] = new Enemy(name);   

          }
           foreach (Enemy enemy in enemies)
           {
               Console.WriteLine($"{enemy.GetName()} {enemy.GetHealth()}");
               Console.Write($"{enemy.GetShield()}");
           
           }
        }
    }
}
