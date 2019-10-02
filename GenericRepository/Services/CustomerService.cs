using Database;
using Microsoft.EntityFrameworkCore;
using Models.Table;
using System;
using System.Collections.Generic;
using System.Linq;
namespace Services
{
    public class CustomerService : ICustomerService
    {
        IDbService _IDbService;
        DbSet<Customer> _customer;
        public CustomerService(IDbService _iDbService)
        {
            this._IDbService = _iDbService;
           this._customer = this._IDbService.SetEntity<Customer>();
        }
        public List<Customer> GetCustomers()
        {
            List<Customer> list = new List<Customer>();
            try
            {
                var data =this._customer.ToList();
                if(data!=null&&data.Count()>0)
                {
                    list = data;
                }
            }
            catch (Exception ex)
            {
           
            }
         
            return list;
        }
    }
}
