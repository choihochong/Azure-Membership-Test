using MultiTenantAuthentication.Models;
using System.Collections.Generic;

namespace MultiTenantAuthentication.ViewModels
{
    public class ProfileCustomerViewModel
    {
        public UserProfile UserProfile;
        public List<Customer> Customers;
    }
}