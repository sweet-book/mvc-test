using System;
using System.Data.Entity;

namespace mvc.Models
{
    public class regist
    {
        public int num { get; set; }
        public string combine_code { get; set; }
        public string company_code { get; set; }
        public string booktitle { get; set; }
        public int productcode { get; set; }
        public int goodid { get; set; }
        public int ea { get; set; }
        public string filename { get; set; }
        public DateTime date { get; set; }
        public string result { get; set; }
        public string userid { get; set; }
        public string name { get; set; }
        public double money { get; set; }
        public double besongmoney { get; set; }
    }

    public class registDBContext : DbContext
    {
        public DbSet<regist> Movies { get; set; }
    }
}