using Microsoft.EntityFrameworkCore;
using MudBlazorCrudST.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MudBlazorCrudST.Context
{
	public class DatabaseContext : DbContext
	{
		public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
		{ 

		}

		public DbSet<Animal> Animals { get; set; }
	}
}
