using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWorld.Models
{
    class Citizen : Person
    {
        private CitizensRole[] _citizensRoles;
        
        public CitizensRole[] CitizensRoles
        {
            get
            {
                return _citizensRoles;
            }
            set
            {
                if (value == null || value.Length == 0) throw new Exception("");
                _citizensRoles = value;
            }
        }

        public Citizen(string firstName, string lastName, string id, string phoneNumber, int age, bool isFemale, CitizensRole[] citizensRoles)
            : base(firstName, lastName, id, phoneNumber, age, isFemale) => CitizensRoles = citizensRoles;
    }
}
