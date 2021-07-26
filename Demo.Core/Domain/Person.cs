using Demo.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Core.Domain
{
    public class Person : Entity
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public bool Status { get; set; }
    }
}
