// <auto-generated />
using Group5Try1;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Group5Try1.Migrations
{
    [DbContext(typeof(SettingDbContext))]
    [Migration("20211113050012_initial4")]
    partial class initial4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Group5Try1.Models.PLocation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Location")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Location");

                    b.HasKey("Id");

                    b.ToTable("PLocations");
                });

            modelBuilder.Entity("Group5Try1.Models.Setting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Email");

                    b.Property<string>("NPI_No")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("NPI No");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Name");

                    b.Property<int>("PLocation_id")
                        .HasColumnType("int")
                        .HasColumnName("PLocation_id");

                    b.Property<int>("PhNumber")
                        .HasMaxLength(50)
                        .HasColumnType("int")
                        .HasColumnName("PhNumber");

                    b.Property<int>("Speciality_id")
                        .HasColumnType("int")
                        .HasColumnName("Speciality_id");

                    b.HasKey("Id");

                    b.HasIndex("PLocation_id");

                    b.HasIndex("Speciality_id");

                    b.ToTable("AccountSetting");
                });

            modelBuilder.Entity("Group5Try1.Models.Speciality", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Catagory")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Catagory");

                    b.HasKey("Id");

                    b.ToTable("Specialities");
                });

            modelBuilder.Entity("Group5Try1.Models.Setting", b =>
                {
                    b.HasOne("Group5Try1.Models.PLocation", "PLocation")
                        .WithMany()
                        .HasForeignKey("PLocation_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Group5Try1.Models.Speciality", "Speciality")
                        .WithMany()
                        .HasForeignKey("Speciality_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PLocation");

                    b.Navigation("Speciality");
                });
#pragma warning restore 612, 618
        }
    }
}
