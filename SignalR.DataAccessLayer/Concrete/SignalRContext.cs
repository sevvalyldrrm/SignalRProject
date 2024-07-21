using Microsoft.EntityFrameworkCore;
using SignalR.EntityLayer.Entities;
using SignalRApi.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.DataAccessLayer.Concrete
{
	public class SignalRContext : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Data Source=DESKTOP-0LP7T25\\SQL2022;Initial Catalog=SingalRProject;Persist Security Info=True;User ID=sa;Password=123;Trusted_Connection=True; TrustServerCertificate=Yes");
		}

		public DbSet<About> Abouts { get; set; }
		public DbSet<Booking> Bookings { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Contact> Contacts { get; set; }
		public DbSet<Discount> Discounts { get; set; }
		public DbSet<Feature> Features { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<SocialMedia> SocialMedias { get; set; }
		public DbSet<Testimonial> Testimonials { get; set; }
	}
}
