﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WEBCOREADS2021.Models;

namespace WEBCOREADS2021.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WEBCOREADS2021.Models.Dominio.Peixe", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("isca")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("peso")
                        .HasColumnType("real");

                    b.HasKey("id");

                    b.ToTable("Peixes");
                });

            modelBuilder.Entity("WEBCOREADS2021.Models.Dominio.Pescador", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Premiacaoid")
                        .HasColumnType("int");

                    b.Property<string>("cidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("idade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nome")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("Premiacaoid");

                    b.ToTable("Pescadores");
                });

            modelBuilder.Entity("WEBCOREADS2021.Models.Dominio.Premiacao", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("colocacao")
                        .HasColumnType("int");

                    b.Property<int?>("pescadorid")
                        .HasColumnType("int");

                    b.Property<string>("premio")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("pescadorid");

                    b.ToTable("Premiacoes");
                });

            modelBuilder.Entity("WEBCOREADS2021.Models.Dominio.Tipo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("descricao")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<string>("municipio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("outros")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Tipo");
                });

            modelBuilder.Entity("WEBCOREADS2021.Models.Dominio.Pescador", b =>
                {
                    b.HasOne("WEBCOREADS2021.Models.Dominio.Premiacao", null)
                        .WithMany("nome")
                        .HasForeignKey("Premiacaoid");
                });

            modelBuilder.Entity("WEBCOREADS2021.Models.Dominio.Premiacao", b =>
                {
                    b.HasOne("WEBCOREADS2021.Models.Dominio.Pescador", "pescador")
                        .WithMany()
                        .HasForeignKey("pescadorid");

                    b.Navigation("pescador");
                });

            modelBuilder.Entity("WEBCOREADS2021.Models.Dominio.Premiacao", b =>
                {
                    b.Navigation("nome");
                });
#pragma warning restore 612, 618
        }
    }
}
