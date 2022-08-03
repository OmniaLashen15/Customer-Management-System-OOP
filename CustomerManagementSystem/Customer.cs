using CustomerManagementSystem.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManagementSystem
{
    public class Customer:EntityBase, ILoggable
    {

        public Customer():this(0)  // to call parameterized ctor (ctor chaining)
        {
        }
        public Customer(int customerId)
        {
                CustomerId = customerId;
                AddressList = new List<Address>();
        }
        //public Address HomeAddress { get; set; }
        //public Address WorkAddress { get; set; }
        public int CustomerType { get; set; }
        public List<Address> AddressList { get; set; }
        public int CustomerId { get; set; }
        public string EmailAddress { get; set; }
        public string FullName
        {
            get
            {
                string fullName = LastName;
                if(!string.IsNullOrWhiteSpace(FirstName))
                {
                    if(!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }
                return fullName;
            }
        }
        public string FirstName { get; set; }

        
        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public static int InstanceCount { get; set; }
        public string Log() =>
            $"{CustomerId}: {FullName} Email: {EmailAddress} Status: {EntityState.ToString()}";
        // {
        //    var logString = CustomerId + ": " +
        //                    FullName + " " +
        //                    "Email: " + EmailAddress + " " +
        //                   "Status: " + EntityState.ToString();
        //    return logString;
        //}
        public override string ToString() => FullName;

        public override bool Validate()
        {
            var isValid = true;

            if(string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if(string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }


        
    }
}
