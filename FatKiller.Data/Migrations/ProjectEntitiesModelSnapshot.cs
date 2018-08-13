﻿// <auto-generated />
using System;
using FatKiller.Data.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FatKiller.Data.Migrations
{
    [DbContext(typeof(ProjectEntities))]
    partial class ProjectEntitiesModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<Guid?>("DailyFoodDiaryDataId");

                    b.Property<DateTime?>("ModifyDate");

                    b.Property<Guid?>("ModifyUserId");

                    b.HasKey("DailyFoodDiaryId");

                    b.HasIndex("DailyFoodDiaryDataId");

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

            modelBuilder.Entity("FatKiller.Data.Model.DailyFoodDiaryProduct", b =>
                {
                    b.Property<Guid>("DailyFoodDiaryProductId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("CreateDate");

                    b.Property<Guid?>("CreateUserId");

                    b.Property<Guid?>("DailyFoodDiaryId");

                    b.Property<DateTime?>("ModifyDate");

                    b.Property<Guid?>("ModifyUserId");

                    b.Property<Guid?>("ProductId");

                    b.HasKey("DailyFoodDiaryProductId");

                    b.HasIndex("DailyFoodDiaryId");

                    b.HasIndex("ProductId");

                    b.ToTable("DailyFoodDiaryProduct");
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

                    b.Property<Guid?>("MacronutrientsId");

                    b.Property<DateTime?>("ModifyDate");

                    b.Property<Guid?>("ModifyUserId");

                    b.Property<int>("ProductCategory");

                    b.Property<string>("ProductName");

                    b.Property<double>("ProductPrice");

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

                    b.Property<Guid?>("DailyFoodDiaryId");

                    b.Property<string>("Email");

                    b.Property<DateTime?>("ModifyDate");

                    b.Property<Guid?>("ModifyUserId");

                    b.Property<Guid?>("UserDataId");

                    b.Property<string>("UserName");

                    b.Property<Guid?>("UserTypeId");

                    b.HasKey("UserId");

                    b.HasIndex("DailyFoodDiaryId");

                    b.HasIndex("UserDataId");

                    b.HasIndex("UserTypeId");

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

            modelBuilder.Entity("FatKiller.Data.Model.UserType", b =>
                {
                    b.Property<Guid>("UserTypeId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("UserTypeCode");

                    b.HasKey("UserTypeId");

                    b.ToTable("UserType");
                });

            modelBuilder.Entity("FatKiller.Data.Model.DailyFoodDiary", b =>
                {
                    b.HasOne("FatKiller.Data.Model.DailyFoodDiaryData", "DailyFoodDiaryData")
                        .WithMany("DailyFoodDiary")
                        .HasForeignKey("DailyFoodDiaryDataId");
                });

            modelBuilder.Entity("FatKiller.Data.Model.DailyFoodDiaryProduct", b =>
                {
                    b.HasOne("FatKiller.Data.Model.DailyFoodDiary", "DailyFoodDiary")
                        .WithMany("DailyFoodDiaryProduct")
                        .HasForeignKey("DailyFoodDiaryId");

                    b.HasOne("FatKiller.Data.Model.Product", "Product")
                        .WithMany("DailyFoodDiaryProduct")
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("FatKiller.Data.Model.Product", b =>
                {
                    b.HasOne("FatKiller.Data.Model.Macronutrients", "Macronutrients")
                        .WithMany("Product")
                        .HasForeignKey("MacronutrientsId");
                });

            modelBuilder.Entity("FatKiller.Data.Model.User", b =>
                {
                    b.HasOne("FatKiller.Data.Model.DailyFoodDiary", "DailyFoodDiary")
                        .WithMany("User")
                        .HasForeignKey("DailyFoodDiaryId");

                    b.HasOne("FatKiller.Data.Model.UserData", "UserData")
                        .WithMany("User")
                        .HasForeignKey("UserDataId");

                    b.HasOne("FatKiller.Data.Model.UserType", "UserType")
                        .WithMany("User")
                        .HasForeignKey("UserTypeId");
                });
#pragma warning restore 612, 618
        }
    }
}
