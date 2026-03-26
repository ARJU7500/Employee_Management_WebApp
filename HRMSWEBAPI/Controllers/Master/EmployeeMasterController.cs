using HRMSWEBAPI.Models;
using HRMSWEBAPI.Models.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HRMSWEBAPI.Controllers.Master
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeMasterController : ControllerBase
    {
        public readonly HRMSDbContext _hRMSDbContext;
        public EmployeeMasterController(HRMSDbContext _context)
        {
            _hRMSDbContext = _context;
        }
        [HttpGet("EmployeeData")]
        public async Task<IActionResult> getAllEmployeeData()
        {
            try
            {
                var employeeList = await _hRMSDbContext.EmployeeMasters.ToListAsync();
                if (employeeList.Count>0)
                {
                    return Ok(employeeList);
                }
                else
                {
                    return BadRequest("No Data Found");
                }
            }
            catch(Exception ex)
            {
                return StatusCode(500, new { Message = ex.Message });
            }
        }
        //================save employe data into databse====================
        [HttpPost("addEmployeeData")]
        public async Task<IActionResult> SaveEmployeeData([FromBody] EmployeeMaster _employeeMaster)
        {
            try
            {
                var exitingEmployee = await _hRMSDbContext.EmployeeMasters.AnyAsync(e => e.EmployeeName == _employeeMaster.EmployeeName);
                if(exitingEmployee)
                {
                    return BadRequest("Employee already exitis.");
                }
                else
                {
                    _hRMSDbContext.EmployeeMasters.Add(_employeeMaster);
                    await _hRMSDbContext.SaveChangesAsync();
                    return Ok("Employee Data Saved Sucessfully.");
                }
            }
            catch(Exception ex)
            {
                return StatusCode(500, new { Mesage = ex.Message });
            }
        }
        //===================================update employee data =========================
        [HttpPut("UpdateEmployeeData")]
        public async Task<IActionResult> updateEmployeeData([FromBody] EmployeeMaster _employeeMaster)
        {
            try
            {
                var exitingEmpID = await _hRMSDbContext.EmployeeMasters.FindAsync(_employeeMaster.EmployeeId);
                if(exitingEmpID==null)
                {
                    return BadRequest("Employee not Found.");
                }
                else
                {
                    _hRMSDbContext.EmployeeMasters.Add(_employeeMaster);
                    await _hRMSDbContext.SaveChangesAsync();
                    return Ok("Employee data updatre sucessfully");
                }
            }
            catch(Exception ex)
            {
                return StatusCode(500, new { Message = ex.Message });
            }
        }
        //==============DeleteBehavior employee data==========================
        [HttpDelete("deleteEmployeeData/{id}")]
        public async Task<IActionResult> DeleteEmployeData(int id)
        {
            try
            {
                var exitingEmpId = await _hRMSDbContext.EmployeeMasters.FindAsync(id);
                if(exitingEmpId==null)
                {
                    return BadRequest("Employee Data not found.");
                }
                else
                {
                    _hRMSDbContext.EmployeeMasters.Remove(exitingEmpId);
                    await _hRMSDbContext.SaveChangesAsync();
                    return Ok("Employee Data Deleted Sucuessfully");
                }    
            }
            catch(Exception ex)
            {
                return StatusCode(500, new { Message = ex.Message });
            }
        }
        [HttpPost("Login")]
        public async Task<IActionResult> LoginEmployee([FromBody] LoginDto _loginDto)
        {
            try
            {
                var userData = await _hRMSDbContext.EmployeeMasters.FirstOrDefaultAsync(u => u.EmailId == _loginDto.emailId && u.Password==_loginDto.password);
                if(userData==null)
                {
                    return BadRequest("User Mail Does Not Exits");
                }
                if (userData.Password != _loginDto.password)
                {
                    return BadRequest("User Password is Wrong.");
                }
                else
                {
                    return Ok(new
                    {
                        Message = "Login Successful",
                        User = new
                        {
                            userData.EmployeeId,
                            userData.EmployeeName,
                            userData.EmailId
                        }
                    });
                }
            }
            catch(Exception ex)
            {
                return StatusCode(500, new { Message = ex.Message });
            }
        }
    }
    

}
