using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace TechCollegeSystem.Interface;

public interface ISimiliarTraits
{
    public string Name { get; set; }
    public string Address { get; set; }
    
    public PersonCategory Category { get; set; }
}

public enum PersonCategory
{
    Student,
    Teacher,
    AdministrativeStaff
}