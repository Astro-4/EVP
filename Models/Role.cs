using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EVP.Models
{
    public class Role
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(15, MinimumLength = 5)]
        [Display(Name = "Role Name")]
        public string Role_name { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
