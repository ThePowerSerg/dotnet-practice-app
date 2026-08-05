namespace Services.Products.Models
{
    public class ProductRepository : IProductRepository
    {
        private readonly List<Product> _products = new();

        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}