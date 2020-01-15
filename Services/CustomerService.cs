using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CustomerService : ICustomerService
    {
        private ICustomerRepository _iCustomerRepository;

        public CustomerService(ICustomerRepository iCustomerRepository)
        {
            _iCustomerRepository = iCustomerRepository;
        }


        public List<Customer> GetCustomers()
        {
            return _iCustomerRepository.GetCustomers();
        }

        public Customer GetCustomerDetails(int CustomerId)
        {
            return _iCustomerRepository.GetCustomerDetails(CustomerId);
        }

    }
}
