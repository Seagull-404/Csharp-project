using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace EFDemo1ToX
{
     class Article
    {
        public int ArticleId { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }

        public List<Comment> Comments { get; set; } = new List<Comment>();//建议给一个空的list，避免空引用异常

    }
}
