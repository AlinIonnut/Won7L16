using Microsoft.EntityFrameworkCore;
using Won7L16.Data;
using Won7L16.Models;

Seed();
OrderByName();
YoungestConstructionStudent();

static void Seed()
{
    using var dbContext = new StudentDbContext();

    dbContext.Students.RemoveRange(dbContext.Students);
    dbContext.SaveChanges();

    dbContext.Students.Add(new Student { Name = "Mircea", FirstName = "Popescu", Age = 23, Specialization = Specialization.Letters });
    dbContext.Students.Add(new Student { Name = "Irina", FirstName = "Irimia", Age = 24, Specialization = Specialization.It });
    dbContext.Students.Add(new Student { Name = "Alina", FirstName = "Dobre", Age = 20, Specialization = Specialization.Construction });
    dbContext.Students.Add(new Student { Name = "Ioana", FirstName = "Silvia", Age = 29, Specialization = Specialization.Letters });
    dbContext.Students.Add(new Student { Name = "George", FirstName = "Silvester", Age = 38, Specialization = Specialization.Construction });
    dbContext.Students.Add(new Student { Name = "Mihai", FirstName = "Marin", Age = 19, Specialization = Specialization.It });
    dbContext.Students.Add(new Student { Name = "Grigore", FirstName = "Maria", Age = 20, Specialization = Specialization.Letters });

    dbContext.SaveChanges();
}


static void OrderByName() 
{

    using var dbContext = new StudentDbContext();

    var students = dbContext.Students.OrderBy(s => s.FirstName).ThenBy(s => s.Name).ToList();

    foreach(var student in students)
    {
        Console.WriteLine($"{student.Name}, {student.FirstName}, {student.Age}, {student.Specialization}");
    }
}

static void YoungestConstructionStudent()
{
    using var dbContext = new StudentDbContext();

    var student = dbContext.Students.Where(s => s.Age >= 20 && s.Specialization == Specialization.Construction).OrderBy(s => s.Age).FirstOrDefault();

    if (student != null)
    {
        Console.WriteLine($"Youngest construction student over 20: {student.Name}, {student.FirstName}, {student.Age} years old");
    }
    else
    {
        Console.WriteLine("No construction student over 20 found.");
    }

}


