namespace eshopapp.Models
{
    public class Orders
    {
        public int id { get; set; }
        public int user_id { get; set; }
        public int product_id { get; set; }
        public DateTime date { get; set; }
        public int quantity { get; set; }
    }

}