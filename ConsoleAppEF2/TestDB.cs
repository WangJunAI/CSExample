using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEF2
{
    public class TestDB<T>:DbContext where T:class,new()
    {
        public TestDB(DbConnection conn) :base(conn,true){

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }


        public static TestDB<T> CreateInstance(string connStr) {
            var conn = new SqlConnection(connStr);
            var inst = new TestDB<T>(conn);
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<TestDB<T>>());
 

            return inst;
        }

        public DbSet<T> List { get; set; }

        public void Save(T t)
        {
            this.List.Add(t);
            this.SaveChanges();
        }
    }
}
