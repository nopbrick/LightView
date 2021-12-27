using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightView
{
    internal class Trusts
    {
        static readonly DirectoryContext _context = new DirectoryContext(DirectoryContextType.Domain, Domain.GetCurrentDomain().FindDomainController().Name);

        public static void GetDomainTrusts()
        {
            var trusts = Domain.GetCurrentDomain().GetAllTrustRelationships();
            foreach (var trust in trusts.Cast<TrustRelationshipInformation>())
            {
                Console.WriteLine();
                Console.WriteLine($"Source Name: {trust.SourceName}");
                Console.WriteLine($"Target Name: {trust.TargetName}");
                Console.WriteLine($"Direction: {trust.TrustDirection}");
                Console.WriteLine($"Type: {trust.TrustType}");
            }
        }
    }
}
