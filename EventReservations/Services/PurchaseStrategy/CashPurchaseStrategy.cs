using EventReservations.Models;

namespace EventReservations.Services.PurchaseStrategy
{
    public class CashPurchaseStrategy : IPurchaseStrategy
    {
        public PurchaseStatus ExecuteStrategy(PurchaseOrderModel purchaseOrder) => new PurchaseStatus
        {
            Success = true,
            Message = "Order placed successfully. Payment will be made upon delivery"
        };
    }
}
