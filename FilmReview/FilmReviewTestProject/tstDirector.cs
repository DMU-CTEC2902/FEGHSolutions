using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FilmReviewTestProject;

namespace DirectorReviewTestProject
{
    /// <summary>
    /// Summary description for Director
    /// </summary>
    [TestClass]
    public class Director
    {
        public Director()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsDirector AnDirector = new clsDirector();
            //test to see that it exists
            Assert.IsNotNull(AnDirector);
        }

        [TestMethod]
        public void DirectorNameProperty()
        {
            //create an instance of the class we want to create 
            clsDirector AnDirector = new clsDirector();
            //create some test data to assign to the property
            string TestData = "Bob";
            //assign the data to the proerty
            AnDirector.DirectorName = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnDirector.DirectorName, TestData);
        }

        [TestMethod]
        public void AgeProperty()
        {
            //create an instance of the class we want to create 
            clsDirector AnDirector = new clsDirector();
            //create some test data to assign to the property
            string TestData = "34";
            //assign the data to the proerty
            AnDirector.Age = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnDirector.Age, TestData);
        }


        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create 
            clsDirector ADirector = new clsDirector();
            //boolean variable to store the result of the validation
            Boolean Ok = false;
            //create some data to use with the method
            string DirectorName = "Bob";
            string Age = "23";
            //invoke the method
            Ok = ADirector.Valid(DirectorName, Age);
            //test tto see that the reuslt is correct
            Assert.IsFalse(Ok);
        }
    }

}