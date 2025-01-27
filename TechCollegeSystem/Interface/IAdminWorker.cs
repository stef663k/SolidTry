using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechCollegeSystem.Models;

namespace TechCollegeSystem.Interface;

public interface IAdminWorker : ISalary, ISimiliarTraits
{
    public List<Students> ResponsibleForStudents{ get; set; }
    public void AddStudents(Students students);
    public void RemoveStudents(Students students);
    public void TransferStudent(Students students);
}