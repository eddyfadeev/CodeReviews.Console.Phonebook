﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Phonebook.wkktoria;

#nullable disable

namespace Phonebook.wkktoria.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231023201931_CreateCategory")]
    partial class CreateCategory
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Phonebook.wkktoria.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Family"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Friends"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Work"
                        });
                });

            modelBuilder.Entity("Phonebook.wkktoria.Models.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Contacts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Email = "john@email.com",
                            Name = "John",
                            PhoneNumber = "123-123-123"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Email = "adam@email.com",
                            Name = "Adam",
                            PhoneNumber = "111-111-111"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            Email = "anne@email.com",
                            Name = "Anne",
                            PhoneNumber = "321-321-321"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 3,
                            Email = "victoria@email.com",
                            Name = "Victoria",
                            PhoneNumber = "333-333-333"
                        });
                });

            modelBuilder.Entity("Phonebook.wkktoria.Models.Contact", b =>
                {
                    b.HasOne("Phonebook.wkktoria.Models.Category", "Category")
                        .WithMany("Contacts")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Phonebook.wkktoria.Models.Category", b =>
                {
                    b.Navigation("Contacts");
                });
#pragma warning restore 612, 618
        }
    }
}
