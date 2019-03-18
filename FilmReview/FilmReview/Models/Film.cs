using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FilmReview.Models
{
    public class Film
    {
        public virtual int FilmId { get; set; }
        public virtual int GenreId { get; set; }
        public virtual string Title { get; set; }
        public virtual string Description { get; set; }
        public virtual double Length { get; set; }
        public virtual Genre Name { get; set; }
        public virtual string Director { get; set; }
        public virtual string Actor { get; set; }
        public virtual string ReleaseDate { get; set; }
        
    }
}