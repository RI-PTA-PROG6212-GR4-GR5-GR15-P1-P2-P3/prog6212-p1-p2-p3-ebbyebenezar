using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using RaceDayApi.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RaceDayApi.Services;

namespace RaceDayApi.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }
        public DbSet<UserAccount> Users { get; set; }
        public DbSet<Participant> Participants { get; set; }
        public DbSet<Organiser> Organisers { get; set; }
        public DbSet<Registration> Registrations { get; set; }
        public DbSet<Event> Events { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Registration>()
                .HasKey(r => new { r.EventId, r.ParticipantId });

            base.OnModelCreating(modelBuilder);
        }
        

    }
}
