using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Unit
    {
        private float _health;
        private float _armor = 0.6f;
        private int _damage = 5;
        
        public string Name { get; }

        public float Health => _health;

        public float Armor => _armor;

        public Unit () : this (name: "Unknow Unit")
        {

        }


        public Unit(string name, float _health)
        {
            Name = name;
            Health = _health;
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
