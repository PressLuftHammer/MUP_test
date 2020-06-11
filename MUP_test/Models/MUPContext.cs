using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlClient;

namespace MUP_test.Models
{
    public class MUPContext:DbContext
    {
        public DbSet<RequestLog> RequestLogs { get; set; }

        public MUPContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //первичный ключь
            modelBuilder.Entity<RequestLog>().HasKey(k => new { k.RequestId, k.LogTime });
           
            //последовательность для номеров заявок
            modelBuilder.HasSequence<int>("ReqID")
                        .StartsAt(1)
                        .IncrementsBy(1);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=MUPtest;Trusted_Connection=True;");
        }

        public int GetReqID()
        {
            SqlParameter result = new SqlParameter("@result", System.Data.SqlDbType.Int)
            {
                Direction = System.Data.ParameterDirection.Output
            };
            Database.ExecuteSqlCommand("SELECT @result=(NEXT VALUE FOR ReqID)", result);

            return (int)result.Value;
        }
    }
}
