﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Ponto.Persistence.Context;

#nullable disable

namespace Ponto.Persistence.Migrations
{
    [DbContext(typeof(ColaboradorContext))]
    partial class ColaboradorContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.10");

            modelBuilder.Entity("Ponto.Domain.Models.Colaborador", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("DataRegistro")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .HasColumnType("TEXT");

                    b.Property<char?>("TipoOperacao")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Colaboradors");
                });
#pragma warning restore 612, 618
        }
    }
}
