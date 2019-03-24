using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace FilmReview.Models
{
    public class ReviewDataInitilizer: DropCreateDatabaseAlways<ReviewContext>
    {

        protected override void Seed(ReviewContext context)
        {
            Film film1 = new Film();
            film1.FilmId = 1;
            film1.Title = "A Funny Film";
            context.Films.Add(film1);

            Review review1 = new Review();
            review1.ReviewId = 1;
            review1.FilmId = 1;
            review1.Title = film1;
            review1.MainReview = "This film was very funny.";
            review1.Score = 5;
            
            context.Reviews.Add(review1);
            


            base.Seed(context);
        }
    }
}