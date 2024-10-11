using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Abstract.AbstractUow
{
   public interface IGenericUowService<T>
    {
        T TGetbyId(int id);
        void TInsert(T t);  
        void TUpdate(T t); 
        void TMultiUpdate(List<T> t);
    }
}
