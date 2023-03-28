using System;
using System.Collections.Generic;

namespace OnlineOrdering
{
    class Order
    {
        private List<Product> products;
        private Customer customer;
        private decimal price;

        public Order(Customer customer)
        {
            products = new List<Product>();
            this.customer = customer;
            price = 0;
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
            price += product.PricePerUnit * product.Quantity;
        }

        public decimal GetTotalCost()
        {
            decimal totalCost = price;

            if (customer.IsInUSA())
            {
                totalCost += 5.0m;
            }
            else
            {
                totalCost += 35.0m;
            }

            return totalCost;
        }

        public string GetPackingLabel()
        {
            string packingLabel = "Packing Label:\n";
            foreach (Product product in products)
            {
                packingLabel += product.Name + " (" + product.ProductId + ")\n";
            }

            return packingLabel;
        }

        public string GetShippingLabel()
        {
            string shippingLabel = "Shipping Label:\n";
            shippingLabel += customer.Name + "\n";
            shippingLabel += customer.Address.ToString();

            return shippingLabel;
        }
    }
}