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
    public class GuideManage : IGuideService
    {
        IGuideDal _guideDAL;

        public GuideManage(IGuideDal guideDAL)
        {
            _guideDAL = guideDAL;
        }

        public void TAdd(Guide t)
        {
            throw new NotImplementedException();
        }

        public void TChangeToFalseGuide(int id)
        {
            _guideDAL.ChangeToFalseGuide(id);
        }

        public void TChangeToTrue(int id)
        {
            _guideDAL.ChangeToTrue(id);
        }

        public void TDelete(int id)
        {
            throw new NotImplementedException();
        }

        public Guide TGetById(int id)
        {
           return _guideDAL.GetById(id);
        }

        public List<Guide> TGetList()
        {
            return _guideDAL.GetList();
        }

        public void TUpdate(Guide t)
        {
            throw new NotImplementedException();
        }
    }
}
