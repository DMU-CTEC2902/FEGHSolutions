using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace FilmReview.Models
{
    public class FilmData : DropCreateDatabaseAlways<FilmContext>
    {
        protected override void Seed(FilmContext context)
        {
            Genre genre1 = new Genre();
            genre1.GenreId = 1;
            genre1.Name = "Comedy";

            context.Genres.Add(genre1);

            Film film1 = new Film();
            film1.FilmId = 1;
            film1.GenreId = 1;
            film1.Title = "A Funny Film";
            film1.Description = "This is a funny film";
            film1.Length = 1.5;
            film1.Name = genre1;
            film1.Director = "A Bloke";
            film1.Actor = "A different Bloke";
            film1.ReleaseDate = "01-01-2000";

            context.Films.Add(film1);

            Film film2 = new Film();
            film2.FilmId = 1;
            film2.GenreId = 1;
            film2.Title = "A Funny Film";
            film2.Description = "This is a funny film";
            film2.Length = 1.5;
            film2.Name = genre1;
            film2.Director = "A Bloke";
            film2.Actor = "A different Bloke";
            film2.ReleaseDate = "01-01-2000";

            context.Films.Add(film2);

            Review review1 = new Review();
            review1.ReviewId = 1;
            review1.FilmId = 1;
            review1.Title = film1;
            review1.MainReview = "This film was funny";
            review1.Score = 3.5;

            context.Reviews.Add(review1);

            Actor actor1 = new Actor();
            actor1.ActorId = 1;
            actor1.ActorName = "Chris Hemsworth";
            actor1.Age = 35;
            actor1.Gender = "Male";

            context.Actors.Add(actor1);

            Director director1 = new Director();
            director1.DirectorId = 1;
            director1.DirectorName = "David Seaman";
            director1.Age = 46;

            context.Directors.Add(director1);

            base.Seed(context);
        }
    }
}