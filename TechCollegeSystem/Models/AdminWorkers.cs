using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechCollegeSystem.Interface;

namespace TechCollegeSystem.Models;

public class AdminWorkers : IAdminWorker
{
    public string Name { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public PersonCategory Category { get; set; }
    public decimal MonthlySalary { get; set; }
    public List<Students> ResponsibleForStudents { get; set; } = new List<Students>();

    public void AddStudents(Students student)
    {
        if (!ResponsibleForStudents.Contains(student))
        {
            ResponsibleForStudents.Add(student);
        }
    }

    public void RemoveStudents(Students student)
    {
        ResponsibleForStudents.Remove(student);
    }

    public void TransferStudent(Students student)
    {
        if (ResponsibleForStudents.Contains(student))
        {
            RemoveStudents(student);
        }
    }
}