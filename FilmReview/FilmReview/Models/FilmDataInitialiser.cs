using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace FilmReview.Models
{
    public class FilmDataInitialiser : DropCreateDatabaseAlways<FilmContext>
    {
        public static string filmTitle = "A Funny Film";
        protected override void Seed(FilmContext context)
        {
            Genre genre1 = new Genre();
            genre1.GenreId = 1;
            genre1.Name = "Comedy";

            context.Genres.Add(genre1);

            Film film1 = new Film();
            film1.FilmId = 1;
            film1.GenreId = 1;
            film1.Title = filmTitle;
            film1.Description = "This is a funny film";
            film1.Length = 1.5;
            film1.Name = genre1;
            film1.Director = "A Bloke";
            film1.Actor = "A different Bloke";
            film1.ReleaseDate = "01-01-2000";

            context.Films.Add(film1);
            base.Seed(context);
        }
    }
}