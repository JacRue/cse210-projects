using System;

namespace OnlineOrdering
{
    class Address
    {
        private string streetAddress;
        private string city;
        private string stateProvince;
        private string country;

        public Address(string streetAddress, string city, string stateProvince, string country)
        {
            this.streetAddress = streetAddress;
            this.city = city;
            this.stateProvince = stateProvince;
            this.country = country;
        }

        public string StreetAddress
        {
            get { return streetAddress; }
            set { streetAddress = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string StateProvince
        {
            get { return stateProvince; }
            set { stateProvince = value; }
        }

        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        public bool IsInUSA()
        {
            return this.Country == "USA";
        }
    }
}