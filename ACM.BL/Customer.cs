using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {
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
    } 
}
