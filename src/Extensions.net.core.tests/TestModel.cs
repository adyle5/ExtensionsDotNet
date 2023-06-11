// Copyright © 2023 Adrian Gabor
// Refer to license.txt for usage and permission information 

using Microsoft.EntityFrameworkCore;

namespace Extensions.net.core.tests.models
{
    internal class TestModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }

    class TestModelContext : DbContext
    {
        public DbSet<TestModel> TestModels { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
          => options.UseSqlite($"Data Source=:memory:");
    }
}
