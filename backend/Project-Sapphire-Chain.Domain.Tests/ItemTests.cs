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
    var item = new Item("Name", "Description", "Brand", 10.00m);
    Assert.AreEqual("Name", item.Name);
    Assert.AreEqual("Description", item.Description);
    Assert.AreEqual("Brand", item.Brand);
    Assert.AreEqual(10.00m, item.Price);
        }
    
    [TestMethod]
    public void can_create_add_rating()
        {
        var item1 = new Item("Name", "Description", "Brand", 10.00m);
        var rating1 = new Rating(5, "Name", "Review");

        item1.AddRating(rating1);
        Assert.AreEqual(rating1, item1.Ratings[0]);
        }


    }
}
