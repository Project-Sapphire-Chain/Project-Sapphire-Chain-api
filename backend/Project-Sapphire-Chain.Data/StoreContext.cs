using System;
using Sapphire.Chain.Domain.Catalog;
using Microsoft.EntityFrameworkCore;

namespace Project.Sapphire.Chain.Data

 {
	public class StoreContext : DbContext
	{
	    public StoreContext(DbContextOptions<StoreContext> options)
			: base(options)
		{}

	public DbSet<Item> Items {get;set;}
	}
}
