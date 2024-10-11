using BussinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Concrete
{
    public class AppUserManager : IAppUserService
    {
        IAppUserDal _appuserdal;

        public AppUserManager(IAppUserDal appuserdal)
        {
            _appuserdal = appuserdal;
        }

        public void TAdd(AppUser t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(int id)
        {
            throw new NotImplementedException();
        }

        public AppUser TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<AppUser> TGetList()
        {
            return _appuserdal.GetList();
        }

        public void TUpdate(AppUser t)
        {
            throw new NotImplementedException();
        }
    }
}
