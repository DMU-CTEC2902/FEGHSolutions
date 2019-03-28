using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FilmReviewTestProject;

namespace ActorReviewTestProject
{
    /// <summary>
    /// Summary description for Actor
    /// </summary>
    [TestClass]
    public class Actor
    {
        public Actor()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsActor AnActor = new clsActor();
            //test to see that it exists
            Assert.IsNotNull(AnActor);
        }

        [TestMethod]
        public void ActorNameProperty()
        {
            //create an instance of the class we want to create 
            clsActor AnActor = new clsActor();
            //create some test data to assign to the property
            string TestData = "Joe";
            //assign the data to the proerty
            AnActor.ActorName = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnActor.ActorName, TestData);
        }

        [TestMethod]
        public void AgeProperty()
        {
            //create an instance of the class we want to create 
            clsActor AnActor = new clsActor();
            //create some test data to assign to the property
            string TestData = "34";
            //assign the data to the proerty
            AnActor.Age = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnActor.Age, TestData);
        }

        [TestMethod]
        public void GenderProperty()
        {
            //create an instance of the class we want to create 
            clsActor AnActor = new clsActor();
            //create some test data to assign to the property
            string TestData = "Male";
            //assign the data to the proerty
            AnActor.Gender = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnActor.Gender, TestData);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create 
            clsActor AActor = new clsActor();
            //boolean variable to store the result of the validation
            Boolean Ok = false;
            //create some data to use with the method
            string ActorName = "Joe";
            string Age = "23";
            string Gender = "Male";
            //invoke the method
            Ok = AActor.Valid(ActorName, Age, Gender);
            //test tto see that the reuslt is correct
            Assert.IsFalse(Ok);
        }
    }

}