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
                        Console.WriteLine();
                        Console.WriteLine($"Name: {result.Name}");
                        Console.WriteLine($"Sid: {result.Sid}");
                        Console.WriteLine($"DistinguishedName: {result.DistinguishedName}");
                        Console.WriteLine($"SamAccountName: {result.SamAccountName}");
                        Console.WriteLine($"Description: {result.Description}");
                        Console.WriteLine($"DisplayName: {result.DisplayName}");
                        Console.WriteLine($"UserPrincipalName: {result.UserPrincipalName}");
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
                        Console.WriteLine();
                        Console.WriteLine($"Name: {result.Name}");
                        Console.WriteLine($"Sid: {result.Sid}");
                        Console.WriteLine($"DistinguishedName: {result.DistinguishedName}");
                        Console.WriteLine($"SamAccountName: {result.SamAccountName}");
                        Console.WriteLine($"Description: {result.Description}");
                        Console.WriteLine($"DisplayName: {result.DisplayName}");
                        Console.WriteLine($"UserPrincipalName: {result.UserPrincipalName}");
                    }
                }
            }
        }
    }
}
