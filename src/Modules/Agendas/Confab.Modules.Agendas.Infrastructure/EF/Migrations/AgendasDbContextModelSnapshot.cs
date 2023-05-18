﻿// <auto-generated />
using System;
using Confab.Modules.Agendas.Infrastructure.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Confab.Modules.Agendas.Infrastructure.EF.Migrations
{
    [DbContext(typeof(AgendasDbContext))]
    partial class AgendasDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("agendas")
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("Confab.Modules.Agendas.Domain.Submissions.Entities.Speaker", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<string>("FullName")
                        .HasColumnType("text");

                    b.Property<int>("Version")
                        .IsConcurrencyToken()
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Speakers");
                });

            modelBuilder.Entity("Confab.Modules.Agendas.Domain.Submissions.Entities.Submission", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<Guid?>("ConferenceId")
                        .HasColumnType("uuid");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<int>("Level")
                        .HasColumnType("integer");

                    b.Property<string>("Status")
                        .HasColumnType("text");

                    b.Property<string>("Tags")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.Property<int>("Version")
                        .IsConcurrencyToken()
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Submissions");
                });

            modelBuilder.Entity("SpeakerSubmission", b =>
                {
                    b.Property<Guid>("SpeakersId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("SubmissionsId")
                        .HasColumnType("uuid");

                    b.HasKey("SpeakersId", "SubmissionsId");

                    b.HasIndex("SubmissionsId");

                    b.ToTable("SpeakerSubmission");
                });

            modelBuilder.Entity("SpeakerSubmission", b =>
                {
                    b.HasOne("Confab.Modules.Agendas.Domain.Submissions.Entities.Speaker", null)
                        .WithMany()
                        .HasForeignKey("SpeakersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Confab.Modules.Agendas.Domain.Submissions.Entities.Submission", null)
                        .WithMany()
                        .HasForeignKey("SubmissionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
