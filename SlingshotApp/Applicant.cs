using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlingshotApp
{
    class Applicant
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public DateTime DOB { get; private set; }
        public UserRoles Roles { get; private set; }

        public Applicant(string firstName, string lastName, DateTime dob, UserRoles roles)
        {
            FirstName = firstName;
            LastName = lastName;
            DOB = dob;
            Roles = roles;
        }

    }
}
