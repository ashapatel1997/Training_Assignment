﻿// <auto-generated />
using System;
using MessageBoard_WebAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MessageBoard_WebAPI.Migrations
{
    [DbContext(typeof(DbPostContext))]
    partial class DbPostContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MessageBoard_WebAPI.Models.CommentMessage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment")
                        .IsRequired();

                    b.Property<int?>("PostMessageId");

                    b.HasKey("Id");

                    b.HasIndex("PostMessageId");

                    b.ToTable("CommentMessage");
                });

            modelBuilder.Entity("MessageBoard_WebAPI.Models.PostMessage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Message")
                        .IsRequired();

                    b.Property<int>("Total_Likes");

                    b.HasKey("Id");

                    b.ToTable("postMessageData");
                });

            modelBuilder.Entity("MessageBoard_WebAPI.Models.CommentMessage", b =>
                {
                    b.HasOne("MessageBoard_WebAPI.Models.PostMessage")
                        .WithMany("Comment")
                        .HasForeignKey("PostMessageId");
                });
#pragma warning restore 612, 618
        }
    }
}