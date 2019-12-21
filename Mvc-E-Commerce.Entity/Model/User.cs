using System.Collections.Generic;

namespace Mvc_E_Commerce.Entity.Model
{
    public class User
    {
        public User()
        {
            Orders = new HashSet<Order>();
            Wishlists = new HashSet<WishList>();
            Comments = new HashSet<Comment>();
        }
        public int UserId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }      
        public string Email { get; set; }
        public string Phone { get; set; }     
        public string Address { get; set; }
        
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<WishList> Wishlists { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}