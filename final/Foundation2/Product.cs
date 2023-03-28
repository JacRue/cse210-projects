using System;

namespace OnlineOrdering
{
    class Product
    {
        private string name;
        private string productId;
        private decimal price;
        private decimal quantity;

        public Product(string name, string productId, decimal price, int quantity)
        {
            this.name = name;
            this.productId = productId;
            this.price = price;
            this.quantity = quantity;
        }

        public decimal PricePerUnit
        {
            get { return price; }
            set { price = value; }
        }

        public decimal Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public decimal TotalPrice
        {
            get { return price * quantity; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string ProductId
        {
            get { return productId; }
            set { productId = value; }
        }

    }
}