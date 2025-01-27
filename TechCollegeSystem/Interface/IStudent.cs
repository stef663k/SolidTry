using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace TechCollegeSystem.Interface;

public interface IStudent : ISimiliarTraits, ISubjectManagement
{
    public Dictionary<string, int> SubjectGrades { get; set; }
    public void SetGrade(string subject, int grade);
    public double CalculateAverageGrade();
}