using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Weapon
    {
        private float _durability;

        public string Name {  get; }
        public int MinDamage { get; private set; }
        public int MaxDamage { get; private set;}
        public float Durability => _durability;

        public Weapon (string name, int minDamage, int maxDamage, float durability = 1f)
        {
            Name = name;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            _durability = durability;

        }

        public bool ReduceDurability(float amount)
        {
            _durability -= amount;
            if(_durability < 0) 
            {
                _durability = 0;
            }
            return _durability == 0;
        }


    }
}
