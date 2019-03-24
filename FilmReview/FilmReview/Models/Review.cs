using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FilmReview.Models
{
    public class Review
    {
        public virtual int ReviewId { get; set; }
        public virtual int FilmId { get; set; }
        public virtual Film Title { get; set; }
        public virtual string MainReview { get; set; }
        public virtual int Score { get; set; }

    }
}