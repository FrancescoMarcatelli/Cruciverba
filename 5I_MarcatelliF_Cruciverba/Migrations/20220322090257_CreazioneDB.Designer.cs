﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace _5I_MarcatelliF_Cruciverba.Migrations
{
    [DbContext(typeof(DbCruciverba))]
    [Migration("20220322090257_CreazioneDB")]
    partial class CreazioneDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.3");

            modelBuilder.Entity("Cruciverba", b =>
                {
                    b.Property<int>("CruciverbaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Height")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Solution")
                        .HasColumnType("TEXT");

                    b.Property<int>("Width")
                        .HasColumnType("INTEGER");

                    b.HasKey("CruciverbaId");

                    b.ToTable("Cruciverba");
                });

            modelBuilder.Entity("Suggerimento", b =>
                {
                    b.Property<int>("SuggerimentoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CruciverbaId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descrizione")
                        .HasColumnType("TEXT");

                    b.Property<int>("Numero")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("isHoriz")
                        .HasColumnType("INTEGER");

                    b.HasKey("SuggerimentoId");

                    b.HasIndex("CruciverbaId");

                    b.ToTable("Suggerimenti");
                });

            modelBuilder.Entity("Suggerimento", b =>
                {
                    b.HasOne("Cruciverba", "Cruciverba")
                        .WithMany("suggerimentos")
                        .HasForeignKey("CruciverbaId");

                    b.Navigation("Cruciverba");
                });

            modelBuilder.Entity("Cruciverba", b =>
                {
                    b.Navigation("suggerimentos");
                });
#pragma warning restore 612, 618
        }
    }
}
