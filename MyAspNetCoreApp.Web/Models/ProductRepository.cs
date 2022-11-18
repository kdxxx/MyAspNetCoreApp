namespace MyAspNetCoreApp.Web.Models
{
    public class ProductRepository
    {
        //necessary to be static
        private static List<Product> _products = new List<Product>()
        {
            new Product(){Id = 1,Name = "Kalem",Price = 100,Stock = 20},
            new Product() { Id = 2,Name = "Defer",Price = 140,Stock = 50},
            new Product() { Id = 3,Name = "Silgi",Price = 300,Stock = 30},

        }; 

        public List<Product> GetAll() =>  _products;
        public void Add(Product newProduct) => _products.Add(newProduct);
        public void Remove(int id)
        {
            var hasProduct = _products.FirstOrDefault( x => x.Id == id);
            if(hasProduct == null)
            {
                throw new Exception($"there is no product with this id ({id})");
            }
            _products.Remove(hasProduct);
        }
        public void Update(Product updateProduct)
        {
            var hasProduct = _products.FirstOrDefault(x => x.Id == updateProduct.Id);
            if(hasProduct == null)
            {
                throw new Exception($"There is no product with this id {updateProduct.Id}");
            }
            hasProduct.Name = updateProduct.Name;
            hasProduct.Price = updateProduct.Price;
            hasProduct.Stock = updateProduct.Stock;

            var index = _products.FindIndex(x => x.Id == updateProduct.Id);
            _products[index] = hasProduct;
        }
    }
}
