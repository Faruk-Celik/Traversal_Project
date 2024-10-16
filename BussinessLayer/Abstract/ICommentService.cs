﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Abstract
{
    public interface ICommentService : IGenericService<Comment>
    {
        List<Comment> TGetDestinationById(int id);
        List<Comment> TGetCommentWithDestination();
        List<Comment> TGetListCommentWithDestinationAndUser(int id);
    }
}
