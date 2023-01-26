﻿// <auto-generated />
using BackEndApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BackEndApi.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20230126110048_SeedData")]
    partial class SeedData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("BackEndApi.Models.Issue", b =>
                {
                    b.Property<int>("IssueId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("Subject")
                        .HasColumnType("longtext");

                    b.Property<string>("Token")
                        .HasColumnType("longtext");

                    b.HasKey("IssueId");

                    b.ToTable("Issues");

                    b.HasData(
                        new
                        {
                            IssueId = 1,
                            Description = "Hello i've been trying to dev a bot in Discord.net and it's been doing good so far. Though issue that i had is that i'm trying to use the GetMessagesAsync from ITextChannel using an option. Unfortunately i have no idea how to initiate RequestOptions and i try to search the documentation and found nothing.",
                            Name = "Brian",
                            Subject = "Discord.net cannot initiate RequestOptions"
                        },
                        new
                        {
                            IssueId = 2,
                            Description = "How can I mention guild roles in C# with the Discord.net library?",
                            Name = "Yodel",
                            Subject = "Discord.net how to mention roles"
                        },
                        new
                        {
                            IssueId = 3,
                            Description = "I'm trying to get a discord bot coded in discord.net running on a linux VPS, I'm running via mono but I keep getting this error",
                            Name = "Robert",
                            Subject = "Discord.net not working on linux"
                        });
                });

            modelBuilder.Entity("BackEndApi.Models.Solution", b =>
                {
                    b.Property<int>("SolutionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<int>("IssueId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("SolutionId");

                    b.HasIndex("IssueId");

                    b.ToTable("Solutions");

                    b.HasData(
                        new
                        {
                            SolutionId = 1,
                            Description = "The As shown in the docs (https://docs.stillu.cc/guides/getting_started/installing.html), it's not possible to run Discord.Net with Mono. I suggest you to switch to .NET Core. When you'll now compile the code, it will output a .dll file (and regular .exe if 3.1+). Download .NET Core runtime on your distribution: https://learn.microsoft.com/en-us/dotnet/core/install/linux. Once it's installed you should be able to run the .dll file with the following command in the terminal: dotnet <path_to_dll>",
                            IssueId = 3
                        },
                        new
                        {
                            SolutionId = 2,
                            Description = "It's also possible to use the raw mention of a role, that is in fact the content of the .Mention property in a role object. The format is the following: <@&ROLE_ID> It differs from mentioning an individual user by the & character, that specifies it's mentioning the role, not a user. You can get the role ID from the .ID property, or by right clicking the role in the roles list, if you want to hardcode it. Example command of mentioning a role by the name:",
                            IssueId = 2
                        });
                });

            modelBuilder.Entity("BackEndApi.Models.Solution", b =>
                {
                    b.HasOne("BackEndApi.Models.Issue", "Issue")
                        .WithMany("Solutions")
                        .HasForeignKey("IssueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Issue");
                });

            modelBuilder.Entity("BackEndApi.Models.Issue", b =>
                {
                    b.Navigation("Solutions");
                });
#pragma warning restore 612, 618
        }
    }
}