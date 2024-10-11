using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccessLayer.EntityFramework
{
    public class EfAccountDal:GenericUowRepository<Account>, IAccountDal
    {
        public EfAccountDal(Context context):base (context)
        {
            
        }

     
    }
}
