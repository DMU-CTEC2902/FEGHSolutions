using System;

namespace FilmReviewTestProject
{
    public class clsActor
    {
        //priavet data memeber for the ActorName property
        private string mActorName;

        //priavet data memeber for the Age property
        private string mAge;

        //priavet data memeber for the Gender property
        private string mGender;

        public string ActorName
        {
            get
            {
                //return the private data
                return mActorName;
            }
            set
            {
                //set the private data 
                mActorName = value;
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
        public string Gender
        {
            get
            {
                //return the private data
                return mGender;
            }
            set
            {
                //set the private data 
                mGender = value;
            }
        }

        public bool Valid(string ActorName, string Age, string Gender)
        {
            // boolean variable
            Boolean Ok = true;
            
            if (ActorName.Length == 2)
            {
                Ok = false;
            }
            if (ActorName.Length < 3)
            {
                Ok = false;
            }
            if (ActorName.Length > 60)
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

            if (Gender.Length == 2)
            {
                Ok = false;
            }
            if (Gender.Length < 3)
            {
                Ok = false;
            }
            if (Gender.Length > 60)
            {
                Ok = false;
            }
        
        
            return Ok;



        }

    }
}