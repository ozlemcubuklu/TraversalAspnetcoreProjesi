using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Abstract
{
    public interface ICommentDal: IGenericDal<Comment>
    {
       List<Comment> GetCommentsWithDestinations();
        List<Comment> GetCommentsWithDestinationsandAppUser(int id);
        List<Comment> GetCommentsWithDestinationsByAppUserId(int id);
        
    }
}
