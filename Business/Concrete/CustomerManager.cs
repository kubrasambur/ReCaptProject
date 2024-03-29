﻿using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public IResult Add(Customer customers)
        {
            _customerDal.Add(customers);
            return new SuccessResult(Messages.CustomerAdded);
        }

        public IResult Delete(Customer customers)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Customer>> GetAllCustomers()
        {
            throw new NotImplementedException();
        }

        public IResult Update(Customer customers)
        {
            throw new NotImplementedException();
        }
    }
}
