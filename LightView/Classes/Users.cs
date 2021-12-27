using System;
using System.DirectoryServices.AccountManagement;

namespace LightView
{
    internal class Users
    {
        
        public static void GetDomainUsers()
        {
            using (PrincipalContext principalContext = new PrincipalContext(ContextType.Domain))
            {
                UserPrincipal userPrincipal = new UserPrincipal(principalContext);
                userPrincipal.Name = "*";

                using (PrincipalSearcher principalSearcher = new PrincipalSearcher(userPrincipal))
                {
                    foreach (var result in principalSearcher.FindAll())
                    {
                        Console.WriteLine(result.SamAccountName);
                    }
                }
            }
        }

        public static void GetDomainUsers(string domainServer)
        {
            using (PrincipalContext principalContext = new PrincipalContext(ContextType.Domain, domainServer))
            {
                UserPrincipal userPrincipal = new UserPrincipal(principalContext);
                userPrincipal.Name = "*";

                using (PrincipalSearcher principalSearcher = new PrincipalSearcher(userPrincipal))
                {
                    foreach (var result in principalSearcher.FindAll())
                    {
                        Console.WriteLine(result.SamAccountName);
                    }
                }
            }
        }

        public static void GetDomainUser(string accountName)
        {
            using (PrincipalContext principalContext = new PrincipalContext(ContextType.Domain))
            {
                UserPrincipal userPrincipal = new UserPrincipal(principalContext);
                userPrincipal.SamAccountName = '*' + accountName + '*';

                using (PrincipalSearcher principalSearcher = new PrincipalSearcher(userPrincipal))
                {
                    foreach (var result in principalSearcher.FindAll())
                    {
                        Console.WriteLine(result.SamAccountName);
                    }
                }
            }
        }


        public static void GetDomainUser(string accountName, string domainServer)
        {
            using (PrincipalContext principalContext = new PrincipalContext(ContextType.Domain, domainServer))
            {
                UserPrincipal userPrincipal = new UserPrincipal(principalContext);
                userPrincipal.SamAccountName = '*' + accountName + '*';

                using (PrincipalSearcher principalSearcher = new PrincipalSearcher(userPrincipal))
                {
                    foreach (var result in principalSearcher.FindAll())
                    {
                        Console.WriteLine(result.SamAccountName);
                    }
                }
            }
        }
    }
}
