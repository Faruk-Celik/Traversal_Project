using BussinessLayer.Abstract.AbstractUow;
using DataAccessLayer.Abstract;
using DataAccessLayer.UnitOfWork;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BussinessLayer.Concrete.UowConcrete
{
    public class AccountManager : IAccountService
    { 
        private readonly IAccountDal _accountDal; 
        private readonly IUowDal _uowDal;

        public AccountManager(IUowDal uowDal, IAccountDal accountDal)
        {
            _uowDal = uowDal;
            _accountDal = accountDal;
        }

        public Account TGetbyId(int id)
        {
            return _accountDal.GetbyId(id);
        }

        public void TInsert(Account t)
        {
            _accountDal.Insert(t);
            _uowDal.Save();
        }

        public void TMultiUpdate(List<Account> t)
        {
            _accountDal.MultiUpdate(t); 
            _uowDal.Save();
        }

        public void TUpdate(Account t)
        {
            _accountDal.Update(t);
            _uowDal.Save();
        }
    }
}
