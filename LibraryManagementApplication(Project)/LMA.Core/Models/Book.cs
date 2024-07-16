using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMA.Core.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
        public int PublishedYear { get; set; }
        public ICollection<Author> Authors { get; set; }
    }
}
