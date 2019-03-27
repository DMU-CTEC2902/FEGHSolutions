using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FilmReview.Models
{
    public class Genre
    {
        [DisplayName("Genre ID")]
        public virtual int GenreId { get; set; }
        [DisplayName("Genre")]
        public virtual string Name { get; set; }
    }
}