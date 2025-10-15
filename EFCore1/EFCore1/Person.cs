using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore1
{
   public class Person
    {
        public long Id { get; set; }//主键
        public string Name { get; set; }//姓名
        public int Age { get; set; }//年龄

        public int Birthday { get; set; }//生日

    }
}
