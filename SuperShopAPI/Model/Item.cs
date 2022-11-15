namespace SuperShopAPI.Model
{
    public class Item
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public DateTime ItemInDate { get; set; }
        public DateTime OutDate { get; set; }
        public decimal Price { get; set; }
        public Boolean IsAvailable { get; set; }
    }
}
