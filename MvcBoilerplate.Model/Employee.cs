using MvcBoilerplate.Model.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcBoilerplate.Model
{
    public class Employee : Entity<int>
    {
        [Required(ErrorMessage = "{0} alanı gereklidir!")]
        public string NameSurname { get; set; }
        [Required(ErrorMessage = "{0} alanı gereklidir!")]
        public string Departman { get; set; }

        public DateTime? Age { get; set; }
    }
}
