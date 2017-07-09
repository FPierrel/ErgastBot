using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ErgastBot.Data
{
    public partial class Context : DbContext
    {
        public virtual DbSet<Circuits> Circuits { get; set; }
        public virtual DbSet<Constructorresults> Constructorresults { get; set; }
        public virtual DbSet<Constructors> Constructors { get; set; }
        public virtual DbSet<Constructorstandings> Constructorstandings { get; set; }
        public virtual DbSet<Drivers> Drivers { get; set; }
        public virtual DbSet<Driverstandings> Driverstandings { get; set; }
        public virtual DbSet<Laptimes> Laptimes { get; set; }
        public virtual DbSet<Pitstops> Pitstops { get; set; }
        public virtual DbSet<Qualifying> Qualifying { get; set; }
        public virtual DbSet<Races> Races { get; set; }
        public virtual DbSet<Results> Results { get; set; }
        public virtual DbSet<Seasons> Seasons { get; set; }
        public virtual DbSet<Status> Status { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
            optionsBuilder.UseMySql(@"Database=ergast; Data Source=ergast.mysql.database.azure.com; User Id=ergast@ergast; Password=#Lebowski02");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Circuits>(entity =>
            {
                entity.HasKey(e => e.CircuitId)
                    .HasName("PK_circuits");

                entity.ToTable("circuits");

                entity.HasIndex(e => e.Url)
                    .HasName("url")
                    .IsUnique();

                entity.Property(e => e.CircuitId)
                    .HasColumnName("circuitId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Alt)
                    .HasColumnName("alt")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CircuitRef)
                    .IsRequired()
                    .HasColumnName("circuitRef")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Lat).HasColumnName("lat");

                entity.Property(e => e.Lng).HasColumnName("lng");

                entity.Property(e => e.Location)
                    .HasColumnName("location")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnName("url")
                    .HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<Constructorresults>(entity =>
            {
                entity.ToTable("constructorresults");

                entity.Property(e => e.ConstructorResultsId)
                    .HasColumnName("constructorResultsId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ConstructorId)
                    .HasColumnName("constructorId")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Points).HasColumnName("points");

                entity.Property(e => e.RaceId)
                    .HasColumnName("raceId")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<Constructors>(entity =>
            {
                entity.HasKey(e => e.ConstructorId)
                    .HasName("PK_constructors");

                entity.ToTable("constructors");

                entity.HasIndex(e => e.Name)
                    .HasName("name")
                    .IsUnique();

                entity.Property(e => e.ConstructorId)
                    .HasColumnName("constructorId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ConstructorRef)
                    .IsRequired()
                    .HasColumnName("constructorRef")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Nationality)
                    .HasColumnName("nationality")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnName("url")
                    .HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<Constructorstandings>(entity =>
            {
                entity.ToTable("constructorstandings");

                entity.Property(e => e.ConstructorStandingsId)
                    .HasColumnName("constructorStandingsId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ConstructorId)
                    .HasColumnName("constructorId")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Points)
                    .HasColumnName("points")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PositionText)
                    .HasColumnName("positionText")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.RaceId)
                    .HasColumnName("raceId")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Wins)
                    .HasColumnName("wins")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Drivers>(entity =>
            {
                entity.HasKey(e => e.DriverId)
                    .HasName("PK_drivers");

                entity.ToTable("drivers");

                entity.HasIndex(e => e.Url)
                    .HasName("url")
                    .IsUnique();

                entity.Property(e => e.DriverId)
                    .HasColumnName("driverId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasColumnType("varchar(3)");

                entity.Property(e => e.DriverRef)
                    .IsRequired()
                    .HasColumnName("driverRef")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Forename)
                    .IsRequired()
                    .HasColumnName("forename")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Nationality)
                    .HasColumnName("nationality")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Number)
                    .HasColumnName("number")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasColumnName("surname")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnName("url")
                    .HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<Driverstandings>(entity =>
            {
                entity.ToTable("driverstandings");

                entity.Property(e => e.DriverStandingsId)
                    .HasColumnName("driverStandingsId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DriverId)
                    .HasColumnName("driverId")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Points)
                    .HasColumnName("points")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PositionText)
                    .HasColumnName("positionText")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.RaceId)
                    .HasColumnName("raceId")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Wins)
                    .HasColumnName("wins")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Laptimes>(entity =>
            {
                entity.HasKey(e => new { e.RaceId, e.DriverId, e.Lap })
                    .HasName("PK_laptimes");

                entity.ToTable("laptimes");

                entity.HasIndex(e => e.RaceId)
                    .HasName("raceId");

                entity.Property(e => e.RaceId)
                    .HasColumnName("raceId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DriverId)
                    .HasColumnName("driverId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Lap)
                    .HasColumnName("lap")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Milliseconds)
                    .HasColumnName("milliseconds")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<Pitstops>(entity =>
            {
                entity.HasKey(e => new { e.RaceId, e.DriverId, e.Stop })
                    .HasName("PK_pitstops");

                entity.ToTable("pitstops");

                entity.HasIndex(e => e.RaceId)
                    .HasName("raceId");

                entity.Property(e => e.RaceId)
                    .HasColumnName("raceId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DriverId)
                    .HasColumnName("driverId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Stop)
                    .HasColumnName("stop")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Duration)
                    .HasColumnName("duration")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Lap)
                    .HasColumnName("lap")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Milliseconds)
                    .HasColumnName("milliseconds")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("time");
            });

            modelBuilder.Entity<Qualifying>(entity =>
            {
                entity.HasKey(e => e.QualifyId)
                    .HasName("PK_qualifying");

                entity.ToTable("qualifying");

                entity.Property(e => e.QualifyId)
                    .HasColumnName("qualifyId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ConstructorId)
                    .HasColumnName("constructorId")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DriverId)
                    .HasColumnName("driverId")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Number)
                    .HasColumnName("number")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Q1)
                    .HasColumnName("q1")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Q2)
                    .HasColumnName("q2")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Q3)
                    .HasColumnName("q3")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.RaceId)
                    .HasColumnName("raceId")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Races>(entity =>
            {
                entity.HasKey(e => e.RaceId)
                    .HasName("PK_races");

                entity.ToTable("races");

                entity.HasIndex(e => e.Url)
                    .HasName("url")
                    .IsUnique();

                entity.Property(e => e.RaceId)
                    .HasColumnName("raceId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CircuitId)
                    .HasColumnName("circuitId")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Round)
                    .HasColumnName("round")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("time");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnName("url")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Year)
                    .HasColumnName("year")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");
            });

            modelBuilder.Entity<Results>(entity =>
            {
                entity.HasKey(e => e.ResultId)
                    .HasName("PK_results");

                entity.ToTable("results");

                entity.Property(e => e.ResultId)
                    .HasColumnName("resultId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ConstructorId)
                    .HasColumnName("constructorId")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DriverId)
                    .HasColumnName("driverId")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FastestLap)
                    .HasColumnName("fastestLap")
                    .HasColumnType("int(11)");

                entity.Property(e => e.FastestLapSpeed)
                    .HasColumnName("fastestLapSpeed")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.FastestLapTime)
                    .HasColumnName("fastestLapTime")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.Grid)
                    .HasColumnName("grid")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Laps)
                    .HasColumnName("laps")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Milliseconds)
                    .HasColumnName("milliseconds")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Number)
                    .HasColumnName("number")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Points)
                    .HasColumnName("points")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PositionOrder)
                    .HasColumnName("positionOrder")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PositionText)
                    .IsRequired()
                    .HasColumnName("positionText")
                    .HasColumnType("varchar(255)");

                entity.Property(e => e.RaceId)
                    .HasColumnName("raceId")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Rank)
                    .HasColumnName("rank")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.StatusId)
                    .HasColumnName("statusId")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<Seasons>(entity =>
            {
                entity.HasKey(e => e.Year)
                    .HasName("PK_seasons");

                entity.ToTable("seasons");

                entity.HasIndex(e => e.Url)
                    .HasName("url")
                    .IsUnique();

                entity.Property(e => e.Year)
                    .HasColumnName("year")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnName("url")
                    .HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.ToTable("status");

                entity.Property(e => e.StatusId)
                    .HasColumnName("statusId")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Status1)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasColumnType("varchar(255)");
            });
        }
    }
}