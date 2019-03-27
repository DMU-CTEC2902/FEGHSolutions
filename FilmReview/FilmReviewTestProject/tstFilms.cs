using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace FilmReviewTestProject
{
    /// <summary>
    /// Summary description for Film
    /// </summary>
    [TestClass]
    public class Film
    {
        public Film()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsFilm AnFilm = new clsFilm();
            //test to see that it exists
            Assert.IsNotNull(AnFilm);
        }

        [TestMethod]
        public void FilmNameProperty()
        {
            //create an instance of the class we want to create 
            clsFilm AnFilm = new clsFilm();
            //create some test data to assign to the property
            string TestData = "Jaws";
            //assign the data to the proerty
            AnFilm.FilmName = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnFilm.FilmName, TestData);
        }


        [TestMethod]
        public void YearReleasedProperty()
        {
            //create an instance of the class we want to create 
            clsFilm AnFilm = new clsFilm();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the proerty
            AnFilm.YearReleased = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnFilm.YearReleased, TestData);
        }

        [TestMethod]
        public void FilmDescriptionProperty()
        {
            //create an instance of the class we want to create 
            clsFilm AnFilm = new clsFilm();
            //create some test data to assign to the property
            string TestData = "Jaws";
            //assign the data to the proerty
            AnFilm.FilmDescription = TestData;
            //test to see that the two values are the same 
            Assert.AreEqual(AnFilm.FilmDescription, TestData);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            //create an instance of the class we want to create 
            clsFilm AFilm = new clsFilm();
            //boolean variable to store the result of the validation
            Boolean Ok = false;
            //create some data to use with the method
            string FilmName = "Jaws";
            string FilmDescription = "About something interesting";
            DateTime YearReleased = DateTime.Now.Date;
            //invoke the method
            Ok = AFilm.Valid(FilmName, FilmDescription, YearReleased);
            //test tto see that the reuslt is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void FilmNameMinusOneMinBoundary()
        {
            //create instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string FilmName = "WO";
            string FilmDescription = "About something interesting";
            DateTime YearReleased = DateTime.Now.Date;
            //invoke the method
            Ok = AFilm.Valid(FilmName, FilmDescription, YearReleased);
            //test tto see that the reuslt is correct
            Assert.IsFalse(Ok);
        }

        [TestMethod]
        public void FilmNameMinBoundary()
        {
            //create instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string FilmName = "Ijo";
            string FilmDescription = "About something interesting";
            DateTime YearReleased = DateTime.Now.Date;
            //invoke the method
            Ok = AFilm.Valid(FilmName, FilmDescription, YearReleased);
            //test tto see that the reuslt is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void FilmNameMinPlusOneBoundary()
        {
            //create instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string FilmName = "Riot";
            string FilmDescription = "About something interesting";
            DateTime YearReleased = DateTime.Now.Date;
            //invoke the method
            Ok = AFilm.Valid(FilmName, FilmDescription, YearReleased);
            //test tto see that the reuslt is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void FilmNameMaxMinusOneBoundary()
        {
            //create instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string FilmName = "";
            FilmName = FilmName.PadRight(59, 'a');
            string FilmDescription = "About something interesting";
            DateTime YearReleased = DateTime.Now.Date;
            //invoke the method
            Ok = AFilm.Valid(FilmName, FilmDescription, YearReleased);
            //test tto see that the reuslt is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void FilmNameMaxBoundary()
        {
            //create instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string FilmName = "";
            FilmName = FilmName.PadRight(60, 'a');
            string FilmDescription = "About something interesting";
            DateTime YearReleased = DateTime.Now.Date;
            //invoke the method
            Ok = AFilm.Valid(FilmName, FilmDescription, YearReleased);
            //test tto see that the reuslt is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void FilmNameMaxPlusOneBoundary()
        {
            //create instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string FilmName = "";
            FilmName = FilmName.PadRight(61, 'a');
            string FilmDescription = "About something interesting";
            DateTime YearReleased = DateTime.Now.Date;
            //invoke the method
            Ok = AFilm.Valid(FilmName, FilmDescription, YearReleased);
            //test tto see that the reuslt is correct
            Assert.IsFalse(Ok);
        }

        [TestMethod]
        public void FilmNameMidBoundary()
        {
            //create instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string FilmName = "";
            FilmName = FilmName.PadRight(30, 'a');
            string FilmDescription = "About something interesting";
            DateTime YearReleased = DateTime.Now.Date;
            //invoke the method
            Ok = AFilm.Valid(FilmName, FilmDescription, YearReleased);
            //test tto see that the reuslt is correct
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void FilmNameExtremeMaxBoundary()
        {
            //create instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string FilmName = "";
            FilmName = FilmName.PadRight(100, 'a');
            string FilmDescription = "About something interesting";
            DateTime YearReleased = DateTime.Now.Date;
            //invoke the method
            Ok = AFilm.Valid(FilmName, FilmDescription, YearReleased);
            //test tto see that the reuslt is correct
            Assert.IsFalse(Ok);
        }

        [TestMethod]
        public void FilmDescriptionMinusOneMinBoundary()
        {
            //create instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string FilmName = "Jaws";
            string FilmDescription = "ef";
            DateTime YearReleased = DateTime.Now.Date;
            //invoke the method
            Ok = AFilm.Valid(FilmName, FilmDescription, YearReleased);
            //test tto see that the reuslt is correct
            Assert.IsFalse(Ok);
        }

        [TestMethod]
        public void FilmDescriptionMinBoundary()
        {
            //create instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string FilmName = "Jaws";
            string FilmDescription = "esf";
            DateTime YearReleased = DateTime.Now.Date;
            //invoke the method
            Ok = AFilm.Valid(FilmName, FilmDescription, YearReleased);
            //test tto see that the reuslt is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void FilmDescriptionMinPlusOneBoundary()
        {
            //create instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string FilmName = "Jaws";
            string FilmDescription = "essf";
            DateTime YearReleased = DateTime.Now.Date;
            //invoke the method
            Ok = AFilm.Valid(FilmName, FilmDescription, YearReleased);
            //test tto see that the reuslt is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void FilmDescriptionMaxMinusOneBoundary()
        {
            //create instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string FilmName = "Jaws";
            string FilmDescription = "";
            FilmDescription = FilmDescription.PadRight(59, 'a');
            DateTime YearReleased = DateTime.Now.Date;
            //invoke the method
            Ok = AFilm.Valid(FilmName, FilmDescription, YearReleased);
            //test tto see that the reuslt is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void FilmDescriptionMaxBoundary()
        {
            //create instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string FilmName = "Jaws";
            string FilmDescription = "";
            FilmDescription = FilmDescription.PadRight(60, 'a');
            DateTime YearReleased = DateTime.Now.Date;
            //invoke the method
            Ok = AFilm.Valid(FilmName, FilmDescription, YearReleased);
            //test tto see that the reuslt is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void FilmDescriptionMaxPlusOneBoundary()
        {
            //create instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string FilmName = "Jaws";
            string FilmDescription = "";
            FilmDescription = FilmDescription.PadRight(61, 'a');
            DateTime YearReleased = DateTime.Now.Date;
            //invoke the method
            Ok = AFilm.Valid(FilmName, FilmDescription, YearReleased);
            //test tto see that the reuslt is correct
            Assert.IsFalse(Ok);
        }

        [TestMethod]
        public void FilmDescriptionMidBoundary()
        {
            //create instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string FilmName = "Jaws";
            string FilmDescription = "";
            FilmDescription = FilmDescription.PadRight(30, 'a');
            DateTime YearReleased = DateTime.Now.Date;
            //invoke the method
            Ok = AFilm.Valid(FilmName, FilmDescription, YearReleased);
            //test tto see that the reuslt is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void FilmDescriptionExtremeMaxBoundary()
        {
            //create instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string FilmName = "Jaws";
            string FilmDescription = "";
            FilmDescription = FilmDescription.PadRight(100, 'a');
            DateTime YearReleased = DateTime.Now.Date;
            //invoke the method
            Ok = AFilm.Valid(FilmName, FilmDescription, YearReleased);
            //test tto see that the reuslt is correct
            Assert.IsFalse(Ok);
        }

        [TestMethod]
        public void YearReleasedExtremeMinBoundary()
        {
            //create instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string FilmName = "Jaws";
            string FilmDescription = "";
            DateTime YearReleased = DateTime.Now.AddYears(-100);
            //invoke the method
            Ok = AFilm.Valid(FilmName, FilmDescription, YearReleased);
            //test tto see that the reuslt is correct
            Assert.IsFalse(Ok);
        }

        [TestMethod]
        public void YearReleasedMinMinusOneBoundary()
        {
            //create instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string FilmName = "Jaws";
            string FilmDescription = "";
            DateTime YearReleased = DateTime.Now.AddYears(-57);
            //invoke the method
            Ok = AFilm.Valid(FilmName, FilmDescription, YearReleased);
            //test tto see that the reuslt is correct
            Assert.IsFalse(Ok);
        }

        [TestMethod]
        public void YearReleasedMinBoundary()
        {
            //create instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string FilmName = "Jaws";
            string FilmDescription = "John Cena";
            DateTime YearReleased = DateTime.Now.AddYears(-56);
            //invoke the method
            Ok = AFilm.Valid(FilmName, FilmDescription, YearReleased);
            //test tto see that the reuslt is correct
            Assert.IsTrue(Ok);
        }
        [TestMethod]
        public void YearReleasedMinPlusOneBoundary()
        {
            //create instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string FilmName = "Jaws";
            string FilmDescription = "John Cena";
            DateTime YearReleased = DateTime.Now.AddYears(-55);
            //invoke the method
            Ok = AFilm.Valid(FilmName, FilmDescription, YearReleased);
            //test tto see that the reuslt is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void YearReleasedMaxBoundary()
        {
            //create instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string FilmName = "Jaws";
            string FilmDescription = "John Cena";
            DateTime YearReleased = DateTime.Now.Date;
            //invoke the method
            Ok = AFilm.Valid(FilmName, FilmDescription, YearReleased);
            //test tto see that the reuslt is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void YearReleasedMaxPlusOneBoundary()
        {
            //create instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string FilmName = "Jaws";
            string FilmDescription = "John Cena";
            DateTime YearReleased = DateTime.Now.AddYears(+1);
            //invoke the method
            Ok = AFilm.Valid(FilmName, FilmDescription, YearReleased);
            //test tto see that the reuslt is correct
            Assert.IsFalse(Ok);
        }

        [TestMethod]
        public void YearReleasedMaxMinusOneBoundary()
        {
            //create instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string FilmName = "Jaws";
            string FilmDescription = "John Cena";
            DateTime YearReleased = DateTime.Now.AddYears(-1);
            //invoke the method
            Ok = AFilm.Valid(FilmName, FilmDescription, YearReleased);
            //test tto see that the reuslt is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void YearReleasedMidBoundary()
        {
            //create instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string FilmName = "Jaws";
            string FilmDescription = "John Cena";
            DateTime YearReleased = DateTime.Now.AddYears(-7);
            //invoke the method
            Ok = AFilm.Valid(FilmName, FilmDescription, YearReleased);
            //test tto see that the reuslt is correct
            Assert.IsTrue(Ok);
        }

        [TestMethod]
        public void YearReleasedExtremeMaxBoundary()
        {
            //create instance of the class we want to create
            clsFilm AFilm = new clsFilm();
            // boolean variable to store the result of the validation 
            Boolean Ok = false;
            //create some test data to assign to the property
            string FilmName = "Jaws";
            string FilmDescription = "";
            DateTime YearReleased = DateTime.Now.AddYears(+100);
            //invoke the method
            Ok = AFilm.Valid(FilmName, FilmDescription, YearReleased);
            //test tto see that the reuslt is correct
            Assert.IsFalse(Ok);
        }
    }
}
