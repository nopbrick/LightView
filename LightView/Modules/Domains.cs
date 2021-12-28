using System;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;

namespace LightView
{
    internal static class Domains
    {
        static readonly DirectoryContext _context = new DirectoryContext(DirectoryContextType.Domain, System.DirectoryServices.ActiveDirectory.Domain.GetCurrentDomain().FindDomainController().Name);


        public static void GetBasics()
        {
            var domain = System.DirectoryServices.ActiveDirectory.Domain.GetCurrentDomain();
            var domainControllers = domain.FindAllDomainControllers();
            Console.WriteLine($"\nDomain:\n\t{domain}");
            
            int i = 0;
            Console.WriteLine("\nDomain Controllers:");
            foreach (var dc in domainControllers)
            {
                i++;
                Console.WriteLine($"\t{dc}");
            }

            Console.WriteLine($"\nThis machine's domain: {System.DirectoryServices.ActiveDirectory.Domain.GetComputerDomain()}");
            
            var domains = domain.Forest.Domains;
            Console.WriteLine($"\nForest:\n\t{domain.Forest}");
            
            Console.WriteLine($"\nDomains in {domain.Forest} forest");
            foreach (var dom in domains)
            {
                Console.WriteLine($"\t{dom}");
            }

        }

        public static void GetDomain(string domainName)
        {
            var domains = System.DirectoryServices.ActiveDirectory.Domain.GetCurrentDomain().Forest.Domains.Cast<System.DirectoryServices.ActiveDirectory.Domain>();
            var domain = domains.Where(x => x.Name == domainName).FirstOrDefault();
            var domainControllers = domain.FindAllDomainControllers();

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
