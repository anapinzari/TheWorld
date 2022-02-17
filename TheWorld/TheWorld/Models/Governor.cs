using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWorld.Models
{
    class Governor
    {
        private Citizen[] _citizens;

        public Citizen[] Citizens
        {
            get
            {
                return _citizens;
            }
            set
            {
                if (value == null) throw new Exception("The governor must be a citizen.");
                _citizens = value;
            }
        }

        public Governor(Citizen[] citizens) => Citizens = citizens;
    }
}
