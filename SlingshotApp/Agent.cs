using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlingshotApp
{
    class Agent
    {
        private readonly List<Applicant> _applicants;

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public DateTime DOB { get; private set; }

        public UserRoles Roles { get; private set; }
        public string Domain { get; private set; }
        public IReadOnlyCollection<Applicant> Applicants => _applicants;

        public Agent(string firstName, string lastName, DateTime dob, UserRoles roles, string domain)
        {
            FirstName = firstName;
            LastName = lastName;
            DOB = dob;
            Roles = roles;
            Domain = domain;
            _applicants = new List<Applicant>();
        }

        public void AddApplicant(string firstName, string lastName, DateTime dob, UserRoles roles)
        {
            _applicants.Add(new Applicant(firstName, lastName, dob, roles));
        }
    }
}
