using System;

namespace MyGamee
{
    class Program
    {
        static void Main(string[] args)
        {
            int enemy man = int.Parse(args[0]);
            Enemy[] Enemies= new Enemy[enemy c1];

            for (int i = 0; i < enemy c1; i++)
            {
                Console.Write($"Nome do inimigo {i + 1}:");
                string name= Console.ReadLine;
                Enemies[i]= new Enemy (name);
            }
            foreach (enemies in Enemies)
            {
                e.TakeDamage(50);
                e.PickupPowerUp(PowerUp.Shield, 25);
                e.PickupPowerUp(PowerUp.Health, 25);
                string name = e.GetName();
                float health = e.GetHealth();
                float shield = e.GetShield();

                Console.WriteLine($"{name}{shield}{health}");
            }
        }
    }
}
