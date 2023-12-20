using Microsoft.EntityFrameworkCore;

namespace ReactASPCRUD.Models
{
	public class StudentDbContext : DbContext
	{
		public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
		{

		}

		public DbSet<Student> Students { get; set; }


		//Make db connection
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			//db name is lms
			optionsBuilder.UseSqlServer("Data Source=.; initial Catalog=lms ; User Id=sa; password=1234; TrustServerCertificate= True");
		}
	}
}
