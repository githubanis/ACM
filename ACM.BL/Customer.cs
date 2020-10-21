using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
        public Customer() : this(0)
        {

        }
        public Customer(int customerId)
        {
            CustomerId = customerId;
            AddressList = new List<Address>();
        }
        public List<Address> AddressList { get; set; }
        public int CustomerId { get; private set; }
        public int CustomerType { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        { 
            get 
            {
                string fullName = FirstName;
                if (!string.IsNullOrEmpty(LastName))
                {
                    if (!string.IsNullOrEmpty(fullName))
                    {
                        fullName += " ";
                    }
                    fullName += LastName;
                }
                return fullName;
            } 
        }
        public string EmailAddress { get; set; }
        public static int InstanceCount { get; set; }

        public override string ToString() => FullName;

        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrEmpty(LastName)) isValid = false;
            if (string.IsNullOrEmpty(EmailAddress)) isValid = false;

            return isValid;
        }
    } 
}
