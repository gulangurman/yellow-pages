﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShortListMVC.Data;

#nullable disable

namespace ShortListMVC.Migrations.Post
{
    [DbContext(typeof(PostContext))]
    partial class PostContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.3");

            modelBuilder.Entity("ShortListMVC.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Icon")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Slug")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Icon = "dinner",
                            Name = "Kayıp",
                            Slug = "lost"
                        },
                        new
                        {
                            Id = 2,
                            Icon = "home",
                            Name = "Evcil Hayvanlar",
                            Slug = "pets"
                        },
                        new
                        {
                            Id = 3,
                            Icon = "tshirt",
                            Name = "Eleman Aranıyor",
                            Slug = "hiring"
                        },
                        new
                        {
                            Id = 4,
                            Icon = "travel",
                            Name = "İkinci El",
                            Slug = "secondhand"
                        },
                        new
                        {
                            Id = 5,
                            Icon = "jobs",
                            Name = "Serbest Çalışanlar",
                            Slug = "hiring"
                        },
                        new
                        {
                            Id = 6,
                            Icon = "bullhorn",
                            Name = "Etkinlikler",
                            Slug = "hiring"
                        },
                        new
                        {
                            Id = 7,
                            Icon = "bolt",
                            Name = "Ev yapımı",
                            Slug = "handmade"
                        });
                });

            modelBuilder.Entity("ShortListMVC.Models.City", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("City");

                    b.HasData(
                        new
                        {
                            Id = "06",
                            Name = "Ankara"
                        },
                        new
                        {
                            Id = "34",
                            Name = "İstanbul"
                        },
                        new
                        {
                            Id = "35",
                            Name = "İzmir"
                        });
                });

            modelBuilder.Entity("ShortListMVC.Models.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("AccountId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CityId")
                        .HasColumnType("TEXT");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Tags")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("CityId");

                    b.ToTable("Post");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccountId = "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                            CategoryId = 1,
                            CityId = "06",
                            Content = "Kedimiz Bıdık kaybolmuştur.",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageUrl = "https://www.markuptag.com/images/image-six.jpg",
                            Tags = "kedi",
                            Title = "Kayıp kedi"
                        },
                        new
                        {
                            Id = 2,
                            AccountId = "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                            CategoryId = 3,
                            CityId = "34",
                            Content = "Acil eleman aranıyor.",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageUrl = "https://www.markuptag.com/images/image-two.jpg",
                            Tags = "eleman",
                            Title = "Eleman aranıyor"
                        },
                        new
                        {
                            Id = 3,
                            AccountId = "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                            CategoryId = 4,
                            CityId = "35",
                            Content = "İkinci el cep telefonu.",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageUrl = "https://www.markuptag.com/images/image-three.jpg",
                            Tags = "telefon",
                            Title = "Satılık telefon"
                        },
                        new
                        {
                            Id = 4,
                            AccountId = "02174cf0–9412–4cfe - afbf - 59f706d72cf6",
                            CategoryId = 6,
                            CityId = "34",
                            Content = "Sahilde konser etkinliğinde buluşuyoruz.",
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            CreatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageUrl = "https://www.markuptag.com/images/image-four.jpg",
                            Tags = "konser",
                            Title = "Sahil konserleri"
                        });
                });

            modelBuilder.Entity("ShortListMVC.Models.Post", b =>
                {
                    b.HasOne("ShortListMVC.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId");

                    b.HasOne("ShortListMVC.Models.City", "City")
                        .WithMany("Posts")
                        .HasForeignKey("CityId");

                    b.Navigation("Category");

                    b.Navigation("City");
                });

            modelBuilder.Entity("ShortListMVC.Models.City", b =>
                {
                    b.Navigation("Posts");
                });
#pragma warning restore 612, 618
        }
    }
}
