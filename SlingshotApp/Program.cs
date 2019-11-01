using System;

namespace SlingshotApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var applicant = new Applicant("Adam", "smith", DateTime.Now, new UserRoles());
            var admin = new Admin("Shaun", "Tait", DateTime.Now, new UserRoles());

        }
    }
}
