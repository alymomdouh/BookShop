using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookShop.Domain.Models
{
    public class Category
    {
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessageResourceType = typeof(Resources.ModelResource), ErrorMessageResourceName = ("RequiredField"))]
        [MaxLength(20,ErrorMessageResourceType = typeof(Resources.ModelResource), ErrorMessageResourceName = "MaxLengthField")]
        public string Name { get; set; }
        public string Description { get; set; }
        public int CurrentStuts { get; set; }
        public virtual ICollection<SubCategory> SubCategories { get; set; }
        public virtual ICollection<LogCategory> LogCategories { get; set; }
        public virtual ICollection<Book> Books { get; set; }

    }
}
