using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechCollegeSystem.Interface;

namespace TechCollegeSystem.Models;

public class Students : IStudent
{
    public string Name { get; set; }
    public string Address { get; set; }
    public PersonCategory Category { get; set; }
    public string Team { get; set; }
    public Dictionary<string, int> SubjectGrades { get; set; } = new Dictionary<string, int>();
    public List<string> EnrolledSubjects { get; set; } = new List<string>();

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
        SubjectGrades.Remove(subject);
    }

    public void SetGrade(string subject, int grade)
    {
        if (EnrolledSubjects.Contains(subject))
        {
            SubjectGrades[subject] = grade;
        }
    }

    public double CalculateAverageGrade()
    {
        if (SubjectGrades.Count == 0) return 0;
        return SubjectGrades.Values.Average();
    }
}