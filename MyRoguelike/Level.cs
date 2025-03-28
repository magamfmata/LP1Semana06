using System;
using Humanizer;
using MyGame;

namespace MyRoguelike
{
    public class Level
    {
        private int RoomsNumbers;
        private Toughness levelToughness;
        private Enemy[] enemiesInRooms;

        public Level(int roomNumber, Toughness levelToughness)
        {
            this.RoomsNumbers = roomNumber;
            this.levelToughness = levelToughness;
            this.enemiesInRooms = new Enemy[roomNumber];
        }

        public void SetEnemyInRoom(int roomIndex, Enemy enemy)
        {
            if (roomIndex < 0 || roomIndex >= RoomsNumbers)
            {
                Console.WriteLine($"Invalid room index: {roomIndex}. Enemy not assigned.");
                return;
            }

            enemiesInRooms[roomIndex] = enemy;
        }

        public Toughness GetToughness()
        {
            return levelToughness;
        }

        public int GetNumRooms()
        {
            return RoomsNumbers;
        }

        public int GetNumEnemies()
        {
            int count = 0;
            foreach (var enemy in enemiesInRooms)
            {
                if (enemy != null) count++;
            }
            return count;
        }

        public void PrintEnemies()
        {
            for (int i = 0; i < enemiesInRooms.Length; i++)
            {
                if (enemiesInRooms[i] != null)
                {
                    Console.WriteLine($"{GetRoomName(i)}: {enemiesInRooms[i].GetName()}");
                }
            }
        }

        private string GetRoomName(int roomIndex)
        {
            return roomIndex switch
            {
                0 => "Zeroth room",
                13 => "Thirteenth room",
                41 => "Forty-First room",
                59 => "Fifty-Ninth room",
                99 => "Ninety-Ninth room",
                120 => "Hundred and Twentieth room",
                _ => $"{roomIndex}th room"
            };
        }
    }
}
    
    
    