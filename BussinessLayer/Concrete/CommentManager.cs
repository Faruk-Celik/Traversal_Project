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
    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public void TAdd(Comment t)
        {
          _commentDal.Insert(t);
        }

        public void TDelete(int id)
        {
          _commentDal.Delete(id);
        }

        public Comment TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Comment> TGetList()
        {
          return _commentDal.GetList();
        }
        public List<Comment> TGetDestinationById(int id)  
        { 
             return _commentDal.GetlistByFilter(x=>x.DestinationId == id);
        }
        public void TUpdate(Comment t)
        {
            throw new NotImplementedException();
        }

        public List<Comment> TGetCommentWithDestination()
        {
           return _commentDal.GetCommentWithDestination();
        }

        public List<Comment> TGetListCommentWithDestinationAndUser(int id)
        {
            return _commentDal.GetListCommentWithDestinationAndUser(id);      
        }
    }
}
