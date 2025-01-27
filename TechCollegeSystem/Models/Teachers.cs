using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechCollegeSystem.Interface;

namespace TechCollegeSystem.Models;

public class Teachers : ITeacher
{
    public decimal MonthlySalary { get; set; }
    public Dictionary<string, List<string>> TeamTeachingAssignments{ get; set; } = new Dictionary<string, List<string>>();
    public string Team { get; set; }
    public List<string> EnrolledSubjects{ get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public PersonCategory Category { get; set; }

    public void AssignToTeam(string team, string subject)
    {
        throw new NotImplementedException();
    }

    public void EnrollInSubject(string subject)
    {
        throw new NotImplementedException();
    }

    public void RemoveFromTeam(string team, string subject)
    {
        throw new NotImplementedException();
    }

    public void UnenrollFromSubject(string subject)
    {
        throw new NotImplementedException();
    }
}