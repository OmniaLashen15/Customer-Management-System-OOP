using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagementSystem
{
    public class AddressRepository
    {
        public Address Retrieve (int addressId)
        {
            Address address = new Address(addressId);
            if(addressId == 1)
            {
                address.City = "Hobbiton";
                address.StreetLine1 = "Bag End";
                address.StreetLine2 = "Bagshot row";
                address.State = "shire";
                address.AddressType = 1;
                address.Country = "Middle Earth";
                address.PostalCode = "144";
            }

            return address;
        }
        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                City = "Hobbiton",
                StreetLine1 = "Bag End",
                StreetLine2 = "Bagshot row",
                State = "shire",
                AddressType = 1,
                Country = "Middle Earth",
                PostalCode = "144"
             };
            addressList.Add(address);
            address = new Address(2)
            {
                City = "Bywater",
                StreetLine1 = "Green Dragon",
                State = "shire",
                AddressType = 2,
                Country = "Middle Earth",
                PostalCode = "146"
            };
            addressList.Add(address);

            return addressList;


        }
        
        public bool Save(Address address)
        {
            return true;
        }
    }
}
