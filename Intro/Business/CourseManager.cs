using Intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro.Business;

public class CourseManager
{
    Course[] courses;

    public CourseManager()
    {
        Course kurs1 = new()
        {
            Id = 1,
            Name = ".NET MAUI",
            Description = ".NET Multi-Platform",
            Price = 0
        };

        Course kurs2 = new()
        {
            Id = 2,
            Name = "Artificial Intelligence",
            Description = "Making Software Great Again",
            Price = 100
        };

        Course kurs3 = new()
        {
            Id = 3,
            Name = "ASP.NET Web API",
            Description = "Making Web Great Again",
            Price = 500
        };
        
       courses = [ kurs1, kurs2, kurs3];
    }

    public Course[] GetAll()
    {
        return courses;
    }
}


