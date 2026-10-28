using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Student.Domain;
using Student.Infrastructure;
using Student.Application;
using Microsoft.AspNetCore.Authorization;
using Student.Application.StudentInterface;
using Student.Application.DTOs;

[ApiController]
[Route("api/[controller]")]
public class StudentController : ControllerBase
{
    //private readonly StudentDbContext student;


    //public StudentController(StudentDbContext context)
    //{
    //    student = context;

    //}
    private readonly IStudentService context;
    public StudentController(IStudentService _context)
    {
        context = _context;
    }

    [HttpGet("StudentRequestDto")]
    public async Task<IActionResult> GetAllStudentUsingDto()
    {
        var result = await context.GetAllStudent();

        if(result == null)
        {
            return BadRequest();
        }

        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> AddNewStudent([FromBody] StudentDetails details)
    {
        var result = await context.AddStudentNew(details);
        if(result == null)
        {
            return StatusCode(204, result);
        }
        return StatusCode(201, result);
    }

    //[HttpGet]
    //public async Task<IActionResult> GetStudents()
    //{
    //    var students = await student.Students
    //        .Include(s => s.Department)
    //        .Select(s => new
    //        {
    //            s.StudentId,
    //            s.StudentName,
    //            s.StudentEmail,
    //            s.DepartmentId,
    //            DepartmentName = s.Department!.DepartmentName
    //        })
    //        .ToListAsync();

    //    return Ok(students);
    //}

    ////GET: BY ID
    //[HttpGet("without relationship")]
    
    //public async Task<IActionResult> GetStudentById()
    //{
    //    var result = await student.Students.ToListAsync();

    //    return Ok(result);
    //}
    ////POST: INSERT RECORD TO DATABASE

    //[HttpPost]

    //public async Task<IActionResult> AddStudent([FromBody] StudentDetails _student)
    //{
    //    await student.Students.AddAsync(_student);
    //    await student.SaveChangesAsync();

    //    return Ok("Successfully Student record Added");
    //}

    ////DELETE: Delete by id in DB

    //[HttpDelete("{id:int}")]
    //public async Task<IActionResult> DeleteStudent(int id)
    //{
    //    var detail = await student.Students.FindAsync(id);
    //    if (detail == null)
    //    {
    //        return BadRequest("Not Found");
    //    }
    //    student.Students.Remove(detail);
    //    await student.SaveChangesAsync();

    //    return Ok("Delete successfully");
    //}

    //[HttpPut("{id:int}")]
    //public async Task<IActionResult> UpdateStudentDetails([FromRoute] int id, [FromBody] StudentDetails Updatestudent)
    //{
    //    var find = await student.Students.FindAsync(id);

    //    if (find == null)
    //    {
    //        return BadRequest("Not Found");
    //    }

    //    find.StudentName = Updatestudent.StudentName;
    //    find.StudentEmail = Updatestudent.StudentEmail;
    //    find.StudentState = Updatestudent.StudentState;
    //    find.StudentNumber = Updatestudent.StudentNumber;

    //    await student.SaveChangesAsync();

    //    return Ok("Successfully updated");

    //}



}