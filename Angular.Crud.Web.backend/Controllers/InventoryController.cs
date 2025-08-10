using Angular.Crud.Web.backend.ControllerHelper;
using Angular.Crud.Web.backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Angular.Crud.Web.backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InventoryController : ControllerBase
    {
        private readonly InventoryHelper _inventoryHelper;
        public InventoryController(InventoryHelper inventoryHelper) 
        {
            _inventoryHelper = inventoryHelper;
        }

        [HttpGet]
        public ActionResult GetInventoryData() 
        {
            List<InventoryModel> result = new List<InventoryModel>();

            result = _inventoryHelper.GetInventoryData();

            return Ok();
        }
    }
}
