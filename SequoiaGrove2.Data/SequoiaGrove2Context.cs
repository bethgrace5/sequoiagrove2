using Microsoft.EntityFrameworkCore;
using SequoiaGrove2.Domain;

namespace SequoiaGrove2.Data
{
    public class SequoiaGrove2Context : DbContext
    {
        public DbSet<Samurai> Samurais { get; set; }
        public DbSet<Battle> Battles { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<Availability> Availabilities { get; set; }
        public DbSet<Weekday> Weekdays { get; set; }
        public DbSet<Business> Businesses { get; set; }
        public DbSet<LeaveOfAbsence> LeaveOfAbsences { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<NotificationMedia> NotificationMediae { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<ReceivablesSchedule> ReceivablesSchedules { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<ScheduleSettings> ScheduleSettings { get; set; }
        public DbSet<Shift> Shifts { get; set; }
        public DbSet<TimeZone> TimeZones { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserPosition> UserHasPositions { get; set; }
        public DbSet<Role> UserLevels { get; set; }
        public DbSet<UserLocationHistory> UserLocationHistories { get; set; }
        public DbSet<UserPermission> UserPermissions { get; set; }
        public DbSet<UserScheduledForShift> ScheduledFor { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SamuraiBattle>()
                .HasKey(s => new {s.BattleId, s.SamuraiId});
            //modelBuilder.Entity<Samurai>().Property(s => s.SecretIdentity).IsRequired();
            modelBuilder.Entity<Availability>().HasKey(t => new { t.UserId, t.WeekdayId });
            modelBuilder.Entity<ScheduleSettings>().HasKey(t => new { t.BusinessId});
            modelBuilder.Entity<ReceivablesSchedule>().HasKey(t => t.Title);
            modelBuilder.Entity<UserLocationHistory>().HasKey(t => t.UserId);
            modelBuilder.Entity<UserPermission>().HasKey(t => t.UserId);
            modelBuilder.Entity<UserPosition>().HasKey(t => t.UserId);
            modelBuilder.Entity<Schedule>().HasKey(t => new { t.LocationId, t.StartDate });
            modelBuilder.Entity<UserScheduledForShift>().HasKey(t => new { t.UserId, t.ShiftId, t.Date });

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server = (localdb)\\MSSQLLocalDB; Database = sequoiagrove2-development; Integrated Security = True; Trusted_Connection = True;");
            //base.OnConfiguring(optionsBuilder);
        }
    }
}