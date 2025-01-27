using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechCollegeSystem.Interface;

namespace TechCollegeSystem.Models;

public class AdminWorkers : ISimiliarTraits
{
    public string Name { get; set; }
    public string Address { get; set; }
    public PersonCategory Category { get; set; }
}