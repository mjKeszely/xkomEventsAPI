﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using xkomEventsAPI.Data;

namespace xkomEventsAPI.Migrations
{
    [DbContext(typeof(XkomEventsContext))]
    [Migration("20210530105757_ManyToManyRelationshipXkomEventParticipants")]
    partial class ManyToManyRelationshipXkomEventParticipants
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("xkomEventsAPI.Models.Participant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("Id");

                    b.ToTable("Participants");
                });

            modelBuilder.Entity("xkomEventsAPI.Models.ParticipantToXkomEvent", b =>
                {
                    b.Property<int>("ParticipantToXkomEventId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ParticipantId")
                        .HasColumnType("int");

                    b.Property<int>("XkomEventId")
                        .HasColumnType("int");

                    b.HasKey("ParticipantToXkomEventId");

                    b.HasIndex("ParticipantId");

                    b.HasIndex("XkomEventId");

                    b.ToTable("ParticipantsToXkomEvents");
                });

            modelBuilder.Entity("xkomEventsAPI.Models.XkomEvent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("EventName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("EventType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("xkomEventsAPI.Models.ParticipantToXkomEvent", b =>
                {
                    b.HasOne("xkomEventsAPI.Models.Participant", "Participant")
                        .WithMany()
                        .HasForeignKey("ParticipantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("xkomEventsAPI.Models.XkomEvent", "XkomEvent")
                        .WithMany()
                        .HasForeignKey("XkomEventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Participant");

                    b.Navigation("XkomEvent");
                });
#pragma warning restore 612, 618
        }
    }
}
