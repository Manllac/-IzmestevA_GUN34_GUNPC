using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes;


namespace UnitWeapon
{
    public class Unit
    {
        private float _health;
        private float _armor = 0.6f;
        private int _damage = 5;
        public Interval Damage { get; private set; }

        public string Name { get; }

        public float Health => _health; 

        public float Armor => _armor;

        public Unit() : this(name: "Unknow Unit")
        {

        }

        public Unit(string name)
        {
            Name= name;
        }


        public Unit(string name, float health)
        {
            Name = name;
            _health = health;
            Damage = new Interval(0, 10);
        }

        public Unit(string name, int minDamage, int maxDamage)
        {
            Name = name;
            _health = 100;
            Damage = new Interval(minDamage, maxDamage);
        }

        public float GetRealHelth ()
        {
            return Health * (1f + Armor);
        }

        public bool SetDamage (float value)
        {
            _health -= value * Armor;
            return _health < 0f;
        }
    }
}
