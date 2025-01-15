using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelTripProject.Models.Entities
{
    public class BlogComment
    {
        public IEnumerable<Blog> value1 { get; set; }
        public IEnumerable<Blog> value2 { get; set; }
        public IEnumerable<Comment> value3 { get; set; }
    }
}