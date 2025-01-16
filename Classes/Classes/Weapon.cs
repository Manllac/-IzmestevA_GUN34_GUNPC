using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Weapon
    {
        private float _durability = 1;

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
    }
}
