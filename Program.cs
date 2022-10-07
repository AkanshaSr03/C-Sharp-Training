using Coffee.StorageApp.Entities;
using Coffee.StorageApp.Repositories;
using System;
namespace Coffee.StorageApp
{
    class Program
    {
        static void Main(string[] args)
        {
           var employeeRepository = new GenericRepository<Employee>();
            employeeRepository.Add(new Employee { FirstName = "Akanksha" });
            employeeRepository.Add(new Employee { FirstName = "Astha" });
            employeeRepository.Add(new Employee { FirstName = "Akastha" });
            employeeRepository.save();
            var organizationRepository = new GenericRepository<Organization>();
            organizationRepository.Add(new Organization { Name = "PluralSight" });
            organizationRepository.Add(new Organization { Name = "W3School" });
            organizationRepository.Add(new Organization { Name = "TutorialPoint" });
            organizationRepository.save();
            Console.ReadLine();
        }
    }
}
