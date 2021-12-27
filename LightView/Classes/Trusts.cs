using System;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;

namespace LightView
{
    internal class Trusts
    {
        public static void GetDomainTrusts()
        {
            var trusts = System.DirectoryServices.ActiveDirectory.Domain.GetCurrentDomain().GetAllTrustRelationships();
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
