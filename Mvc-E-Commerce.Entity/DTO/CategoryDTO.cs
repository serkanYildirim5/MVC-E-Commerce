using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc_E_Commerce.Entity.DTO
{
    public  class CategoryDTO
    {
        public int Id { get; set; }
        [Display(Name ="Kategori Adı")]
        [Required(ErrorMessage ="Bu alan zorunludur")]
        [MinLength(5,ErrorMessage ="{0} uzunluğu en az {1} karakter olmalıdır!")]
        public int CategoryName { get; set; }
        [Display(Name ="Ata Category Id")]
        public int? ParentId { get; set; }
    }
}
