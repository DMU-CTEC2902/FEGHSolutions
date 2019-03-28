using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FilmReviewTestProject;

namespace ReviewsReviewTestProject
{
    /// <summary>
    /// Summary description for Reviews
    /// </summary>
    [TestClass]
    public class Reviews
    {
        public Reviews()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsReviews AnReviews = new clsReviews();
            //test to see that it exists
            Assert.IsNotNull(AnReviews);
        }

        [TestMethod]
        public void TitleProperty()
        {
            //create an instance of the class we want to create 
            clsReviews AnReviews = new clsReviews();
            //create some test data to assign to the property
            string TestData = "Haha";
            //assign the data to the proerty
            AnReviews.Title = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnReviews.Title, TestData);
        }

        [TestMethod]
        public void MainReviewProperty()
        {
            //create an instance of the class we want to create 
            clsReviews AnReviews = new clsReviews();
            //create some test data to assign to the property
            string TestData = "great";
            //assign the data to the proerty
            AnReviews.MainReview = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnReviews.MainReview, TestData);
        }

        [TestMethod]
        public void ScoreProperty()
        {
            //create an instance of the class we want to create 
            clsReviews AnReviews = new clsReviews();
            //create some test data to assign to the property
            string TestData = "3.3";
            //assign the data to the proerty
            AnReviews.Score = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnReviews.Score, TestData);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create 
            clsReviews AReviews = new clsReviews();
            //boolean variable to store the result of the validation
            Boolean Ok = false;
            //create some data to use with the method
            string Title = "haha";
            string MainReview = "great";
            string Score = "3.3";
            //invoke the method
            Ok = AReviews.Valid(Title, MainReview, Score);
            //test tto see that the reuslt is correct
            Assert.IsTrue(Ok);
        }
    }

}