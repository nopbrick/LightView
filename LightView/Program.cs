using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightView
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            if (args[0].ToUpper() == "GETBASICS")
            {
                Basics.GetBasics();
            }
            else if (args[0].ToUpper() == "GETDOMAIN" && args.Length > 1)
            {
                Basics.GetDomain(args[1]);
            }
            else if (args[0].ToUpper() == "GETDOMAINUSER" && args.Length == 1)
            {
                Users.GetDomainUser();
            }
            else if (args[0].ToUpper() == "GETDOMAINUSER" && args.Length > 1)
            {
                Users.GetDomainUser(args[1]);
            }
        }
    }
}
