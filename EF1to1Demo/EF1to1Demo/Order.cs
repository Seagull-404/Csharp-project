using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF1to1Demo
{
    internal class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        // 导航属性
        public Delivery Delivery { get; set; }
    }
}
