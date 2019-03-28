using System;

namespace FilmReviewTestProject
{
    public class clsGenre
    {
        //priavet data memeber for the GenreName property
        private string mGenreName;

        public string GenreName
        {
            get
            {
                //return the private data
                return mGenreName;
            }
            set
            {
                //set the private data 
                mGenreName = value;
            }
        }

        public bool Valid(string GenreName, string Age)
        {
            // boolean variable
            Boolean Ok = true;

            if (GenreName.Length == 2)
            {
                Ok = false;
            }
            if (GenreName.Length < 3)
            {
                Ok = false;
            }
            if (GenreName.Length > 60)
            {
                Ok = false;
            }

            return Ok;



        }

    }
}