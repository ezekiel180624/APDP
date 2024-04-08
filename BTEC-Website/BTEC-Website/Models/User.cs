using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace BTEC_Website.Models
{
    public class User : IdentityUser
    {

        [StringLength(100)]
        [MaxLength(100)]
        [Required]
        public string? Name {  get; set; }
        public string? Address {  get; set; }
    }
}
