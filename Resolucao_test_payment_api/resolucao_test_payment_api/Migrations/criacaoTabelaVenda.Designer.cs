using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using tech_test_payment_api_main.Context;

#nullable disable

namespace tech_test_payment_api_main.Migrations
{
    [DbContext(typeof(VendaContext))]
    [Migration("20221103145544_CriacaoTabelaVenda")]
    partial class CriacaoTabelaVenda
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("tech_test_payment_api_main.Models.Venda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CpfVendedor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmailVendedor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdVendedor")
                        .HasColumnType("int");

                    b.Property<string>("ItemVenda")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeVendedor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("TelefoneVendedor")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Vendas");
                });
#pragma warning restore 612, 618
        }
    }
}
