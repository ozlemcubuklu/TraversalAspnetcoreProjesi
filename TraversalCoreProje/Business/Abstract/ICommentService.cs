using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICommentService:IGenericService<Comment>
    {
        List<Comment> GetDestinationById(int id);
        List<Comment> GetCommentsWithDestinations();
        List<Comment> GetCommentsWithDestinationsandAppUser(int id);

		List<Comment> GetCommentsWithDestinationsByAppUserId(int id);
	}
}
