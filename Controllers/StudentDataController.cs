using StudentDatabase.Models;
using StudentDatabase.Services.Studentes;
using Microsoft.AspNetCore.Mvc;

namespace StudentDatabase.Controllers;

[ApiController]
[Route("[controller]")]
public class StudentDataController : ControllerBase
{
    private readonly IStudentService _StudentService;

    public StudentDataController(IStudentService StudentService){
        _StudentService = StudentService;
    }

    [HttpGet]
    [Route("GetList")]
    public List<StudentWorkPlz> GetPeopleWHoSoHappenToBeStudents()
    {
        return _StudentService.GetPeopleWHoSoHappenToBeStudents();
    }

    [HttpPost]
    [Route("AddPeep/{FirstName}/{LastName}/{Hobby}")]
    public List<StudentWorkPlz> AddPersonWHoSoHappensToBeAStudent(string FirstName, string LastName, string Hobby)
    {
        return _StudentService.AddPersonWHoSoHappensToBeAStudent(FirstName, LastName, Hobby);
    }

    [HttpDelete]
    [Route("RemovePeep/{FirstName}")]
    public List<StudentWorkPlz> DeletePersonWHoSoHappensToBeAStudent(string FirstName)
    {
        return _StudentService.DeletePersonWHoSoHappensToBeAStudent(FirstName);
    }

    [HttpPut]
    [Route("ChangePeep/{oldFirstName}/{newFirstName}/{newLastName}/{newHobby}")]
    public List<StudentWorkPlz> UpdatePersonWHoSoHappensToBeAStudent(string oldFirstName, string newFirstName, string newLastName, string newHobby)
    {
        return _StudentService.UpdatePersonWHoSoHappensToBeAStudent(oldFirstName, newFirstName, newLastName, newHobby);
    }
}
