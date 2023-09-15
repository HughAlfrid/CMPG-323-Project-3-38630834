using Data;
using Models;

namespace EcoPower_Logistics.Repository
{
    public class CustomerRepo : GenericRepo<Customer>, ICustomerRepository
    {
        public CustomerRepo(SuperStoreContext context) : base(context) { }
    }
}
