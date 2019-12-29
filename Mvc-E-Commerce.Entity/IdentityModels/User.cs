using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc_E_Commerce.Entity.IdentityModels
{
    public class User:IdentityUser
    {
        [StringLength(50)]
        [Required]
        public string Name { get; set; }
        [StringLength(250)]
        [Required]
        public string Email { get; set; }
        [StringLength(250)]
        [Required]
        public string UserName { get; set; }
    }
}
