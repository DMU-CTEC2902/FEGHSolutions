﻿using System;
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
            genre1.Name = "Comsdy";

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

            base.Seed(context);
        }
    }
}