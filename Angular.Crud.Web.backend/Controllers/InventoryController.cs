using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Angular.Crud.Web.backend.Controllers
{
    public class InventoryController : ControllerBase
    {
        [HttpGet]
        public ActionResult GetInventoryData() 
        {
            return Ok();
        }
    }
}
