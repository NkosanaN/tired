using System;
using System.Collections.Generic;
using System.Text;

namespace MovieApiV.Model
{
    public class Movie
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Genre { get; set; }

        public DateTime ReleaseDate { get; set; }

        public int Rating { get; set; }

        public int checksum { get; set; }
    }
}
