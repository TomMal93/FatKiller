﻿// <auto-generated />
using System;
using FatKiller.Data.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FatKiller.Data.Migrations
{
    [DbContext(typeof(ProjectEntities))]
    [Migration("20180725165137_ProductDailyFoodDiaryRelationship")]
    partial class ProductDailyFoodDiaryRelationship
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FatKiller.Data.Model.DailyFoodDiary", b =>
                {
                    b.Property<Guid>("DailyFoodDiaryId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("CreateDate");

                    b.Property<Guid?>("CreateUserId");

                    b.Property<Guid>("DailyFoodDiaryDataId");

                    b.Property<DateTime?>("ModifyDate");

                    b.Property<Guid?>("ModifyUserId");

                    b.Property<Guid>("ProductId");

                    b.HasKey("DailyFoodDiaryId");

                    b.HasIndex("DailyFoodDiaryDataId");

                    b.HasIndex("ProductId");

                    b.ToTable("DailyFoodDiary");
                });

            modelBuilder.Entity("FatKiller.Data.Model.DailyFoodDiaryData", b =>
                {
                    b.Property<Guid>("DailyFoodDiaryDataId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("CreateDate");

                    b.Property<Guid?>("CreateUserId");

                    b.Property<DateTime>("Day");

                    b.Property<DateTime?>("ModifyDate");

                    b.Property<Guid?>("ModifyUserId");

                    b.HasKey("DailyFoodDiaryDataId");

                    b.ToTable("DailyFoodDiaryData");
                });

            modelBuilder.Entity("FatKiller.Data.Model.Macronutrients", b =>
                {
                    b.Property<Guid>("MacronutrientsId")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("Carbohydrates");

                    b.Property<DateTime?>("CreateDate");

                    b.Property<Guid?>("CreateUserId");

                    b.Property<double>("Fat");

                    b.Property<DateTime?>("ModifyDate");

                    b.Property<Guid?>("ModifyUserId");

                    b.Property<double>("Protein");

                    b.HasKey("MacronutrientsId");

                    b.ToTable("Macronutrients");
                });

            modelBuilder.Entity("FatKiller.Data.Model.Product", b =>
                {
                    b.Property<Guid>("ProductId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("CreateDate");

                    b.Property<Guid?>("CreateUserId");

                    b.Property<Guid>("MacronutrientsId");

                    b.Property<DateTime?>("ModifyDate");

                    b.Property<Guid?>("ModifyUserId");

                    b.Property<int>("ProductCategory");

                    b.Property<string>("ProductName");

                    b.Property<double>("ProductPrice");

                    b.Property<double>("ProductWeight");

                    b.HasKey("ProductId");

                    b.HasIndex("MacronutrientsId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("FatKiller.Data.Model.User", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("CreateDate");

                    b.Property<Guid?>("CreateUserId");

                    b.Property<Guid>("DailyFoodDiaryId");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<DateTime?>("ModifyDate");

                    b.Property<Guid?>("ModifyUserId");

                    b.Property<Guid>("UserDataId");

                    b.Property<string>("UserName")
                        .IsRequired();

                    b.HasKey("UserId");

                    b.HasIndex("DailyFoodDiaryId");

                    b.HasIndex("UserDataId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("FatKiller.Data.Model.UserData", b =>
                {
                    b.Property<Guid>("UserdDataId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("CreateDate");

                    b.Property<Guid?>("CreateUserId");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<DateTime?>("ModifyDate");

                    b.Property<Guid?>("ModifyUserId");

                    b.HasKey("UserdDataId");

                    b.ToTable("UserData");
                });

            modelBuilder.Entity("FatKiller.Data.Model.DailyFoodDiary", b =>
                {
                    b.HasOne("FatKiller.Data.Model.DailyFoodDiaryData", "DailyFoodDiaryData")
                        .WithMany("DailyFoodDiary")
                        .HasForeignKey("DailyFoodDiaryDataId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FatKiller.Data.Model.Product", "Product")
                        .WithMany("DailyFoodDiary")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FatKiller.Data.Model.Product", b =>
                {
                    b.HasOne("FatKiller.Data.Model.Macronutrients", "Macronutrients")
                        .WithMany("Product")
                        .HasForeignKey("MacronutrientsId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("FatKiller.Data.Model.User", b =>
                {
                    b.HasOne("FatKiller.Data.Model.DailyFoodDiary", "DailyFoodDiary")
                        .WithMany("User")
                        .HasForeignKey("DailyFoodDiaryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FatKiller.Data.Model.UserData", "UserData")
                        .WithMany("User")
                        .HasForeignKey("UserDataId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
