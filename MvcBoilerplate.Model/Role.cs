using MvcBoilerplate.Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcBoilerplate.Model
{
   public class Role:Entity<int>
    {
        public string Rolename { get; set; }
    }
}
