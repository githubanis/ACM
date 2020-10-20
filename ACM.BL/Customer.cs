using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
        public Customer()
        {

        }
        public Customer(int CustomerId)
        {
            this.CustomerId = CustomerId;
        }
        public int CustomerId { get; private set; }
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

        public Customer Retrieve(int prodictId)
        {
            return new Customer();
        }
        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }
        public bool Save()
        {
            return true;
        }
        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrEmpty(LastName)) isValid = false;
            if (string.IsNullOrEmpty(EmailAddress)) isValid = false;

            return isValid;
        }
    } 
}
