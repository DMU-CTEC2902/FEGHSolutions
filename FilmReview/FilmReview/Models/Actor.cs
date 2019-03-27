using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FilmReview.Models
{
    public class Actor
    {
        public virtual int ActorId { get; set; }
        public virtual string ActorName { get; set; }
        public virtual int Age { get; set; }
        public virtual string Gender { get; set; }
    }
}