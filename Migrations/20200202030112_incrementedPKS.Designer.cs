﻿// <auto-generated />
using System;
using MealPlanner.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MealPlanner.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200202030112_incrementedPKS")]
    partial class incrementedPKS
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MealPlanner.Models.IngQuantClass", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IngredientsClassId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("RecipeClassId")
                        .HasColumnType("int");

                    b.Property<int?>("RecipeClassId1")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IngredientsClassId")
                        .IsUnique();

                    b.HasIndex("RecipeClassId");

                    b.HasIndex("RecipeClassId1");

                    b.ToTable("IngQuant");
                });

            modelBuilder.Entity("MealPlanner.Models.IngredientsClass", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("IngName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UM")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("MealPlanner.Models.InstructionsClass", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Instruct")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RecipeClassId")
                        .HasColumnType("int");

                    b.Property<int>("StepOrder")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RecipeClassId");

                    b.ToTable("Instructions");
                });

            modelBuilder.Entity("MealPlanner.Models.RecipeClass", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Calories")
                        .HasColumnType("int");

                    b.Property<string>("RecName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TagsId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TagsId")
                        .IsUnique();

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Recipes");
                });

            modelBuilder.Entity("MealPlanner.Models.TagsClass", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TagName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("MealPlanner.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Confirmpwd")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserRegistration");
                });

            modelBuilder.Entity("MealPlanner.Models.IngQuantClass", b =>
                {
                    b.HasOne("MealPlanner.Models.IngredientsClass", "IngredientsClass")
                        .WithOne("IngQuantClass")
                        .HasForeignKey("MealPlanner.Models.IngQuantClass", "IngredientsClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MealPlanner.Models.RecipeClass", "Recipe")
                        .WithMany()
                        .HasForeignKey("RecipeClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MealPlanner.Models.RecipeClass", "RecipeClass")
                        .WithMany()
                        .HasForeignKey("RecipeClassId1");
                });

            modelBuilder.Entity("MealPlanner.Models.InstructionsClass", b =>
                {
                    b.HasOne("MealPlanner.Models.RecipeClass", "RecipeClass")
                        .WithMany()
                        .HasForeignKey("RecipeClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MealPlanner.Models.RecipeClass", b =>
                {
                    b.HasOne("MealPlanner.Models.TagsClass", "TagsClass")
                        .WithOne("RecipeClass")
                        .HasForeignKey("MealPlanner.Models.RecipeClass", "TagsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MealPlanner.Models.User", "User")
                        .WithOne("RecipeClass")
                        .HasForeignKey("MealPlanner.Models.RecipeClass", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
