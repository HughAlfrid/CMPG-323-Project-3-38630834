using Data;
using Models;

namespace EcoPower_Logistics.Repository
{
    public class ProductRepo : GenericRepo<Product>, IProductsRepository
    {
        public ProductRepo(SuperStoreContext context) : base(context) { }
    }
}
