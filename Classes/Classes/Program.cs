using System;
using System.Collections.Generic;
using UnitWeapon;

namespace Classes
{
    internal static class Program
    {
        public struct Room
        {
            public Unit Unit { get; private set; }
            public Weapon Weapon { get; private set; }

            public Room (Unit unit, Weapon weapon)
            {
                Unit = unit;
                Weapon = weapon;
            }
        }

        public class Dungeon
        {
            private Room[] _room;

            public Dungeon()
            {
                _room = new Room[]
                {
                new Room(new Unit("Воин", 10, 22), new Weapon("Меч", 15, 25)),
                new Room(new Unit("Маг", 5, 10), new Weapon("Посох", 12, 20)),
                new Room(new Unit("Монах", 8, 14), new Weapon("Перчатки", 14, 23))

                };
            }

            public void ShowRooms()
            {
                for (int i = 0; i < _room.Length; i++)
                {
                    var room = _room[i];
                    Console.WriteLine($"Комната {i + 1}:");
                    Console.WriteLine($"Юнит: {room.Unit.Name}, Урон: {room.Unit.Damage.Get}");
                    Console.WriteLine($"Оружие: {room.Weapon.Name}, Урон: {room.Weapon.Damage.Get}");
                    Console.WriteLine("—");
                }

            }
            


        }

        static void Main()
        {
            Dungeon dungeon = new Dungeon();
            dungeon.ShowRooms();
            Console.ReadKey();
        }
    }
}
