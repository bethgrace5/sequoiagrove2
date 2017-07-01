using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using SequoiaGrove2.Data;

namespace SequoiaGrove2.Data.Migrations
{
    [DbContext(typeof(SequoiaGrove2Context))]
    [Migration("20170701234824_EntitiesWithoutRelationships")]
    partial class EntitiesWithoutRelationships
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SequoiaGrove2.Domain.Availability", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<int>("WeekdayId");

                    b.Property<DateTime>("EndTime");

                    b.Property<DateTime>("StartTime");

                    b.HasKey("UserId", "WeekdayId");

                    b.ToTable("Availabilities");
                });

            modelBuilder.Entity("SequoiaGrove2.Domain.Battle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("EndDate");

                    b.Property<string>("Name");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("Id");

                    b.ToTable("Battles");
                });

            modelBuilder.Entity("SequoiaGrove2.Domain.Business", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BillingAddressId");

                    b.Property<string>("Fax");

                    b.Property<int>("HeadquarterAddressId");

                    b.Property<string>("Name");

                    b.Property<string>("PrimaryPhone");

                    b.Property<string>("SecondaryPhone");

                    b.Property<DateTime>("SignUpDate");

                    b.Property<DateTime>("SubscriptionEndDate");

                    b.Property<int>("TimeZoneId");

                    b.HasKey("Id");

                    b.ToTable("Businesses");
                });

            modelBuilder.Entity("SequoiaGrove2.Domain.LeaveOfAbsence", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("EndDateTime");

                    b.Property<bool>("IsApproved");

                    b.Property<int>("RequestedBy");

                    b.Property<int>("RespondedBy");

                    b.Property<DateTime>("StartDateTime");

                    b.HasKey("Id");

                    b.ToTable("LeaveOfAbsences");
                });

            modelBuilder.Entity("SequoiaGrove2.Domain.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AddressId");

                    b.Property<int>("BusinessId");

                    b.Property<string>("Fax");

                    b.Property<string>("Name");

                    b.Property<string>("PrimaryPhone");

                    b.Property<string>("SecondaryPhone");

                    b.Property<int>("TimeZoneId");

                    b.HasKey("Id");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("SequoiaGrove2.Domain.Notification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("SequoiaGrove2.Domain.NotificationMedia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("NotificationMediae");
                });

            modelBuilder.Entity("SequoiaGrove2.Domain.Permission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Permissions");
                });

            modelBuilder.Entity("SequoiaGrove2.Domain.Quote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("SamuraiId");

                    b.Property<string>("Text");

                    b.HasKey("Id");

                    b.HasIndex("SamuraiId");

                    b.ToTable("Quotes");
                });

            modelBuilder.Entity("SequoiaGrove2.Domain.ReceivablesSchedule", b =>
                {
                    b.Property<string>("Title")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Friday");

                    b.Property<bool>("Monday");

                    b.Property<bool>("Saturday");

                    b.Property<bool>("Sunday");

                    b.Property<bool>("Thursday");

                    b.Property<bool>("Tuesday");

                    b.Property<bool>("Wednesday");

                    b.HasKey("Title");

                    b.ToTable("ReceivablesSchedules");
                });

            modelBuilder.Entity("SequoiaGrove2.Domain.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("UserLevels");
                });

            modelBuilder.Entity("SequoiaGrove2.Domain.Samurai", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Samurais");
                });

            modelBuilder.Entity("SequoiaGrove2.Domain.SamuraiBattle", b =>
                {
                    b.Property<int>("BattleId");

                    b.Property<int>("SamuraiId");

                    b.HasKey("BattleId", "SamuraiId");

                    b.HasIndex("SamuraiId");

                    b.ToTable("SamuraiBattle");
                });

            modelBuilder.Entity("SequoiaGrove2.Domain.Schedule", b =>
                {
                    b.Property<int>("LocationId");

                    b.Property<DateTime>("StartDate");

                    b.Property<DateTime>("DatePublished");

                    b.Property<int>("PublishedBy");

                    b.HasKey("LocationId", "StartDate");

                    b.ToTable("Schedules");
                });

            modelBuilder.Entity("SequoiaGrove2.Domain.ScheduleSettings", b =>
                {
                    b.Property<int>("BusinessId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("StartWeekdayId");

                    b.HasKey("BusinessId");

                    b.HasIndex("StartWeekdayId");

                    b.ToTable("ScheduleSettings");
                });

            modelBuilder.Entity("SequoiaGrove2.Domain.SecretIdentity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("SamuraiId");

                    b.HasKey("Id");

                    b.HasIndex("SamuraiId")
                        .IsUnique();

                    b.ToTable("SecretIdentity");
                });

            modelBuilder.Entity("SequoiaGrove2.Domain.Shift", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("EffectiveDate");

                    b.Property<DateTime>("FridayEnd");

                    b.Property<DateTime>("FridayStart");

                    b.Property<DateTime>("IneffectiveDate");

                    b.Property<int>("LocationId");

                    b.Property<DateTime>("MondayEnd");

                    b.Property<DateTime>("MondayStart");

                    b.Property<string>("Name");

                    b.Property<int>("PositionId");

                    b.Property<DateTime>("SaturdayEnd");

                    b.Property<DateTime>("SaturdayStart");

                    b.Property<DateTime>("SundayEnd");

                    b.Property<DateTime>("SundayStart");

                    b.Property<DateTime>("ThursdayEnd");

                    b.Property<DateTime>("ThursdayStart");

                    b.Property<DateTime>("TuesdayEnd");

                    b.Property<DateTime>("TuesdayStart");

                    b.Property<int>("ViewIndex");

                    b.Property<DateTime>("WednesdayEnd");

                    b.Property<DateTime>("WednesdayStart");

                    b.HasKey("Id");

                    b.ToTable("Shifts");
                });

            modelBuilder.Entity("SequoiaGrove2.Domain.TimeZone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("TimeZones");
                });

            modelBuilder.Entity("SequoiaGrove2.Domain.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<int>("AddressId");

                    b.Property<DateTime>("Birthdate");

                    b.Property<int>("BusinessLedgerId");

                    b.Property<string>("Email");

                    b.Property<string>("Firstname");

                    b.Property<string>("Lastname");

                    b.Property<int>("MaxHoursPerWeek");

                    b.Property<int>("MinHoursPerWeek");

                    b.Property<string>("Notes");

                    b.Property<string>("PrimaryPhone");

                    b.Property<int>("RoleId");

                    b.Property<string>("SecondaryPhone");

                    b.Property<string>("Suffix");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SequoiaGrove2.Domain.UserLocationHistory", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateEmployed");

                    b.Property<DateTime>("DateUnemployed");

                    b.Property<int>("LocationId");

                    b.HasKey("UserId");

                    b.ToTable("UserLocationHistories");
                });

            modelBuilder.Entity("SequoiaGrove2.Domain.UserPermission", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("PermissionId");

                    b.HasKey("UserId");

                    b.ToTable("UserPermissions");
                });

            modelBuilder.Entity("SequoiaGrove2.Domain.UserPosition", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateAcquired");

                    b.Property<DateTime>("DateRemoved");

                    b.Property<bool>("IsPrimary");

                    b.Property<bool>("IsTraining");

                    b.Property<int>("PositionId");

                    b.HasKey("UserId");

                    b.ToTable("UserHasPositions");
                });

            modelBuilder.Entity("SequoiaGrove2.Domain.UserScheduledForShift", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<int>("ShiftId");

                    b.Property<DateTime>("Date");

                    b.HasKey("UserId", "ShiftId", "Date");

                    b.ToTable("ScheduledFor");
                });

            modelBuilder.Entity("SequoiaGrove2.Domain.Weekday", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Weekdays");
                });

            modelBuilder.Entity("SequoiaGrove2.Domain.Quote", b =>
                {
                    b.HasOne("SequoiaGrove2.Domain.Samurai", "Samurai")
                        .WithMany("Quotes")
                        .HasForeignKey("SamuraiId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SequoiaGrove2.Domain.SamuraiBattle", b =>
                {
                    b.HasOne("SequoiaGrove2.Domain.Battle", "Battle")
                        .WithMany("SamuraiBattles")
                        .HasForeignKey("BattleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SequoiaGrove2.Domain.Samurai", "Samurai")
                        .WithMany("SamuraiBattles")
                        .HasForeignKey("SamuraiId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SequoiaGrove2.Domain.ScheduleSettings", b =>
                {
                    b.HasOne("SequoiaGrove2.Domain.Weekday", "StartWeekday")
                        .WithMany()
                        .HasForeignKey("StartWeekdayId");
                });

            modelBuilder.Entity("SequoiaGrove2.Domain.SecretIdentity", b =>
                {
                    b.HasOne("SequoiaGrove2.Domain.Samurai", "Samurai")
                        .WithOne("SecretIdentity")
                        .HasForeignKey("SequoiaGrove2.Domain.SecretIdentity", "SamuraiId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
