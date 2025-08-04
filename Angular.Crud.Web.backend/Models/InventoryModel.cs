namespace Angular.Crud.Web.backend.Models
{
    public class InventoryModel
    {
        public int ProductId { get; set; }
        public string? ComicTitle { get; set; }
        public string? ImagePath { get; set; }
        public decimal ComicPrice { get; set; }
        public int Quantity { get; set; }
    }
}
