using System;

namespace FilmReviewTestProject
{
    public class clsDirector
    {
        //priavet data memeber for the DirectorName property
        private string mDirectorName;

        //priavet data memeber for the Age property
        private string mAge;


        public string DirectorName
        {
            get
            {
                //return the private data
                return mDirectorName;
            }
            set
            {
                //set the private data 
                mDirectorName = value;
            }
        }
        public string Age

        {
            get
            {
                //return the private data
                return mAge;
            }
            set
            {
                //set the private data 
                mAge = value;
            }
        }

        public bool Valid(string DirectorName, string Age)
        {
            // boolean variable
            Boolean Ok = true;

            if (DirectorName.Length == 2)
            {
                Ok = false;
            }
            if (DirectorName.Length < 3)
            {
                Ok = false;
            }
            if (DirectorName.Length > 60)
            {
                Ok = false;
            }

            if (Age.Length == 2)
            {
                Ok = false;
            }
            if (Age.Length < 3)
            {
                Ok = false;
            }
            if (Age.Length > 60)
            {
                Ok = false;
            }

            return Ok;



        }

    }
}