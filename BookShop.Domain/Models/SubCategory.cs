using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Domain.Models
{
    public  class SubCategory
    {
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessageResourceType = typeof(Resources.ModelResource), ErrorMessageResourceName = ("RequiredField"))]
        [MaxLength(20, ErrorMessageResourceType = typeof(Resources.ModelResource), ErrorMessageResourceName = "MaxLengthField")]
        public string Name { get; set; }
        public int CurrentStatus { get; set; }
        public Guid CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
        public virtual ICollection<LogSubCategory> LogSubCategories { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}
