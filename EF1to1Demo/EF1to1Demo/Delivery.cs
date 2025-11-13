using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF1to1Demo
{
    internal class Delivery
    {
        [Key]
        public int Id { get; set; }
        public string CompanyName { get; set; }
       
        public string Number { get; set; }
        public Order Order { get; set; }

        public int OrderId { get; set; }
    }
}
