using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechCollegeSystem.Interface;

public interface ITeacher : ISubjectManagement, ISimiliarTraits
{
    public decimal MonthlySalary { get; set; }
    public Dictionary<string, List<string>> TeamTeachingAssignments { get; set; }  // Key: Team, Value: List of subjects
    
    public void AssignToTeam(string team, string subject);
    public void RemoveFromTeam(string team, string subject);
}