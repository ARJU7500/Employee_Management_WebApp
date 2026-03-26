using HRMSWEBAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HRMSWEBAPI.Controllers.Master
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeginationMasterController : ControllerBase
    {
        public readonly HRMSDbContext _hRMSDbContext;
        public DeginationMasterController(HRMSDbContext _contex)
        {
            _hRMSDbContext = _contex;
        }
        //================POST/SAVE DATA INTO DATABASE=====================
        [HttpPost("saveDesinationData")]
        public async Task<IActionResult> SaveDesignationData([FromBody] DeginationMaster _deginationMaster)
        {
            try
            {
                var exitisDegination = await _hRMSDbContext.DeginationMasters.AnyAsync(d => d.DeginationName == _deginationMaster.DeginationName);
                if(exitisDegination)
                {
                    return BadRequest("Desigation Already exists.");
                }
                else
                {
                    _hRMSDbContext.DeginationMasters.Add(_deginationMaster);
                    await _hRMSDbContext.SaveChangesAsync();
                    return Ok("Desigation Data Saved Sucessfully");
                }
            }
            catch(Exception ex)
            {
                return StatusCode(500, new { Message = ex.Message });
            }
        }
        //================update data into database===========================
        [HttpPut("updateDesignationData")]
        public async Task<IActionResult> UpdateDesigationData([FromBody] DeginationMaster _deginationMaster)
        {
            try
            {
                var exitingDesigation = await _hRMSDbContext.DeginationMasters.FindAsync(_deginationMaster.DeginationId);
                if(exitingDesigation==null)
                {
                    return BadRequest("Desinagation Not Found");
                }
                else
                {
                    _hRMSDbContext.DeginationMasters.Update(_deginationMaster);
                    await _hRMSDbContext.SaveChangesAsync();
                    return Ok("Desigation Data Update SucessFully.");
                }

            }
            catch(Exception ex)
            {
                return StatusCode(500, new { Message = ex.Message });
            }
        }
        //============Delete data from database======================
        [HttpDelete("deleteDesigationData/{id}")]
        public async Task<IActionResult> deleteDesigationData(int id)
        {
            try
            {
                var exitingDesinationId = await _hRMSDbContext.DeginationMasters.FindAsync(id);
                if(exitingDesinationId == null)
                {
                    return BadRequest("Designation not found");
                }
                else
                {
                    _hRMSDbContext.DeginationMasters.Remove(exitingDesinationId);
                    await _hRMSDbContext.SaveChangesAsync();
                    return Ok("Desigation Data Is Deleted Sucessfully");
                }
            }
            catch(Exception ex)
            {
                return StatusCode(500, new { Message = ex.Message });
            }
        }
        //=======GET ALL DATA FROM DATABSE===============
        [HttpGet("getAllDegination")]
        public async Task<IActionResult> getAllDeginationData()
        {
            try
            {
                var deginationList = await _hRMSDbContext.DeginationMasters.ToListAsync();
                return Ok(deginationList);
            }
            catch(Exception ex)
            {
                return StatusCode(500, new { Message = ex.Message });
            }
        }
    }
}
