using Data;
using Models;

namespace EcoPower_Logistics.Repository
{
    public class OrderRepo: GenericRepo<Order>, IOrderRepository
    {
        public OrderRepo(SuperStoreContext context): base(context)
        {

        }
        //public Order GetOrder()
        //{
           
        //}
    }
}
