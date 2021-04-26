using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sapphire.Chain.Domain.Catalog;
using System;

namespace Project_Sapphire_Chain.Domain.Tests
{
    [TestClass]
    public class ItemTests
    {
     [TestMethod]
    public void Can_create_new_item()
        {
    var item = new Item("Name", "Description", "Brand","ImageUrl", 10.00m);
    Assert.AreEqual("Name", item.Name);
    Assert.AreEqual("Description", item.Description);
    Assert.AreEqual("Brand", item.Brand);
    Assert.AreEqual("ImageUrl", item.ImageUrl);
    Assert.AreEqual(10.00m, item.Price);
        }
    
    [TestMethod]
    public void can_create_add_rating()
        {
        var item = new Item("Name", "Description", "Brand","ImageUrl", 10.00m);
        var rating = new Rating(5, "Name", "Review");

        item.AddRating(rating);
        Assert.AreEqual(rating, item.Ratings[0]);
        }

    }
}
