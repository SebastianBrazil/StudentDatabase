using StudentDatabase.Models;
using Microsoft.EntityFrameworkCore;

namespace StudentDatabase.Data;

public class BigData : DbContext
{
    public BigData(DbContextOptions<BigData> options) : base(options)
    {

    }
    
    public DbSet<StudentWorkPlz> Studentos {get; set;}
}