using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer : EntityBase , ILoggable
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

        //public string Log()
        //{
        //    var logString = CustomerId + ": " +
        //        FullName + " " +
        //        "Email: " + EmailAddress + " " +
        //        "Status: " + EntityState.ToString();
        //    return logString;
        //}
        public string Log() => $"{CustomerId}: {FullName} Email: {EmailAddress} Status: {EntityState.ToString()}";
        public override string ToString() => FullName;

        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrEmpty(LastName)) isValid = false;
            if (string.IsNullOrEmpty(EmailAddress)) isValid = false;

            return isValid;
        }
    } 
}
