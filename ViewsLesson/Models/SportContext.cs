namespace ViewsLesson.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class SportContext : DbContext
    {
        public SportContext()
            : base("name=SportContext")
        {
        }

        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }
    }
}