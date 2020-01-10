using EventReservations.Enums;
using System;

namespace EventReservations.Models
{
    public class OrderModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }
        public int NumberOfTickets { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public DateTime PurchaseDate { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; }
    }
}
