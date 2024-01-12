using StudentDatabase.Data;
using StudentDatabase.Models;

namespace StudentDatabase.Services.Studentes;

public class StudentService : IStudentService
{
    private readonly BigData _db;

    public StudentService(BigData db)
    {
        _db = db;
    }

    public List<StudentWorkPlz> GetPeopleWHoSoHappenToBeStudents()
    {
        return _db.Studentos.ToList();
    }

    public List<StudentWorkPlz> AddPersonWHoSoHappensToBeAStudent(string FirstName, string LastName, string Hobby)
    {
        StudentWorkPlz addStudent = new()
        {
            firstName = FirstName,
            lastName = LastName,
            hobby = Hobby
        };
        _db.Studentos.Add(addStudent);
        _db.SaveChanges();
        return _db.Studentos.ToList();
    }

    public List<StudentWorkPlz> DeletePersonWHoSoHappensToBeAStudent(string FirstName)
    {
        var fStudent = _db.Studentos.FirstOrDefault(foundStudent => foundStudent.firstName == FirstName);
        if(fStudent != null){
            _db.Studentos.Remove(fStudent);
            _db.SaveChanges();
        }
        return _db.Studentos.ToList();
    }

    public List<StudentWorkPlz> UpdatePersonWHoSoHappensToBeAStudent(string oldFirstName, string newFirstName, string newLastName, string newHobby)
    {
        var student = _db.Studentos.FirstOrDefault(foundStudent => foundStudent.firstName == oldFirstName);
        if(student != null){
            student.firstName = newFirstName;
            student.lastName = newLastName;
            student.hobby = newHobby;
            _db.SaveChanges();
        }
        return _db.Studentos.ToList();
    }
}
