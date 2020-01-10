using EventReservations.Models;

namespace EventReservations.Services
{
    public interface IPurchaseStrategyService
    {
        public int ExecutePurchase(PurchaseOrderModel purchaseOrder);
    }
}
