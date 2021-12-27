using System;
using System.Collections.Generic;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightView
{
    internal class Groups
    {
        public static void GetDomainGroups()
        {
            using (PrincipalContext principalContext = new PrincipalContext(ContextType.Domain))
            {
                GroupPrincipal groupPrincipal = new GroupPrincipal(principalContext);
                groupPrincipal.Name = "*";

                using (PrincipalSearcher principalSearcher = new PrincipalSearcher(groupPrincipal))
                {
                    foreach (var result in principalSearcher.FindAll())
                    {
                        Console.WriteLine(result.Name);
                    }
                }
            }
        }

        public static void GetDomainGroups(string domainServer)
        {
            using (PrincipalContext principalContext = new PrincipalContext(ContextType.Domain, domainServer))
            {
                GroupPrincipal groupPrincipal = new GroupPrincipal(principalContext);
                groupPrincipal.Name = "*";

                using (PrincipalSearcher principalSearcher = new PrincipalSearcher(groupPrincipal))
                {
                    foreach (var result in principalSearcher.FindAll())
                    {
                        Console.WriteLine(result.Name);
                    }
                }
            }
        }

        public static void GetDomainGroup(string groupName)
        {
            using (PrincipalContext principalContext = new PrincipalContext(ContextType.Domain))
            {
                GroupPrincipal groupPrincipal = new GroupPrincipal(principalContext);
                groupPrincipal.Name = '*' + groupName + '*';

                using (PrincipalSearcher principalSearcher = new PrincipalSearcher(groupPrincipal))
                {
                    foreach (var result in principalSearcher.FindAll())
                    {
                        Console.WriteLine(result.Name);
                    }
                }
            }
        }

        public static void GetDomainGroup(string groupName, string domainServer)
        {
            using (PrincipalContext principalContext = new PrincipalContext(ContextType.Domain, domainServer))
            {
                GroupPrincipal groupPrincipal = new GroupPrincipal(principalContext);
                groupPrincipal.Name = '*' + groupName + '*';

                using (PrincipalSearcher principalSearcher = new PrincipalSearcher(groupPrincipal))
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
