using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Data;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/departments")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private DataContext db;
        public DepartmentController (DataContext context)
        {
            db = context;

        }

        [HttpGet]
        public async Task<ActionResult<Department>> GetDepartment()
        {
            return Ok(await db.Department.ToListAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Department>> GetDepartment(int id)
        {
            var department = await db.Department.FindAsync(id);
            if (department == null)
                return BadRequest("Department was not found");
            return Ok(department);
        }
        [HttpPost]
        public async Task<ActionResult<Department>> AddDepartment(Department department)
        {
            await db.Department.AddAsync(department);
            await db.SaveChangesAsync();
            return Ok(await db.Department.ToArrayAsync());
        }
        [HttpPut]
        public async Task<ActionResult<Department>> UpdateDepartment(Department request)
        {
            var dbDepartment = await db.Department.FindAsync(request.DepartmentId);
            if (dbDepartment == null)
                return BadRequest("Department was not found");
            dbDepartment.DepartmentName = request.DepartmentName;
            await db.SaveChangesAsync();
            return Ok(await db.Department.ToArrayAsync());
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<Department>> DeleteDepartment(int id)
        {
            var department = await db.Department.FindAsync(id);
            if (department == null)
                return BadRequest("Department was not found");
            db.Department.Remove(department);
            await db.SaveChangesAsync();
            return Ok(await db.Department.ToArrayAsync());
        }
    }
}
