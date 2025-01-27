using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TechCollegeSystem.Interface;

public interface ISubjectManagement
{
    public string Team { get; set; }
    public List<string> EnrolledSubjects { get; set; }
    public void EnrollInSubject(string subject);
    public void UnenrollFromSubject(string subject);
}