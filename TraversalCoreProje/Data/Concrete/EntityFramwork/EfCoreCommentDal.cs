using Data.Abstract;
using Data.Concrete.Repository;
using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Concrete.EntityFramwork
{
    public class EfCoreCommentDal : GenericRepository<Comment>, ICommentDal
    {
        private readonly Context _context;

        public EfCoreCommentDal(Context context)
        {
            _context = context;
        }

        public List<Comment> GetCommentsWithDestinations()
        {
          
                var comments = _context.Comments.Include(x=>x.Destination).ToList();
                return comments;
            
        }

        public List<Comment> GetCommentsWithDestinationsandAppUser(int id)
        {

            var comments = _context.Comments.Where(x=>x.DestinationId==id).Include(x => x.AppUser).ToList();
            return comments;

        }

		public List<Comment> GetCommentsWithDestinationsByAppUserId(int id)
		{

			var comments = _context.Comments.Where(x=>x.AppUserId==id).Include(x => x.Destination).ToList();
			return comments;
		}
	}
}
