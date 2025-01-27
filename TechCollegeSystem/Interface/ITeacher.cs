using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechCollegeSystem.Interface;

public interface ITeacher : ISubjectManagement, ISimiliarTraits, ISalary
{
    public Dictionary<string, List<string>> TeamTeachingAssignments { get; set; }  
    
    public void AssignToTeam(string team, string subject);
    public void RemoveFromTeam(string team, string subject);
}