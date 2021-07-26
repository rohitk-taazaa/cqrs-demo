using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Core.Data
{
    public class Entity
    {
        public Guid Id { get; set; }
       [NotMapped]
        public bool IsNew { get; set; }
    }
}
