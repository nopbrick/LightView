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
                        Domains.GetBasics();
                    }
                    else if (args[0].ToUpper() == "GETDOMAIN" && args.Length > 1)
                    {
                        Domains.GetDomain(args[1]);
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
                    else if (args[0].ToUpper() == "GETDOMAINTRUSTS" && args.Length == 1)
                    {
                        Trusts.GetDomainTrusts();
                    }
                    else if (args[0].ToUpper() == "GETDOMAINCOMPUTERS" && args.Length == 1)
                    {
                        Computers.GetDomainComputers();
                    }
                    else if (args[0].ToUpper() == "GETDOMAINCOMPUTERS")
                    {
                        if (o.Server != null)
                        {
                            Computers.GetDomainComputers(o.Server);
                        }
                        else
                        {
                            Computers.GetDomainComputers();
                        }
                    }
                    else if (args[0].ToUpper() == "GETDOMAINCOMPUTER" && args.Length > 1)
                    {
                        if (o.Server != null)
                        {
                            Computers.GetDomainComputer(args[1], o.Server);
                        }
                        else
                        {
                            Computers.GetDomainComputer(args[1]);
                        }
                    }
                    else if (args[0].ToUpper() == "GETDOMAINGROUPS")
                    {
                        if (o.Server != null)
                        {
                            Groups.GetDomainGroups(o.Server);
                        }
                        else
                        {
                            Groups.GetDomainGroups();
                        }
                    }
                    else if (args[0].ToUpper() == "GETDOMAINGROUP" && args.Length > 1)
                    {
                        if (o.Server != null)
                        {
                            Groups.GetDomainGroup(args[1], o.Server);
                        }
                        else
                        {
                            Groups.GetDomainGroup(args[1]);
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
