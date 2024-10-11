using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
   public interface IContactUsDal:IGenericDal<ContacUs>
    {
        List<ContacUs> GetListContactUsByTrue(); 
        List<ContacUs> GetListContactUsByFalse();
        void ContactUsStatusChangeToFalse(int id);
    }
}
