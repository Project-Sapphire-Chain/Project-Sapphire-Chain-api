using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sapphire.Chain.Domain.Catalog;
using System;

namespace Project_Sapphire_Chain.Domain.Tests
{
    [TestClass]
    public class RatingTests
    {
       [TestMethod]
    public void Can_Create_new_rating()
        {
            var rating = new Rating(1, "Mike", "Great fit!");

            Assert.AreEqual(1,rating.Star);
            Assert.AreEqual("Mike", rating.UserName);
            Assert.AreEqual("Great fit!", rating.Review);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Create_with_bad_start_throws_error()
        {
            var rating = new Rating(0, "name", "review");
        }

    }
}
