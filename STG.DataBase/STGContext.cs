using System;
using Microsoft.EntityFrameworkCore;

namespace STG.Database
{
    public class STGContext : DbContext
    {
        public STGContext(DbContextOptions<STGContext> options) : base(options) { }
    }
}