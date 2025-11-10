using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo1ToX
{
     class Comment
    {
        public long Id { get; set; }
        public string Message { get; set; }

        public Article TheArticle { get; set; }

        
    }
}
