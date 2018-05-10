namespace ConsoleAppEF1
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AUDUSDContext : DbContext
    {
        public AUDUSDContext()
            : base("name=AUDUSD")
        {
        }

        public virtual DbSet<AUDUSD> AUDUSDs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //��������ӣ���������ӳ������
            modelBuilder.Entity<AUDUSD>().HasKey(t => t.ID);
        }
    }
}
