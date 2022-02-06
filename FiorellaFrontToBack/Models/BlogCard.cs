using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FiorellaFrontToBack.Models
{
    public class BlogCard
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public DateTime Time { get; set; }
        public string Title { get; set; }
        public string Paragraph { get; set; }
    }
}
