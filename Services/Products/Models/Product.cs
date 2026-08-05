namespace Services.Products.Models
{
    public class Product
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public long Price { get; set; }
        public string? PictureURL { get; set; }
        public string? Type { get; set; }
        public string? Brand { get; set; }
        public int QuantityInStock { get; set; }
    }
}