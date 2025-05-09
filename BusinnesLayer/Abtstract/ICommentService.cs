﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnesLayer.Abtstract
{
    public interface ICommentService : IGenericService<Comment>
    {
        List<Comment> TGetDestinationById(int id);
        List<Comment> TGetListCommentWithDestinaiton();
        List<Comment> TGetListCommentWithDestinationAndUser(int id);

    }
}
