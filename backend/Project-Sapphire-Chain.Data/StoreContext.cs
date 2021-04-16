using System;
using Sapphire.Chain.Domain.Catalog;
using Microsoft.EntityFrameworkCore;
using Project.Sapphire.Chain.Domain.Orders;

namespace Project.Sapphire.Chain.Data

 {
	public class StoreContext : DbContext
	{
	    public StoreContext(DbContextOptions<StoreContext> options)
			: base(options)
		{}

	public DbSet<Item> Items {get;set;}
	
	public DbSet<Order> Orders{get;set;}
	
	}
}
