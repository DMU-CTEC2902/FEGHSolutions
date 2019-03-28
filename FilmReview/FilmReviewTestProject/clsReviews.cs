using System;

namespace FilmReviewTestProject
{
    public class clsReviews
    {
        //priavet data memeber for the Title property
        private string mTitle;

        //priavet data memeber for the MainReview property
        private string mMainReview;

        //priavet data memeber for the Score property
        private string mScore;

        public string Title
        {
            get
            {
                //return the private data
                return mTitle;
            }
            set
            {
                //set the private data 
                mTitle = value;
            }
        }
        public string MainReview

        {
            get
            {
                //return the private data
                return mMainReview;
            }
            set
            {
                //set the private data 
                mMainReview = value;
            }
        }
        public string Score
        {
            get
            {
                //return the private data
                return mScore;
            }
            set
            {
                //set the private data 
                mScore = value;
            }
        }

        public bool Valid(string Title, string MainReview, string Score)
        {
            // boolean variable
            Boolean Ok = true;

            if (Title.Length == 2)
            {
                Ok = false;
            }
            if (Title.Length < 3)
            {
                Ok = false;
            }
            if (Title.Length > 60)
            {
                Ok = false;
            }

            if (MainReview.Length == 2)
            {
                Ok = false;
            }
            if (MainReview.Length < 3)
            {
                Ok = false;
            }
            if (MainReview.Length > 60)
            {
                Ok = false;
            }

            if (Score.Length == 2)
            {
                Ok = false;
            }
            if (Score.Length < 3)
            {
                Ok = false;
            }
            if (Score.Length > 60)
            {
                Ok = false;
            }


            return Ok;



        }

    }
}