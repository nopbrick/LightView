using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices.AccountManagement;

namespace LightView
{
    internal class Users
    {
        
        public static void GetDomainUser()
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
    }
}
