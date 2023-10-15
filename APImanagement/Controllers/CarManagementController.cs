using Context.Models;
using Microsoft.AspNetCore.Mvc;
using Service.Interface;

namespace APImanagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarManagementController : Controller
    {
        private readonly ICarManagement _ICarManagement;
        

        public CarManagementController(ICarManagement ICarManagement)
        {
            _ICarManagement = ICarManagement;
           
        }
        [HttpGet]
        [Route("getlist")]
        public async Task<ActionResult> CarManagementList(int id)
        {
            var result = await _ICarManagement.GetDataForCarmanagement(id);
            return new OkObjectResult(result);
        }
        [HttpPost]
        [Route("create")]
        public async Task<ActionResult<bool>> CreateCarManagement([FromBody] TblCarManagement model)
        {
            var result = await _ICarManagement.CreateSqlStoredProcedure("Insert", model);
            return Ok(result);
        }
        [HttpPost]
        [Route("update")]
        public async Task<ActionResult<bool>> UpdateCarManagement([FromBody] TblCarManagement model)
        {
            var result = await _ICarManagement.UpdateSqlStoredProcedure("Update", model);
            return Ok(result);
        }
        [HttpDelete]
        [Route("delete")]
        public async Task<ActionResult<bool>> Delete(int ID)

        {
            var result = await _ICarManagement.DeleteSqlStoredProcedure("Delete", ID);
            return Ok(result);
        }
    }
}
