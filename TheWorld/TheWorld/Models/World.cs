using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWorld.Models
{
    class World
    {
        private Country[] _countries;

        public Country[] Countries
        {
            get
            {
                return _countries;
            }
            set
            {
                if (value == null || value.Length == 0) throw new Exception("The world must have countries.");
                _countries = value;
            }
        }

        public World(Country[] countries) => Countries = countries;
    }
}
