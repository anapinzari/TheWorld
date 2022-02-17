using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWorld.Models
{
    class District
    {
        private string _name;
        private City[] _cities;
        private Commune[] _communes;
        private Countryside[] _countrysides;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value == null || value.Length == 0) throw new Exception("The district must have a name.");
                _name = value;
            }
        }
        public City[] Cities
        {
            get
            {
                return _cities;
            }
            set
            {
                if (value == null) throw new Exception("The district must not be null.");
                _cities = value;
            }
        }
        public Commune[] Communes
        {
            get
            {
                return _communes;
            }
            set
            {
                if (value == null) throw new Exception("The district must not be null.");
                _communes = value;
            }
        }
        public Countryside[] Countrysides
        {
            get
            {
                return _countrysides;
            }
            set
            {
                if (value == null)
                throw new Exception("The district must not be null.");
                _countrysides = value;
            }
        }

        public District(string name, City[] cities, Commune[] communes, Countryside[] countrysides)
        {
            if ((cities == null || cities.Length == 0) && (communes == null || communes.Length == 0) && (countrysides == null || countrysides.Length == 0)) 
                throw new Exception(""); //TODO

            Name = name;
            Cities = cities;
            Communes = communes;
            Countrysides = countrysides;
        }
    }
}
