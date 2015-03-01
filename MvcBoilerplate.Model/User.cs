using MvcBoilerplate.Model.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcBoilerplate.Model
{
  public  class User:Entity<int>
    {

        public User()
        {
            IsActive = false;
            RoleId = 1;
            RememberMe = false;
        }
        [Required(ErrorMessage = "{0} alanı gereklidir!")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "{0} alanı gereklidir!")]
        public string Password { get; set; }

        [ForeignKey("RoleId")]
        public virtual Role Role { get; set; }
        public int RoleId { get; set; }

        [Required(ErrorMessage = "{0} alanı gereklidir!")]

        [Display(Name = "E-Posta")]

        public string Email { get; set; }


        [Required(ErrorMessage = "{0} alanı gereklidir!")]


        public string NameSurname { get; set; }

        [Required(ErrorMessage = "{0} alanı gereklidir!")]

        public string City { get; set; }

        public bool IsActive { get; set; }
        public bool RememberMe { get; set; }
    
      
    }
}
