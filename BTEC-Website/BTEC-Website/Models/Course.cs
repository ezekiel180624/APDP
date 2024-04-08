using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace BTEC_Website.Models
{
    public class Course 
    {
        public int Id { get; set; }

        [StringLength(100)]
        [MaxLength(100)]
        [Required]
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}
