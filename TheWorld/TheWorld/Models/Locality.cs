using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWorld.Models
{
    class Locality
    {
        private string _name;
        private District _district;      
        private Citizen[] _citizens;
        private Governor _governor;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value == null || value.Length == 0) throw new Exception("");
                _name = value;
            }
        }
        public District District
        {
            get
            {
                return _district;
            }
            set
            {
                if (value == null) throw new Exception("The locality must belong to a district.");
                _district = value;
            }
        }
        public int NumberOfCitizens { get; set; }
        public Citizen[] Citizens
        {
            get
            {
                return _citizens;
            }
            set
            {
                if (value == null || value.Length == 0) throw new Exception("The locality must have citizens.");
                _citizens = value;
            }
        }
        public Governor Governor
        {
            get
            {
                return _governor;
            }
            set
            {
                if (value == null) throw new Exception("The locality must have a governor.");
                _governor = value;
            }
        }

        public Locality(string name, int numberOfCitizens, Governor governor)
        {
            Name = name;
            NumberOfCitizens = numberOfCitizens;
            Governor = governor;
        }
    }
}
