﻿// <auto-generated />
using System;
using BoutiqueEnLigne.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BoutiqueEnLigne.Core.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20221212162631_InitialModel")]
    partial class InitialModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BoutiqueEnLigne.Core.Model.Panier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("UtilisateurId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Panier");
                });

            modelBuilder.Entity("BoutiqueEnLigne.Core.Model.Produits", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PanierId")
                        .HasColumnType("int");

                    b.Property<string>("Produit")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PanierId");

                    b.ToTable("Produits");
                });

            modelBuilder.Entity("BoutiqueEnLigne.Core.Model.Utilisateur", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PanierId")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PanierId")
                        .IsUnique()
                        .HasFilter("[PanierId] IS NOT NULL");

                    b.ToTable("Utilisateurs");
                });

            modelBuilder.Entity("BoutiqueEnLigne.Core.Model.Produits", b =>
                {
                    b.HasOne("BoutiqueEnLigne.Core.Model.Panier", null)
                        .WithMany("Produit")
                        .HasForeignKey("PanierId");
                });

            modelBuilder.Entity("BoutiqueEnLigne.Core.Model.Utilisateur", b =>
                {
                    b.HasOne("BoutiqueEnLigne.Core.Model.Panier", "Panier")
                        .WithOne("Utilisateur")
                        .HasForeignKey("BoutiqueEnLigne.Core.Model.Utilisateur", "PanierId");

                    b.Navigation("Panier");
                });

            modelBuilder.Entity("BoutiqueEnLigne.Core.Model.Panier", b =>
                {
                    b.Navigation("Produit");

                    b.Navigation("Utilisateur")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
