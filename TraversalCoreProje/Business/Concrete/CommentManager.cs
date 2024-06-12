using Business.Abstract;
using Data.Abstract;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public void Delete(Comment t)
        {
            _commentDal.Delete(t);
        }

        public List<Comment> GetAll()
        {
           return _commentDal.GetAll();
        }

        public Comment GetById(int id)
        {
            return _commentDal.GetById(id);
        }

        public List<Comment> GetCommentsWithDestinations()
        {
            return _commentDal.GetCommentsWithDestinations();
        }

        public List<Comment> GetCommentsWithDestinationsandAppUser(int id)
        {
            return _commentDal.GetCommentsWithDestinationsandAppUser(id);
        }

		public List<Comment> GetCommentsWithDestinationsByAppUserId(int id)
		{
            return _commentDal.GetCommentsWithDestinationsByAppUserId(id);
		}

		public List<Comment> GetDestinationById(int id)
        {
            return _commentDal.GetListByFilter(a=>a.DestinationId==id).ToList();
        }

        public void Insert(Comment t)
        {
             _commentDal.Insert(t);
        }

        public void Update(Comment t)
        {
            _commentDal.Update(t);
        }

    }
}
