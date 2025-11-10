using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore1
{
    public class Dog
    {
        public Guid Id { get; set; }//主键
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
