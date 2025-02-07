﻿using BusinnesLayer.Abtstract.AbstractUow;
using DataAccessLayer.Abstract;
using DataAccessLayer.UnitOfWork;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnesLayer.Concrete.ConcreteUow
{
    public class AccountManager : IAccountService
    {
        private readonly IAccountDal _accountDal;
        private readonly IUnitOfWorkDal _unitOfWorkDal;

        public AccountManager(IAccountDal accountDal, IUnitOfWorkDal unitOfWorkDal)
        {
            _accountDal = accountDal;
            _unitOfWorkDal = unitOfWorkDal;
        }

        public void TDelete(Account t)
        {
            _accountDal.Delete(t);
            _unitOfWorkDal.Save();
        }

        public Account TGetByID(int id)
        {
            return _accountDal.GetByID(id);
        }

        public void TInsert(Account t)
        {
            _accountDal.Insert(t);
            _unitOfWorkDal.Save();
        }

        public void TMultiUpdate(List<Account> t)
        {
            _accountDal.MultiUpdate(t);
            _unitOfWorkDal.Save();
        }

        public void TUpdate(Account t)
        {
            _accountDal.Update(t);
            _unitOfWorkDal.Save();
        }
    }
}
