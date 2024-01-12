using StudentDatabase.Models;
namespace StudentDatabase.Services.Studentes;

public interface IStudentService
{
    List<StudentWorkPlz> GetPeopleWHoSoHappenToBeStudents();
    List<StudentWorkPlz> AddPersonWHoSoHappensToBeAStudent(string FirstName, string LastName, string Hobby);
    List<StudentWorkPlz> DeletePersonWHoSoHappensToBeAStudent(string FirstName);
    List<StudentWorkPlz> UpdatePersonWHoSoHappensToBeAStudent(string oldFirstName, string newFirstName, string newLastName, string newHobby);
}
