using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWorld.Models
{
    class Commune : Locality
    {
        public Commune(string name, int numberOfCitizens, Governor governor) : base(name, numberOfCitizens, governor)
        {
        }
    }
}
