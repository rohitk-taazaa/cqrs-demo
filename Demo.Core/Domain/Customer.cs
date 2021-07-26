using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Core.Domain
{
    // domain model
    public class Customer
    {
        public Guid Id { get; set; }
        string fname;
        public string Fname
        {
            get { return fname; }
            set
            {
                if (value.Length == 0)
                {
                    throw new Exception("First Name is required");
                }
                fname = value;
            }
        }
        private string _lname;
        public string Lname
        {
            get { return _lname; }
            set
            {
                if (value.Length == 0)
                {
                    throw new Exception("Last Name is required");
                }
                _lname = value;
            }
        }
        private List<Address> addresses;

        public void AddAddress(Address address)
        {
            addresses.Add(address);
        }
        
    }

    public class CustomerDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Guid Id { get; set; }
    }
    public class Address
    {
        public string Locality { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    } 
}
