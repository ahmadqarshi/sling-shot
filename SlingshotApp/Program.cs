using System;

namespace SlingshotApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var applicant = new Applicant("Adam", "smith", DateTime.Now, new UserRoles());
            var agent =  new Agent("Agent", "Sam", DateTime.Now, new UserRoles(), "IT");

        }
    }
}
