using EventReservations.Enums;

namespace EventReservations.Models
{
    public class PurchaseOrderModel
    {
        //Preloaded
        public string EventName { get; set; }
        public string EventAddress { get; set; }
        public int EventId { get; set; }

        //HTML Form
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }
        public int NumberOfTickets { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
    }
}
