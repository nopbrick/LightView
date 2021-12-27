using System;
using System.DirectoryServices.AccountManagement;

namespace LightView
{
    internal class Computers
    {
        public static void GetDomainComputers()
        {
            using (PrincipalContext principalContext = new PrincipalContext(ContextType.Domain))
            {
                ComputerPrincipal computerPrincipal = new ComputerPrincipal(principalContext);
                computerPrincipal.Name = "*";

                using (PrincipalSearcher principalSearcher = new PrincipalSearcher(computerPrincipal))
                {
                    foreach (var result in principalSearcher.FindAll())
                    {
                        Console.WriteLine(result.Name);
                    }
                }
            }
        }

        public static void GetDomainComputers(string domainServer)
        {
            using (PrincipalContext principalContext = new PrincipalContext(ContextType.Domain, domainServer))
            {
                ComputerPrincipal computerPrincipal = new ComputerPrincipal(principalContext);
                computerPrincipal.Name = "*";

                using (PrincipalSearcher principalSearcher = new PrincipalSearcher(computerPrincipal))
                {
                    foreach (var result in principalSearcher.FindAll())
                    {
                        Console.WriteLine(result.Name);
                    }
                }
            }
        }

        public static void GetDomainComputer(string computerName)
        {
            using (PrincipalContext principalContext = new PrincipalContext(ContextType.Domain))
            {
                ComputerPrincipal computerPrincipal = new ComputerPrincipal(principalContext);
                computerPrincipal.Name = '*' + computerName + '*';

                using (PrincipalSearcher principalSearcher = new PrincipalSearcher(computerPrincipal))
                {
                    foreach (var result in principalSearcher.FindAll())
                    {
                        Console.WriteLine(result.Name);
                    }
                }
            }
        }

        public static void GetDomainComputer(string computerName, string domainServer)
        {
            using (PrincipalContext principalContext = new PrincipalContext(ContextType.Domain, domainServer))
            {
                ComputerPrincipal computerPrincipal = new ComputerPrincipal(principalContext);
                computerPrincipal.Name = '*' + computerName + '*';

                using (PrincipalSearcher principalSearcher = new PrincipalSearcher(computerPrincipal))
                {
                    foreach (var result in principalSearcher.FindAll())
                    {
                        Console.WriteLine(result.Name);
                    }
                }
            }
        }
    }
}
