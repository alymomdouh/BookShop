using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Domain.Models
{
    public class LogCategory
    {
        [Key]
        public Guid Id { get; set; }
        public string Action { get; set; }
        public DateTime Date { get; set; }
        public Guid UserId { get; set; }    
        public Guid CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category  Category { get; set; }
    }
}
