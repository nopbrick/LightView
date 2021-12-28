# LightView
LightView is a minimal powerview implementation for querying basic information about the Active Directory environment. 
It is written entirely in C# (.NET Framework 4.7) and provides similar functionality as the powerview. 

## Usage 

```
LightView.exe <function>
```

In the current version, the LightView provides following functionality: 

### Domains
- GetBasics - Returns the basic information about the current domain and forest (domains, computer domain, domain controllers, forest). 
- GetDomain -s <domainName> - Returns basic information about the specified domain (domain controllers). 

### Computers
- GetDomainComputers - Returns common name for every computer in the current domain. 
- GetDomainComputers -s <domainServer> - Returns common name for every computer from the specified domain. 
- GetDomainComputer <computerName> - Returns properties of the specified domain computer. 
- GetDomainComputer <computerName> -s <domainServer> - Returns properties of the specified domain computer in a given domain. 

### Groups
- GetDomainGroups - Returns common name for every domain group in the current domain. 
- GetDomainGroups -s <domainServer> - Returns common name for every domain group in the specified domain. 
- GetDomainGroup <groupName> - Returns properties of the specified domain group. 
- GetDomainGroup <groupName> -s <domainServer> - Returns properties of the specified domain group in a given domain. 

### Domain Trusts
- GetDomainTrusts - Enumerates all trusts for a current domain. 

### Users
- GetDomainUsers - Returns common name for every user in the current domain. 
- GetDomainUsers -s <domainServer> - Returns common name for every user from the specified domain. 
- GetDomainUser <userName> - Returns properties of the specified domain user. 
- GetDomainUser <userName> -s <domainServer> - Returns properties of the specified domain user in a given domain. 