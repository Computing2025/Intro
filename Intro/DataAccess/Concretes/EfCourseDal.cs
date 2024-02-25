using Intro.DataAccess.Abstracts;
using Intro.Entities;

namespace Intro.DataAccess.Concretes;

public class EfCourseDal : ICourseDal
{
    List<Course> courses;

    public EfCourseDal()
    {
        Course kurs1 = new()
        {
            Id = 1,
            Name = "JavaScript",
            Description = "Web Platform",
            Price = 10
        };

        Course kurs2 = new()
        {
            Id = 2,
            Name = "Node.Js backend programming",
            Description = "Making Backend Good!",
            Price = 564
        };

        Course kurs3 = new()
        {
            Id = 3,
            Name = "Artificial Intelligence",
            Description = "AI is new era",
            Price = 1231
        };

        courses = [kurs1, kurs2, kurs3];
    }


    public List<Course> GetAll()
    {
        return courses;
    }

    public void Add(Course course)
    {
        courses.Add(course);
    }
}