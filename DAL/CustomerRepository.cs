using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CustomerRepository : ICustomerRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<Customer> GetCustomers()
        {
            return new List<Customer>(){
                new Customer { CustomerId = 1, City = "Visakhapatnam", CustomerName = "Tulasi" },
                new Customer { CustomerId = 2, City = "Hyderabad", CustomerName = "Ramana" },
                new Customer { CustomerId = 3, City = "Bangalore", CustomerName = "Bablu" },
                new Customer { CustomerId = 4, City = "Chennai", CustomerName = "Brammaji" },
            };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="CustomerId"></param>
        /// <returns></returns>        
        public Customer GetCustomerDetails(int CustomerId)
        {
            //if (CustomerId == null)
            //{
            //    return null;
            //}            
            var CustomerDetails = GetCustomers().SingleOrDefault(c => c.CustomerId == CustomerId);
            return CustomerDetails;
        }

        

    }
}
