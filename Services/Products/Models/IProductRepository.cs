namespace Services.Products.Models
{
    public interface IProductRepository
    {
        Product GetById(int id);
        List<Product> GetAll();
        void Add(Product product);
        void Update(Product product);
    }
}