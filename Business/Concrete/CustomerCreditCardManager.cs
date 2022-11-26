﻿using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.Generics;
using Core.Aspects.Autofac.Logging;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;
using Core.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CustomerCreditCardManager : ICustomerCreditCardService
    {
        private ICustomerCreditCardDal _customerCreditCardDal;

        public CustomerCreditCardManager(ICustomerCreditCardDal customerCreditCardDal)
        {
            _customerCreditCardDal = customerCreditCardDal;
        }
        [LogAspect(typeof(FileLogger))]
        [SecuredOperation("admin")]
        //[ValidationAspect(typeof(CustomerCreditCardValidator))]
        public IResult Add(CustomerCreditCard customerCreditCard)
        {
            _customerCreditCardDal.Add(customerCreditCard);
            return new SuccessResult();
        }
        [LogAspect(typeof(FileLogger))]
        [SecuredOperation("admin")]
        public IResult Delete(CustomerCreditCard customerCreditCard)
        {
            _customerCreditCardDal.Delete(customerCreditCard);
            return new SuccessResult(Messages.DeletedCustomerCreditCard);
        }
        [LogAspect(typeof(FileLogger))]
        [SecuredOperation("admin")]
        //[ValidationAspect(typeof(CustomerCreditCardValidator))]
        public IResult Update(CustomerCreditCard customerCreditCard)
        {
            _customerCreditCardDal.Update(customerCreditCard);
            return new SuccessResult();
        }
        public IDataResult<List<CustomerCreditCard>> GetAll()
        {
            return new SuccessDataResult<List<CustomerCreditCard>>(_customerCreditCardDal.GetAll());
        }

        public IDataResult<List<CustomerCreditCard>> GetByCustomerId(int customerId)
        {
            return new SuccessDataResult<List<CustomerCreditCard>>(
            _customerCreditCardDal.GetAll(c => c.CustomerId == customerId));
        }


        public IDataResult<List<CustomerPaymentDetailDto>> GetDetailsByCustomerId(int customerId)
        {
            return new SuccessDataResult<List<CustomerPaymentDetailDto>>(
            _customerCreditCardDal.GetDetails(c => c.UserId == customerId));
        }


    }
}