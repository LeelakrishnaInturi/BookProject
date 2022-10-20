using System;
using System.Collections.Generic;

#nullable disable

namespace BookProject.Entities
{
    public partial class BookDetail
    {
        public Guid BookId { get; set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
    }
}
