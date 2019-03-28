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

            Genre genre2 = new Genre();
            genre2.GenreId = 2;
            genre2.Name = "Horror";

            context.Genres.Add(genre2);

            Genre genre3 = new Genre();
            genre3.GenreId = 3;
            genre3.Name = "Thriller";

            context.Genres.Add(genre3);

            Genre genre4 = new Genre();
            genre4.GenreId = 4;
            genre4.Name = "Romance";

            context.Genres.Add(genre4);

            Genre genre5 = new Genre();
            genre5.GenreId = 5;
            genre5.Name = "Sci-fi";

            context.Genres.Add(genre5);

            Genre genre6 = new Genre();
            genre6.GenreId = 6;
            genre6.Name = "Fantasy";

            context.Genres.Add(genre6);

            Film film1 = new Film();
            film1.FilmId = 1;
            film1.GenreId = 1;
            film1.Title = "Jaws";
            film1.Description = "about a shark";
            film1.Length = 2.5;
            film1.Name = genre2;
            film1.Director = "Stephen Spielberg";
            film1.Actor = "Robert Shaw";
            film1.ReleaseDate = "01-01-2000";

            context.Films.Add(film1);

            Film film2 = new Film();
            film2.FilmId = 2;
            film2.GenreId = 2;
            film2.Title = "A Funny Film";
            film2.Description = "This is a funny film";
            film2.Length = 2.0;
            film2.Name = genre1;
            film2.Director = "A Bloke";
            film2.Actor = "A different Bloke";
            film2.ReleaseDate = "01-01-2010";

            context.Films.Add(film2);

            Film film3 = new Film();
            film3.FilmId = 3;
            film3.GenreId = 3;
            film3.Title = "Die Hard";
            film3.Description = "survival";
            film3.Length = 2.3;
            film3.Name = genre6;
            film3.Director = "Adrian Gogoa";
            film3.Actor = "Fabian Bravo";
            film3.ReleaseDate = "01-01-2018";

            context.Films.Add(film3);

            Film film4 = new Film();
            film4.FilmId = 4;
            film4.GenreId = 4;
            film4.Title = "Avengers EndGame";
            film4.Description = "superheroes";
            film4.Length = 2.1;
            film4.Name = genre2;
            film4.Director = "Balder Baol";
            film4.Actor = "Chris Hemswortg";
            film4.ReleaseDate = "09-01-2018";

            context.Films.Add(film4);


            Film film5 = new Film();
            film5.FilmId = 5;
            film5.GenreId = 5;
            film5.Title = "Assasins Creed";
            film5.Description = "Action packed assasins";
            film5.Length = 6.5;
            film5.Name = genre3;
            film5.Director = "Steve Smith";
            film5.Actor = "Ezio Alditore";
            film5.ReleaseDate = "05-08-2015";

            context.Films.Add(film5);


            Film film6 = new Film();
            film6.FilmId = 4;
            film6.GenreId = 6;
            film6.Title = "Wake Call";
            film6.Description = "Thriller movie";
            film6.Length = 2.1;
            film6.Name = genre4;
            film6.Director = "Rachel Rods";
            film6.Actor = "Wairose Ball";
            film6.ReleaseDate = "01-06-2015";

            context.Films.Add(film6);


            Film film7 = new Film();
            film7.FilmId = 4;
            film7.GenreId = 1;
            film7.Title = "Backlash";
            film7.Description = "lashing ";
            film7.Length = 1.1;
            film7.Name = genre5;
            film7.Director = "Yale Bigod";
            film7.Actor = "Seb Bravo";
            film7.ReleaseDate = "01-01-2018";

            context.Films.Add(film7);

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