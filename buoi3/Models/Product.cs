namespace b3_chuchinhnguyen.Models
{
    public class Product
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public decimal Price { get; set; }
        public String Description { get; set; } = string.Empty;
        public String CategoryName { get; set; } = string.Empty;
    }
}
