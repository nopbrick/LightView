using System;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;

namespace QueryAD
{
    internal static class LDAPConnection
    {
        static readonly DirectoryContext _context = new DirectoryContext(DirectoryContextType.Domain, Domain.GetCurrentDomain().FindDomainController().Name);
        //_AppDomain _AppDomain;

        

        public static void GetBasics()
        {
            var domain = Domain.GetCurrentDomain();
            var domainControllers = domain.FindAllDomainControllers();
            Console.WriteLine($"Forest:\n\t{domain.Forest}");
            Console.WriteLine($"\nDomain:\n\t{domain}");
            int i = 0;
            Console.WriteLine("\nDomain Controllers:");
            foreach (var dc in domainControllers)
            {
                i++;
                Console.WriteLine($"\t{dc}");
            }

        }

        


    }
}
