using EventReservations.Models;

namespace EventReservations.Services.PurchaseStrategy
{
    public class CreditCardPurchaseStrategy : IPurchaseStrategy
    {
        public PurchaseStatus ExecuteStrategy(PurchaseOrderModel purchaseOrder)
            => new PurchaseStatus
            {
                Success = true,
                Message = "Credit Card payment was successful"
            };
    }
}
