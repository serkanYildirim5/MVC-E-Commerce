using Mvc_E_Commerce.Entity.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc_E_Commerce.DAL.Managments
{
    public class CommentManagment
    {
        private Mvc_E_CommerceContext database;

        public CommentManagment()
        {
            database = new Mvc_E_CommerceContext();
        }

        public Comment AddComment(Comment Comment)
        {
            return database.Set<Comment>().Add(Comment);
        }

        public void UpdateComment(Comment Comment)
        {
            database.Entry(Comment).State = EntityState.Modified;
        }

        public void DeleteComment(Comment Comment)
        {
            database.Set<Comment>().Remove(Comment);
        }

        public void ChangeComment(Comment eskiComment, Comment yeniComment)
        {
            database.Entry(eskiComment).CurrentValues.SetValues(yeniComment);
        }

        public List<Comment> GetComment()
        {
            return database.Set<Comment>().ToList();
        }

        public Comment GetCommentById(int CommentId)
        {
            return database.Set<Comment>().FirstOrDefault(u => u.CommentId == CommentId);
        }

        public int CommentChangeSave()
        {
            return database.SaveChanges();
        }

    }
}
