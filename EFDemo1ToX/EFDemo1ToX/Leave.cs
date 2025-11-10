using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo1ToX
{
    internal class Leave
    {
        public long Id { get; set; }
        public User Requester { get; set; }
        public User Approver { get; set; }
        public string Remarks { get; set; }
    }
}
