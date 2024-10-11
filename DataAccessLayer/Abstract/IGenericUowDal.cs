using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericUowDal<T> where T: class
    {   
        T GetbyId(int id);
        void Update(T t);
        void Insert(T t);
        void MultiUpdate(List<T> t);

    }
}
