﻿// <auto-generated />
using HelpManual.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace HelpManual.Migrations
{
    [DbContext(typeof(HelpManualDbContext))]
    [Migration("20180124140203_UserAccessFullName")]
    partial class UserAccessFullName
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HelpManual.Entities.ControlType", b =>
                {
                    b.Property<int>("ControlTypeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Control")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("ControlTypeId");

                    b.ToTable("ControlType");
                });

            modelBuilder.Entity("HelpManual.Entities.FormObject", b =>
                {
                    b.Property<int>("FormObjectId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ObjectTypeId");

                    b.Property<int>("Order");

                    b.Property<int>("PageNo");

                    b.Property<string>("QuestionNo");

                    b.HasKey("FormObjectId");

                    b.HasIndex("ObjectTypeId");

                    b.ToTable("FormObject");
                });

            modelBuilder.Entity("HelpManual.Entities.ObjectType", b =>
                {
                    b.Property<int>("ObjectTypeId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ControlTypeId");

                    b.Property<string>("Data");

                    b.Property<byte[]>("Image");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Options");

                    b.Property<string>("StartEnd");

                    b.HasKey("ObjectTypeId");

                    b.HasIndex("ControlTypeId");

                    b.ToTable("ObjectType");
                });

            modelBuilder.Entity("HelpManual.Entities.UserAccess", b =>
                {
                    b.Property<int>("UserAccessId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateAccessed");

                    b.Property<string>("FullName");

                    b.Property<int>("PageNo");

                    b.Property<string>("UserId");

                    b.HasKey("UserAccessId");

                    b.ToTable("UserAccess");
                });

            modelBuilder.Entity("HelpManual.Entities.FormObject", b =>
                {
                    b.HasOne("HelpManual.Entities.ObjectType", "ObjectType")
                        .WithMany("FormObject")
                        .HasForeignKey("ObjectTypeId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("HelpManual.Entities.ObjectType", b =>
                {
                    b.HasOne("HelpManual.Entities.ControlType", "ControlType")
                        .WithMany("ObjectType")
                        .HasForeignKey("ControlTypeId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
