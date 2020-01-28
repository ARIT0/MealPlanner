using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MealPlanner.Models;
using Microsoft.EntityFrameworkCore;
//using System.Data.Entity;



namespace MealPlanner.Data
{
    public class ApplicationDbContext : DbContext
    {
        
        public DbSet<User> UserRegistration { get; set; }
        //inside the db<> is the class associated with that table
        public DbSet<RecipeClass> Recipes{ get; set; }
        public DbSet<InstructionsClass> Instructions { get; set; }
        public DbSet<TagsClass> Tags { get; set; }
        public DbSet<IngredientsClass> Ingredients { get; set; }
        public DbSet<IngQuantClass> IngQuant { get; set; }
        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IngQuantClass>() //TODO Change to IG save and add to a new migration
                .HasKey(c => new { c.RecIdfk, c.IngIdfk });

            modelBuilder.Entity<InstructionsClass>() 
                .HasNoKey();

        }

    }
}
