using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfContactUsDal : GenericRepository<ContacUs>, IContactUsDal
    {
        public void ContactUsStatusChangeToFalse(int id)
        {
            throw new NotImplementedException();

        }

        public List<ContacUs> GetListContactUsByFalse()
        {
            using (var context = new Context())
            {

                var values=context.ContacUses.Where(x=>x.IsDeleted==false).ToList(); 
                return values;
            }
        }

        public List<ContacUs> GetListContactUsByTrue()
        {
            using (var context = new Context())
            {

                var values = context.ContacUses.Where(x => x.IsDeleted == true).ToList();
                return values;
            }
        }
    }
}
