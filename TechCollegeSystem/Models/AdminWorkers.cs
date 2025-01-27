using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechCollegeSystem.Interface;

namespace TechCollegeSystem.Models;

public class AdminWorkers : IAdminWorker
{
    public List<Students> ResponsibleForStudents { get; set; } = new List<Students>();
    public decimal MonthlySalary { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public PersonCategory Category { get; set; }

    public void AddStudents(Students students)
    {
        throw new NotImplementedException();
    }

    public void RemoveStudents(Students students)
    {
        throw new NotImplementedException();
    }

    public void TransferStudent(Students students)
    {
        throw new NotImplementedException();
    }
}