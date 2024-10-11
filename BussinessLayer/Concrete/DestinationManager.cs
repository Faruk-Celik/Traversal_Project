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
    public class DestinationManager : IDestinationService
    {
        private readonly IDestinationDal _destinationDal;

        public DestinationManager(IDestinationDal destinationDal)
        {
            _destinationDal = destinationDal;
        }

        public void TAdd(Destination t)
        {
            _destinationDal.Insert(t);
        }

        public void TDelete(int id)
        {
            _destinationDal.Delete(id);
        }

        public Destination TGetById(int id)
        {
           return _destinationDal.GetById(id);
        }

        public Destination TGetDestinationWithGuide(int id)
        {
            return _destinationDal.GetDestinationWithGuide(id);
        }

        public List<Destination> TGetLast4Destinations()
        {
            return _destinationDal.GetLast4Destinations();
        }

        public List<Destination> TGetList()
        {
            return _destinationDal.GetList();
        }

        public void TUpdate(Destination t)
        {
           _destinationDal.Update(t);
        }
    }
}
