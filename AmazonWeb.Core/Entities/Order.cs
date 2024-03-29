﻿using AmazonWeb.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazonWeb.Core.Entities
{
    public class Order : Entity
    {
        public string UserName { get; set; }
        public Address BillingAddress { get; set; }
        public Address ShippingAddress { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public OrderStatus Status { get; set; }
        public decimal GrandTotal { get; set; }

        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
    }

        //Value Object
    public class Address 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNo { get; set; }
        public string CompanyName { get; set; }
        public string AddressLine { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
    }

    public enum OrderStatus 
    { 
        Progress=1,
        OnShipping =2,
        Finished = 3
    }
    public enum PaymentMethod
    { 
        Check=1,
        BankTransfer =2,
        Cash=3,
        Paypal=4,
        Payoneer=5
    }

        /*//properties of order
        public int OrderID { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime DateTime { get; set; }
        public bool CheckOutstatus { get; set; }
        public int CartID { get; set; }

        //relation of order
        public Cart cart { get; set; }
        public Payment payment { get; set; }*/
    
}
