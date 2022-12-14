// <auto-generated />
using CustomerManagement.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CustomerManagement.Migrations
{
    [DbContext(typeof(Nagaraj_DBContext))]
    partial class Nagaraj_DBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CustomerManagement.Models.Customer", b =>
                {
                    b.Property<int>("CustId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CustAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CustBarrowedBooks")
                        .HasColumnType("int");

                    b.Property<string>("CustName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustPhoto")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustId");

                    b.ToTable("CustomerTable");

                    b.HasData(
                        new
                        {
                            CustId = 1,
                            CustAddress = "Benagaluru",
                            CustBarrowedBooks = 2,
                            CustName = "Nagaraj",
                            CustPhoto = "https://i.kinja-img.com/gawker-media/image/upload/t_original/ijsi5fzb1nbkbhxa2gc1.png"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
