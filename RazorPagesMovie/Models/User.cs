using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesMovie.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Firstname { get; set; }

        [Required]
        public string Lastname { get; set; }

        [Required]
        public string UserId { get; set; }


        public string Role { get; set; }


        public int? PartnerId { get; set; }


        public int? EnterpriseId { get; set; }

        public string Domain { get; set; }

        [Required]
        public DateTime CreationTime { get; set; }


        public DateTime? ModificationTime { get; set; }

    }
}
