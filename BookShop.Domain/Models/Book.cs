using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Domain.Models
{
    public  class Book
    {
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessageResourceType = typeof(Resources.ModelResource), ErrorMessageResourceName = ("RequiredField"))]
        [MaxLength(20, ErrorMessageResourceType = typeof(Resources.ModelResource), ErrorMessageResourceName = "MaxLengthField")]
        public string Name { get; set; }
        [Required(ErrorMessageResourceType = typeof(Resources.ModelResource), ErrorMessageResourceName = ("RequiredField"))]
        [MaxLength(20, ErrorMessageResourceType = typeof(Resources.ModelResource), ErrorMessageResourceName = "MaxLengthField")]
        public string Author { get; set; }        
        public string ImageName { get; set; }        
        public string FileName { get; set; }        
        public string Description { get; set; }
        public int CurrentStatus { get; set; }
        public bool Published { get; set; }
        public Guid CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
        public Guid SubCategoryId { get; set; }
        [ForeignKey("SubCategoryId")]
        public SubCategory SubCategory { get; set; }
        public virtual ICollection<LogBook> LogBooks { get; set; }

    }
}
