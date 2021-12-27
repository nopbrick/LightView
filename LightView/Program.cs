using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandLine;

namespace LightView
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<Options>(args)
                .WithParsed<Options>(o =>
                {
                    if (args[0].ToUpper() == "GETBASICS")
                    {
                        Basics.GetBasics();
                    }
                    else if (args[0].ToUpper() == "GETDOMAIN" && args.Length > 1)
                    {
                        Basics.GetDomain(args[1]);
                    }
                    else if (args[0].ToUpper() == "GETDOMAINUSERS")
                    {
                        if (o.Server != null)
                        {
                            Users.GetDomainUsers(o.Server);
                        }
                        else
                        {
                            Users.GetDomainUsers();
                        }
                    }
                    else if (args[0].ToUpper() == "GETDOMAINUSER" && args.Length > 1)
                    {
                        if (o.Server != null)
                        {
                            Users.GetDomainUser(args[1], o.Server);
                        }
                        else
                        {
                            Users.GetDomainUser(args[1]);
                        }
                        
                    }
                });
        }

        public class Options
        {
            [Option('s', "server", Required=false, HelpText = "Specify Active Directory server for queries. ")]
            public string Server { get; set; }
        }
    }
}
