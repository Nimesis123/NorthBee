using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace NorthBee.Models
{
    public partial class NorthBeeDb : DbContext
    {
        public NorthBeeDb()
            : base("name=NorthBeeDb")
        {
        }

        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<Guest> Guest { get; set; }
        public virtual DbSet<History> History { get; set; }
        public virtual DbSet<Hotel> Hotel { get; set; }
        public virtual DbSet<Room> Room { get; set; }
        public virtual DbSet<RoomType> RoomType { get; set; }
        public virtual DbSet<Status> Status { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Gender>()
                .HasMany(e => e.Guest)
                .WithRequired(e => e.Gender)
                .HasForeignKey(e => e.GenderId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Guest>()
                .HasMany(e => e.History)
                .WithRequired(e => e.Guest)
                .HasForeignKey(e => e.GuestId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Hotel>()
                .HasMany(e => e.Room)
                .WithRequired(e => e.Hotel)
                .HasForeignKey(e => e.HotelId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Room>()
                .HasMany(e => e.History)
                .WithRequired(e => e.Room)
                .HasForeignKey(e => e.RoomId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RoomType>()
                .HasMany(e => e.Room)
                .WithRequired(e => e.RoomType)
                .HasForeignKey(e => e.RoomTypeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Status>()
                .HasMany(e => e.Guest)
                .WithRequired(e => e.Status)
                .HasForeignKey(e => e.StatusId)
                .WillCascadeOnDelete(false);
        }
    }
}
