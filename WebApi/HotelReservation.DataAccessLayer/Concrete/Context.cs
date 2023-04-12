using HotelReservation.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservation.DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(("Server=SP14MERTS;Database=HotelReservation;Trusted_Connection=True;MultipleActiveResultSets=true"));
        }

        DbSet<Room> Rooms { get; set; }
        DbSet<Service> Services{ get; set; }
        DbSet<Staff> Staffs { get; set; }
        DbSet<Subscribe> Subscribe { get; set; }
        DbSet<Testimonial> Testimonials { get; set; }
    }
}
