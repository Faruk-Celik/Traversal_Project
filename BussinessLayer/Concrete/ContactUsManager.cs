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
    public class ContactUsManager : IContactUsService
    {
        IContactUsDal _contactUsdal;

        public ContactUsManager(IContactUsDal contactUsdal)
        {
            _contactUsdal = contactUsdal;
        }

        public void TAdd(ContacUs t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(int id)
        {
          _contactUsdal.Delete(id);
        }

        public ContacUs TGetById(int id)
        { 
           return _contactUsdal.GetById(id);
        }

        public List<ContacUs> TGetList()
        { 
            return _contactUsdal.GetList();
        }

        public List<ContacUs> TGetListContactUsByFalse()
        {
            return _contactUsdal.GetListContactUsByFalse();
        }

        public List<ContacUs> TGetListContactUsByTrue()
        {
            return _contactUsdal.GetListContactUsByTrue();
        }

        public void TUpdate(ContacUs t)
        {
            _contactUsdal.Update(t);
        }
    }
}
