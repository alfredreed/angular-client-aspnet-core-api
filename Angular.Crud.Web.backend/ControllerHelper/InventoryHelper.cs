using Angular.Crud.Web.backend.Models;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;
using System.Data;

namespace Angular.Crud.Web.backend.ControllerHelper
{
    public class InventoryHelper
    {
        private readonly string _connString;

        public InventoryHelper(IOptions<ConnectionStringSettings> settings) 
        {
            _connString = settings.Value.DefaultConnection;
        }

        public List<InventoryModel> GetInventoryData() 
        {
            List<InventoryModel> result = new List<InventoryModel>();

            SqlConnection _conn = new SqlConnection
            {
                ConnectionString = _connString,
            };

            SqlCommand cmd = new SqlCommand
            {
                CommandText = "sp_GetInventory",
                CommandType = CommandType.StoredProcedure,
                Connection = _conn
            };

            _conn.Open();

            using (SqlDataReader sqlReader = cmd.ExecuteReader())
            {
                while (sqlReader.Read())
                {
                    InventoryModel invObj = new InventoryModel()
                    {
                        ProductId = Convert.ToInt32(sqlReader["ProductId"]),
                        ComicTitle = sqlReader["ComicTitle"].ToString(),
                        ImagePath = sqlReader["ImagePath"].ToString(),
                        ComicPrice = Convert.ToDecimal(sqlReader["ComicPrice"]),
                        Quantity = Convert.ToInt32(sqlReader["Quantity"])
                    };

                    result.Add(invObj);
                }
            }

            _conn.Close();

            return result;
        }
    }
}
