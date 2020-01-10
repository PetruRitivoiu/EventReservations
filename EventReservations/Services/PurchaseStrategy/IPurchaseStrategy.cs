using EventReservations.Models;

namespace EventReservations.Services.PurchaseStrategy
{
    interface IPurchaseStrategy
    {
        PurchaseStatus ExecuteStrategy(PurchaseOrderModel purchaseOrder);
    }
}
