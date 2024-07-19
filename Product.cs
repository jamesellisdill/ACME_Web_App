using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME_Web_App
{
    // PRODUCT IS THE OBJECT FOR A GIVEN ENTRY IN THE INVENTORY DATABASE
    public class Product
    {
        // VARS
        private bool availability;
        private string id;
        private string description;
        private string supplier;
        private string brand;

        // CONSTRUCTOR
        public Product(bool availability, string id, string description, string supplier, string brand)
        {
            this.availability = availability;
            this.id = id;
            this.description = description;
            this.supplier = supplier;
            this.brand = brand;
        }

        // VIEW PRODUCT DETAILS FOR ORDERING
        public string ViewProductInfo()
        {
            return $"{id}, {description}, {supplier}, {brand}, {(availability ? "Active" : "Restricted")}";
        }

        // GET STATUS TO SEE IF PRODUCT IS ACTIVE OR RESTRICTED
        public bool GetAvailability()
        {
            return availability;
        }

        // GET ID
        public string GetID()
        {
            return id;
        }

        // GET DESCRIPTION
        public string GetDescription()
        {
            return description;
        }

        // GET SUPPLIER
        public string GetSupplier()
        {
            return supplier;
        }

        // GET BRAND
        public string GetBrand()
        {
            return brand;
        }
    }
}