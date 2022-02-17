using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWorld.Models
{
    class Country
    {
        private string _name;
        private District[] _districts;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value == null || value.Length == 0) throw new Exception("The country must have a name.");
                _name = value;
            }
        }
        public District[] Districts
        {
            get
            {
                return _districts;
            }
            set
            {
                if (value == null || value.Length == 0) throw new Exception("The country must have districts.");
                _districts = value;
            }
        }

        public Country(string name, District[] districts)
        {
            Name = name;
            Districts = districts;
        }
    }
}
