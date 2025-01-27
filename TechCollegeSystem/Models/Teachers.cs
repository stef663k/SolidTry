using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechCollegeSystem.Interface;

namespace TechCollegeSystem.Models;

public class Teachers : ITeacher
{
    
    public string Name { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public PersonCategory Category { get; set; }
    public decimal MonthlySalary { get; set; }
    public List<string> EnrolledSubjects { get; set; } = new List<string>();
    public Dictionary<string, List<string>> TeamTeachingAssignments { get; set; } = new Dictionary<string, List<string>>();
    public string Team { get; set; } = string.Empty;

    public void EnrollInSubject(string subject)
    {
        if (!EnrolledSubjects.Contains(subject))
        {
            EnrolledSubjects.Add(subject);
        }
    }

    public void UnenrollFromSubject(string subject)
    {
        EnrolledSubjects.Remove(subject);
        

        foreach (var team in TeamTeachingAssignments.Keys.ToList())
        {
            TeamTeachingAssignments[team].Remove(subject);
        }
    }

    public void AssignToTeam(string team, string subject)
    {
        if (!EnrolledSubjects.Contains(subject))
        {
            return; 
        }

        if (!TeamTeachingAssignments.ContainsKey(team))
        {
            TeamTeachingAssignments[team] = new List<string>();
        }

        if (!TeamTeachingAssignments[team].Contains(subject))
        {
            TeamTeachingAssignments[team].Add(subject);
        }
    }

    public void RemoveFromTeam(string team, string subject)
    {
        if (TeamTeachingAssignments.ContainsKey(team))
        {

            TeamTeachingAssignments[team].Remove(subject);
            
            if (TeamTeachingAssignments[team].Count == 0)
            {

                TeamTeachingAssignments.Remove(team);
            }
        }
    }
}