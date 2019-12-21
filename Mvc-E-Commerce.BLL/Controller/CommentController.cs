using Mvc_E_Commerce.DAL.Managments;
using Mvc_E_Commerce.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc_E_Commerce.BLL.Controller
{
    public class CommentController
    {
        private CommentManagment CommentManagment;

        public CommentController()
        {
            CommentManagment = new CommentManagment();
        }

        public Comment AddComment(Comment Comment)
        {
            Comment addedComment = null;

            if (Comment == null)
                return null;

            if (Comment.CommentContent.Length > 5)
                return null;

            addedComment = CommentManagment.AddComment(Comment);
            CommentManagment.CommentChangeSave();
            return addedComment;
        }
        public void UpdateComment(Comment Comment, Comment yeniComment)
        {
            if (Comment != null && yeniComment != null)
            {
                CommentManagment.UpdateComment(Comment);
                CommentManagment.ChangeComment(Comment, yeniComment);
                CommentManagment.CommentChangeSave();
            }
        }
        public void DeleteComment(Comment Comment)
        {
            if (Comment != null)
            {
                CommentManagment.DeleteComment(Comment);
                CommentManagment.CommentChangeSave();
            }
        }
        public List<Comment> GetComments()
        {
            return CommentManagment.GetComment();
        }
        public Comment GetCommentById(int CommentId)
        {
            if (CommentId == 0)
            {
                return null;
            }
            else
            {
                return CommentManagment.GetCommentById(CommentId);
            }
        }
    }
}
