using System;
using System.ComponentModel.DataAnnotations;

namespace DotNetSimpleBlog.Models
{
  public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }

        [DataType(DataType.Date)]
        public DateTime Created_At { get; set; }
        public DateTime Updated_At { get; set; }
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}