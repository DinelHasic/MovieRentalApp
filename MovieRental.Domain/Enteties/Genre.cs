using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRental.Domain.Enteties
{
    public class Genre : BaseEntity
    {
        public string Title { get; set; }

        public ICollection<Movie> Movies { get; set; }

        public Genre(int id,string title)
        {
            Id = id;
            Title = title;
        }
    }
}
