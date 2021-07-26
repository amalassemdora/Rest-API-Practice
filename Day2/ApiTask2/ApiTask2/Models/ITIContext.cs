using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ApiTask2.Models
{
	public partial class ITIContext : DbContext
	{
		public ITIContext()
			: base("name=ITIContext")
		{
		}

		public virtual DbSet<Department> Departments { get; set; }
		public virtual DbSet<Student> Students { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Student>()
				.Property(e => e.St_Lname)
				.IsFixedLength();

			modelBuilder.Entity<Student>()
				.Property(e => e.CV)
				.IsFixedLength();

			modelBuilder.Entity<Student>()
				.HasMany(e => e.Student1)
				.WithOptional(e => e.Student2)
				.HasForeignKey(e => e.St_super);
		}
	}
}
