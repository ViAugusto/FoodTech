﻿// <auto-generated />
using System;
using FoodTech.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FoodTech.Migrations.ClientPj
{
    [DbContext(typeof(ClientPjContext))]
    partial class ClientPjContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("FoodTech.Models.ClientPjModel", b =>
                {
                    b.Property<int>("IdClientePj")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Cnpj")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NomeFantasia")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("UsuarioModelId")
                        .HasColumnType("int");

                    b.HasKey("IdClientePj");

                    b.HasIndex("UsuarioModelId");

                    b.ToTable("ClientPjModel");
                });

            modelBuilder.Entity("FoodTech.Models.UsuarioModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("NomeUsuario")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("TipoUsuario")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("UsuarioModel");
                });

            modelBuilder.Entity("FoodTech.Models.ClientPjModel", b =>
                {
                    b.HasOne("FoodTech.Models.UsuarioModel", "UsuarioModel")
                        .WithMany()
                        .HasForeignKey("UsuarioModelId");

                    b.Navigation("UsuarioModel");
                });
#pragma warning restore 612, 618
        }
    }
}