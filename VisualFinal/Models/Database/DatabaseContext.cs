using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace VisualFinal.Models.Database
{
    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {
        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Bid> Bids { get; set; } = null!;
        public virtual DbSet<Bidder> Bidders { get; set; } = null!;
        public virtual DbSet<Dog> Dogs { get; set; } = null!;
        public virtual DbSet<DogStatistic> DogStatistics { get; set; } = null!;
        public virtual DbSet<Participant> Participants { get; set; } = null!;
        public virtual DbSet<Race> Races { get; set; } = null!;
        public virtual DbSet<Track> Tracks { get; set; } = null!;
        public virtual DbSet<Trainer> Trainers { get; set; } = null!;
        public virtual DbSet<TrainerStatistic> TrainerStatistics { get; set; } = null!;
        public virtual DbSet<Trap> Traps { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite(
                "Data Source=" + Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName
                + "\\Assets\\Database.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bid>(entity =>
            {
                entity.HasKey(e => new { e.TrackName, e.RaceNumber, e.RaceDate, e.TrapNumber, e.BidderId });

                entity.ToTable("Bid");

                entity.Property(e => e.TrackName)
                    .HasColumnType("VARCHAR (20)")
                    .HasColumnName("Track name");

                entity.Property(e => e.RaceNumber)
                    .HasColumnType("UNSIGNED SMALLINT")
                    .HasColumnName("Race number");

                entity.Property(e => e.RaceDate)
                    .HasColumnType("VARCHAR (32)")
                    .HasColumnName("Race date");

                entity.Property(e => e.TrapNumber)
                    .HasColumnType("UNSIGNED SMALLINT")
                    .HasColumnName("Trap number");

                entity.Property(e => e.BidderId).HasColumnName("Bidder ID");

                entity.Property(e => e.Gain).HasColumnType("DOUBLE");

                entity.Property(e => e.Size).HasColumnType("DOUBLE");
            });

            modelBuilder.Entity<Bidder>(entity =>
            {
                entity.ToTable("Bidder");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FullName)
                    .HasColumnType("VARCHAR (64)")
                    .HasColumnName("Full name")
                    .HasDefaultValueSql("\"Insert name here\"");
            });

            modelBuilder.Entity<Dog>(entity =>
            {
                entity.ToTable("Dog");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Dam).HasColumnType("VARCHAR (32)");

                entity.Property(e => e.IsFavorite)
                    .HasColumnType("BOOLEAN")
                    .HasColumnName("Is favorite")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Nickname).HasColumnType("VARCHAR (32)");

                entity.Property(e => e.Sex).HasColumnType("CHAR");

                entity.Property(e => e.Sire).HasColumnType("VARCHAR (32)");
            });

            modelBuilder.Entity<DogStatistic>(entity =>
            {
                entity.HasKey(e => new { e.DogId, e.TrackName });

                entity.ToTable("Dog statistics");

                entity.Property(e => e.DogId).HasColumnName("Dog ID");

                entity.Property(e => e.TrackName)
                    .HasColumnType("VARCHAR (20)")
                    .HasColumnName("Track name");

                entity.Property(e => e.CurrentLosingStreak)
                    .HasColumnType("UNSIGNED SMALLINT")
                    .HasColumnName("Current losing streak");

                entity.Property(e => e.CurrentWinningStreak)
                    .HasColumnType("UNSIGNED SMALLINT")
                    .HasColumnName("Current winning streak");

                entity.Property(e => e.LastRaceDate)
                    .HasColumnType("VARCHAR (32)")
                    .HasColumnName("Last race date")
                    .HasDefaultValueSql("\"1000-01-01\"");

                entity.Property(e => e.LongestLosingStreak)
                    .HasColumnType("UNSIGNED SMALLINT")
                    .HasColumnName("Longest losing streak");

                entity.Property(e => e.LongestWinningStreak)
                    .HasColumnType("UNSIGNED SMALLINT")
                    .HasColumnName("Longest winning streak");

                entity.Property(e => e.RaceCount)
                    .HasColumnType("UNSIGNED SMALLINT")
                    .HasColumnName("Race count");

                entity.Property(e => e.WinCount)
                    .HasColumnType("UNSIGNED SMALLINT")
                    .HasColumnName("Win count");
            });

            modelBuilder.Entity<Participant>(entity =>
            {
                entity.HasKey(e => new { e.TrackName, e.RaceNumber, e.RaceDate, e.TrapNumber });

                entity.ToTable("Participant");

                entity.Property(e => e.TrackName)
                    .HasColumnType("VARCHAR (20)")
                    .HasColumnName("Track name");

                entity.Property(e => e.RaceNumber)
                    .HasColumnType("UNSIGNED SMALLINT")
                    .HasColumnName("Race number");

                entity.Property(e => e.RaceDate)
                    .HasColumnType("VARCHAR (32)")
                    .HasColumnName("Race date");

                entity.Property(e => e.TrapNumber)
                    .HasColumnType("UNSIGNED SMALLINT")
                    .HasColumnName("Trap number");

                entity.Property(e => e.DogId).HasColumnName("Dog ID");

                entity.Property(e => e.Place).HasColumnType("UNSIGNED SMALLINT");

                entity.Property(e => e.Time)
                    .HasColumnType("VARCHAR (32)")
                    .HasDefaultValueSql("\"000:00:00\"");
            });

            modelBuilder.Entity<Race>(entity =>
            {
                entity.HasKey(e => new { e.TrackName, e.Number, e.Date });

                entity.ToTable("Race");

                entity.Property(e => e.TrackName)
                    .HasColumnType("VARCHAR (20)")
                    .HasColumnName("Track name");

                entity.Property(e => e.Number).HasColumnType("UNSIGNED SMALLINT");

                entity.Property(e => e.Date).HasColumnType("VARCHAR (32)");
            });

            modelBuilder.Entity<Track>(entity =>
            {
                entity.HasKey(e => e.Name);

                entity.ToTable("Track");

                entity.Property(e => e.Name).HasColumnType("VARCHAR (20)");

                entity.Property(e => e.Distance).HasColumnType("DOUBLE");
            });

            modelBuilder.Entity<Trainer>(entity =>
            {
                entity.ToTable("Trainer");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DogCount)
                    .HasColumnType("UNSIGNED SMALLINT")
                    .HasColumnName("Dog count");

                entity.Property(e => e.FavoriteCount)
                    .HasColumnType("UNSIGNED SMALLINT")
                    .HasColumnName("Favorite count");

                entity.Property(e => e.FullName)
                    .HasColumnType("VARCHAR (64)")
                    .HasColumnName("Full name")
                    .HasDefaultValueSql("\"Insert name here\"");
            });

            modelBuilder.Entity<TrainerStatistic>(entity =>
            {
                entity.HasKey(e => new { e.TrainerId, e.TrackName });

                entity.ToTable("Trainer statistics");

                entity.Property(e => e.TrainerId).HasColumnName("Trainer ID");

                entity.Property(e => e.TrackName)
                    .HasColumnType("VARCHAR (20)")
                    .HasColumnName("Track name");

                entity.Property(e => e.WinnerCount)
                    .HasColumnType("UNSIGNED SMALLINT")
                    .HasColumnName("Winner count");

                entity.Property(e => e.WinnerFavoriteCount)
                    .HasColumnType("UNSIGNED SMALLINT")
                    .HasColumnName("Winner-favorite count");
            });

            modelBuilder.Entity<Trap>(entity =>
            {
                entity.HasKey(e => new { e.TrackName, e.TrapNumber });

                entity.ToTable("Trap");

                entity.Property(e => e.TrackName)
                    .HasColumnType("VARCHAR (20)")
                    .HasColumnName("Track name");

                entity.Property(e => e.TrapNumber)
                    .HasColumnType("SMALLINT")
                    .HasColumnName("Trap number");

                entity.Property(e => e.RaceCount)
                    .HasColumnType("UNSIGNED INTEGER")
                    .HasColumnName("Race count");

                entity.Property(e => e.WinnerCount)
                    .HasColumnType("UNSIGNED INTEGER")
                    .HasColumnName("Winner count");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
