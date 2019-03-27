using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FilmReview.Models
{
    public class Director
    {
        public virtual int DirectorId { get; set; }
        public virtual string DirectorName { get; set; }
        public virtual int Age { get; set; }
    }
}