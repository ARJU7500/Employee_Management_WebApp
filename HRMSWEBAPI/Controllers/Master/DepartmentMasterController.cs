using HRMSWEBAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HRMSWEBAPI.Controllers.Master
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentMasterController : ControllerBase
    {
        //============With Dependency Injection===============
        //Value can be assigned only once (usually in constructor)
        public readonly HRMSDbContext _hRMSDbContext;
        //This is a constructor
        //ASP.NET Core automatically calls this when controller is created _context is passed by Dependency Injection
        public DepartmentMasterController (HRMSDbContext _context)
        {
            //Assigns injected object to your class variable
            _hRMSDbContext = _context;
        }
        //===================post data/save data into database=======================
        [HttpPost("addDepartmentData")]
        public async Task<IActionResult> saveDepartMentData([FromBody] DepartmentMaster _departmentMaster)
        {

            try
            {
                var exitingDept = await _hRMSDbContext.DepartmentMasters.AnyAsync(d => d.DeptName == _departmentMaster.DeptName);
                if (exitingDept)
                {
                    return BadRequest("Department already exists.");
                }
                else
                {
                    _hRMSDbContext.DepartmentMasters.Add(_departmentMaster);
                    await _hRMSDbContext.SaveChangesAsync();
                    return Ok("Department Data Save Sucessfully");
                }
            }
            catch(Exception ex)
            {
                return StatusCode(500, new { Message = ex.Message });
            }
        }

        //============================put data/update data into database==========================
        [HttpPut("updateDepartmentData")]
        public async Task<IActionResult> UpdateDepartmentMasterData([FromBody] DepartmentMaster _departmentMaster)
        {
           try
            {
                //read the data from database
                var exitingDept = _hRMSDbContext.DepartmentMasters.Find(_departmentMaster.DeptId);
                if (exitingDept == null)
                {
                    return NotFound("Department Not Found");
                }
                else
                {
                    _hRMSDbContext.DepartmentMasters.Update(_departmentMaster);
                    await _hRMSDbContext.SaveChangesAsync();
                    return Ok("Department Data Update SucessFully");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = ex.Message });
            }
        }
        //=======================delete data from database======================================
        [HttpDelete("deleteDepartmentData/{id}")]
        public async Task<IActionResult> deleteDepartmentData(int id)
        {
            try
            {
                var exitingDeptId = await _hRMSDbContext.DepartmentMasters.FindAsync(id);
                if (exitingDeptId == null)
                {
                    return NotFound("Department Not Found");
                }
                else
                {
                    _hRMSDbContext.DepartmentMasters.Remove(exitingDeptId);
                    await _hRMSDbContext.SaveChangesAsync();
                    return Ok("Department Data Delete SucessFully");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = ex.Message });
            }
        }
        //=================get all data ============================
        [HttpGet("getAllDepartments")]
        public async Task<IActionResult> selectAllDepartments()
        {
            try
            {
                var deptList = await _hRMSDbContext.DepartmentMasters.ToListAsync();
                if (deptList.Count > 0)
                {
                    return Ok(deptList);
                }
                else
                {
                    return BadRequest("No Department Avalible");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = ex.Message });
            }
        }
    }
}
