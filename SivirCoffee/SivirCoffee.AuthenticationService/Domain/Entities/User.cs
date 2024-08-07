﻿using System.ComponentModel.DataAnnotations;

namespace SivirCoffee.AuthenticationService.Entities
{
    public class User
    {
        [Key]
        public Guid Id {  get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string PasswordHash {  get; set; }
        
        public virtual ICollection<UserRole> UserRoles { get; set; }


    }
}
