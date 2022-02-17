using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheWorld.Models
{
    class CitizensRole
    {
        public Role CitizenRole { get; set; }
        public CitizensRole(Role citizenRole) => CitizenRole = citizenRole;

        public enum Role
        {
            Governor,
            SocialWorker,
            Employed,
            Unemployed
        }
    }
}
