# LightView
LightView is a minimal powerview implementation for querying basic information about the Active Directory environment. 
It is written entirely in C# (.NET Framework 4.7) and provides similar functionality as the powerview. 

## Usage 

In the current version, the LightView provides following functionality: 
- GetBasics - Returns the basic information about the current domain and forest (domains, computer domain, domain controllers, forest). 
- GetDomain -s <domainName> - Returns basic information about the specified domain (domain controllers). 
- GetDomainComputers - Returns common name for every computer in the current domain. 
- GetDomainComputers -s <domainServer> - Returns common name for every computer from the specified domain. 
- GetDomainComputer <computerName> - Returns properties of the specified domain computer. 
- GetDomainComputer <computerName> -s <domainServer> - Returns properties of the specified domain computer in a given domain. 