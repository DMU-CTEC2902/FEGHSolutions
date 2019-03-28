using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FilmReviewTestProject;

namespace GenreReviewTestProject
{
    /// <summary>
    /// Summary description for Genre
    /// </summary>
    [TestClass]
    public class Genre
    {
        public Genre()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsGenre AnGenre = new clsGenre();
            //test to see that it exists
            Assert.IsNotNull(AnGenre);
        }

        [TestMethod]
        public void GenreNameProperty()
        {
            //create an instance of the class we want to create 
            clsGenre AnGenre = new clsGenre();
            //create some test data to assign to the property
            string TestData = "comedy";
            //assign the data to the proerty
            AnGenre.GenreName = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnGenre.GenreName, TestData);
        }

       


        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create 
            clsGenre AGenre = new clsGenre();
            //boolean variable to store the result of the validation
            Boolean Ok = false;
            //create some data to use with the method
            string GenreName = "Bob";
            string Age = "23";
            //invoke the method
            Ok = AGenre.Valid(GenreName, Age);
            //test tto see that the reuslt is correct
            Assert.IsTrue(Ok);
        }
    }

}