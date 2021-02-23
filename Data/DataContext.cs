using Microsoft.EntityFrameworkCore;
using RolePlayingGame.Models;

namespace RolePlayingGame.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        { }

        public DbSet<Character> Characters { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Weapon> Weapons { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<CharacterSkill> CharacterSkills { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<CharacterSkill>()
                .HasKey(cs => new {cs.CharacterId, cs.SkillId});

            modelBuilder.Entity<User>()
                .Property(user => user.Role).HasDefaultValue("Player");
        }
    }
}