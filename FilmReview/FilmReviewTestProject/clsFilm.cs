using System;

namespace FilmReviewTestProject
{
    public class clsFilm
    {
        //priavet data memeber for the FilmDescription property
        private string mFilmDescription;

        //priavet data memeber for the FilmName property
        private string mFilmName;

        //priavet data memeber for the YearReleased property
        private DateTime mYearReleased;

        public string FilmDescription
        {
            get
            {
                //return the private data
                return mFilmDescription;
            }
            set
            {
                //set the private data 
                mFilmDescription = value;
            }
        }
        public string FilmName

        {
            get
            {
                //return the private data
                return mFilmName;
            }
            set
            {
                //set the private data 
                mFilmName = value;
            }
        }
        public DateTime YearReleased
        {
            get
            {
                //return the private data
                return mYearReleased;
            }
            set
            {
                //set the private data 
                mYearReleased = value;
            }
        }

        public bool Valid(string FilmName, string FilmDescription, DateTime YearReleased)
        {
            // boolean variable
            Boolean Ok = true;
            DateTime DateTemp;
            if (FilmName.Length == 2)
            {
                Ok = false;
            }
            if (FilmName.Length < 3)
            {
                Ok = false;
            }
            if (FilmName.Length > 60)
            {
                Ok = false;
            }

            if (FilmDescription.Length == 2)
            {
                Ok = false;
            }
            if (FilmDescription.Length < 3)
            {
                Ok = false;
            }
            if (FilmDescription.Length > 60)
            {
                Ok = false;
            }

            try
            {
                DateTemp = Convert.ToDateTime(YearReleased);
                if (DateTemp > DateTime.Now.Date)
                {
                    Ok = false;
                }
                if (DateTemp < DateTime.Now.Date.AddYears(-57))
                {
                    Ok = false;
                }

            }
            catch
            {
                Ok = false;
            }
            return Ok;



        }
    }
}