using Microsoft.EntityFrameworkCore;
using Mod5_CRUD.Models;

namespace Mod5_CRUD.Data {
	public class ApplicationDbContext : DbContext {
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options) {
		}

		public DbSet<AlugueresModel> Alugueres { get; set; }
	}
}