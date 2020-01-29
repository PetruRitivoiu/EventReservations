using EventReservations.Enums;
using EventReservations.Models;
using System.Collections.Generic;

namespace EventReservations.Services.PurchaseStrategy
{
    public class PurchaseContext
    {
        private static PurchaseContext instance;
        private static object instanceLock;

        private PurchaseContext()
        {
            instanceLock = new object();

            PurchaseStrategies = new Dictionary<PaymentMethod, IPurchaseStrategy>()
            {
                { PaymentMethod.Cash, new CashPurchaseStrategy() },
                { PaymentMethod.CreditCard, new CreditCardPurchaseStrategy() }
            };
        }

        public static PurchaseContext Instance
        {
            get
            {
                lock (instanceLock)
                {
                    return instance ?? (instance = new PurchaseContext());
                }
            }
        }

        private IPurchaseStrategy PurchaseStrategy { get; set; }

        private Dictionary<PaymentMethod, IPurchaseStrategy> PurchaseStrategies { get; set; }

        public PurchaseContext SetStrategy(PaymentMethod type)
        {
            PurchaseStrategy = PurchaseStrategies[type];
            return this;
        }

        public PurchaseStatus ExecutePurchase(PurchaseOrderModel purchaseOrder) =>
            PurchaseStrategy.ExecuteStrategy(purchaseOrder);
    }
}
