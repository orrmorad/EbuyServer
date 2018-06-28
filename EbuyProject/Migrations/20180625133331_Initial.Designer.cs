using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using EbuyProject.Models;

namespace EbuyProject.Migrations
{
    [DbContext(typeof(EbuyContext))]
    [Migration("20180625133331_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EbuyProject.Models.Author", b =>
                {
                    b.Property<int>("AuthorId");

                    b.Property<string>("AuthorName");

                    b.HasKey("AuthorId");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("EbuyProject.Models.Bogo", b =>
                {
                    b.Property<int>("BogoId");

                    b.Property<int>("BogoLevel");

                    b.HasKey("BogoId");

                    b.ToTable("Bogos");
                });

            modelBuilder.Entity("EbuyProject.Models.CasualCustomer", b =>
                {
                    b.Property<int>("CasualId");

                    b.Property<string>("Address");

                    b.Property<string>("Email");

                    b.Property<DateTime>("FirstPurchase");

                    b.Property<string>("Name");

                    b.HasKey("CasualId");

                    b.ToTable("CasualCustomers");
                });

            modelBuilder.Entity("EbuyProject.Models.Category", b =>
                {
                    b.Property<int>("CategoryId");

                    b.Property<int>("CategoryType");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("EbuyProject.Models.ClubMember", b =>
                {
                    b.Property<int>("MemberId");

                    b.Property<string>("City");

                    b.Property<int?>("CountryId");

                    b.Property<string>("Email");

                    b.Property<DateTime>("FirstRegistration");

                    b.Property<int>("HouseNumber");

                    b.Property<string>("LoginName");

                    b.Property<string>("Password");

                    b.Property<string>("Phone");

                    b.Property<string>("Street");

                    b.HasKey("MemberId");

                    b.HasIndex("CountryId");

                    b.ToTable("ClubMembers");
                });

            modelBuilder.Entity("EbuyProject.Models.CountryArea", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Country");

                    b.Property<int?>("ShipmentAreaId");

                    b.HasKey("CountryId");

                    b.HasIndex("ShipmentAreaId");

                    b.ToTable("CountryAreas");
                });

            modelBuilder.Entity("EbuyProject.Models.CreditCardTypes", b =>
                {
                    b.Property<int>("CardId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Prefix");

                    b.Property<int>("Type");

                    b.HasKey("CardId");

                    b.ToTable("CreditCardTypes");
                });

            modelBuilder.Entity("EbuyProject.Models.DeliveryModes", b =>
                {
                    b.Property<int>("ModeId");

                    b.Property<int>("Mode");

                    b.HasKey("ModeId");

                    b.ToTable("DeliveryModes");
                });

            modelBuilder.Entity("EbuyProject.Models.Discounts", b =>
                {
                    b.Property<int>("ClubMemberDiscounts")
                        .ValueGeneratedOnAdd();

                    b.HasKey("ClubMemberDiscounts");

                    b.ToTable("Discounts");
                });

            modelBuilder.Entity("EbuyProject.Models.Personnel", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("LoginName");

                    b.Property<string>("Password");

                    b.Property<int>("UserType");

                    b.HasKey("UserId");

                    b.ToTable("Personnels");
                });

            modelBuilder.Entity("EbuyProject.Models.Price", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("ProductPrice");

                    b.HasKey("ProductId");

                    b.ToTable("Prices");
                });

            modelBuilder.Entity("EbuyProject.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AuthorId");

                    b.Property<int?>("BogoId");

                    b.Property<int?>("CategoryId");

                    b.Property<double>("Price");

                    b.Property<string>("ProductAbstract");

                    b.Property<DateTime>("PublicationDate");

                    b.Property<string>("Title");

                    b.HasKey("ProductId");

                    b.HasIndex("AuthorId");

                    b.HasIndex("BogoId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("EbuyProject.Models.PurchasedProduct", b =>
                {
                    b.Property<int>("PurchaseProductId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CustomerId");

                    b.Property<int>("ProductId");

                    b.Property<double>("PurchaseBasicCost");

                    b.Property<DateTime>("PurchasedDate");

                    b.Property<int>("TransactionId");

                    b.Property<double>("Vat");

                    b.HasKey("PurchaseProductId");

                    b.HasIndex("ProductId");

                    b.HasIndex("TransactionId");

                    b.ToTable("PurchasedProducts");
                });

            modelBuilder.Entity("EbuyProject.Models.ShipmenDetails", b =>
                {
                    b.Property<int>("ShipmenDetailsId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Buyer");

                    b.Property<string>("Country");

                    b.Property<string>("Email");

                    b.Property<int>("HouseNumber");

                    b.Property<int>("Pob");

                    b.Property<string>("State");

                    b.Property<string>("Street");

                    b.Property<int>("ZipCode");

                    b.HasKey("ShipmenDetailsId");

                    b.ToTable("ShipmenDetails");
                });

            modelBuilder.Entity("EbuyProject.Models.ShipmentArea", b =>
                {
                    b.Property<int>("ShipmentAreaId");

                    b.Property<string>("Area");

                    b.HasKey("ShipmentAreaId");

                    b.ToTable("ShipmentAreas");
                });

            modelBuilder.Entity("EbuyProject.Models.ShipmentCompany", b =>
                {
                    b.Property<int>("ShipmentCompanyId");

                    b.Property<string>("CompanyName");

                    b.HasKey("ShipmentCompanyId");

                    b.ToTable("ShipmentCompanies");
                });

            modelBuilder.Entity("EbuyProject.Models.ShipmentOptions", b =>
                {
                    b.Property<int>("ShipmentOptionId");

                    b.Property<int>("ShipmentOption");

                    b.HasKey("ShipmentOptionId");

                    b.ToTable("ShipmentOptions");
                });

            modelBuilder.Entity("EbuyProject.Models.ShipmentPrice", b =>
                {
                    b.Property<int>("ShipmentPriceId")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("BasicCharge");

                    b.Property<double>("ItemCharge");

                    b.Property<int?>("ShipmentAreaId");

                    b.Property<int?>("ShipmentCompanyId");

                    b.Property<int>("ShipmentDuration");

                    b.Property<int?>("ShipmentOptionId");

                    b.HasKey("ShipmentPriceId");

                    b.HasIndex("ShipmentAreaId");

                    b.HasIndex("ShipmentCompanyId");

                    b.HasIndex("ShipmentOptionId");

                    b.ToTable("ShipmentPrices");
                });

            modelBuilder.Entity("EbuyProject.Models.Transaction", b =>
                {
                    b.Property<int>("TransactionId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CardExpire");

                    b.Property<int>("CardId");

                    b.Property<int>("CardNumber");

                    b.Property<string>("CardOwner");

                    b.Property<int>("CreditCardNumber");

                    b.Property<int>("CreditCardType");

                    b.Property<DateTime>("DeliveryDate");

                    b.Property<int?>("ModeId");

                    b.Property<int?>("ShipmenDetailsId");

                    b.Property<double>("ShipmentCost");

                    b.Property<int>("ShipmentDetailsId");

                    b.Property<int>("ShipmentOption");

                    b.Property<int>("ShipmentOptionId");

                    b.Property<double>("TotalCost");

                    b.HasKey("TransactionId");

                    b.HasIndex("CardId");

                    b.HasIndex("ModeId");

                    b.HasIndex("ShipmenDetailsId");

                    b.HasIndex("ShipmentOptionId");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("EbuyProject.Models.Vat", b =>
                {
                    b.Property<int>("VAT")
                        .ValueGeneratedOnAdd();

                    b.HasKey("VAT");

                    b.ToTable("Vat");
                });

            modelBuilder.Entity("EbuyProject.Models.ClubMember", b =>
                {
                    b.HasOne("EbuyProject.Models.CountryArea", "Country")
                        .WithMany("ClubMembers")
                        .HasForeignKey("CountryId");
                });

            modelBuilder.Entity("EbuyProject.Models.CountryArea", b =>
                {
                    b.HasOne("EbuyProject.Models.ShipmentArea", "ShipmentArea")
                        .WithMany("CountryAreas")
                        .HasForeignKey("ShipmentAreaId");
                });

            modelBuilder.Entity("EbuyProject.Models.Product", b =>
                {
                    b.HasOne("EbuyProject.Models.Author", "Author")
                        .WithMany("Products")
                        .HasForeignKey("AuthorId");

                    b.HasOne("EbuyProject.Models.Bogo", "Bogo")
                        .WithMany("Products")
                        .HasForeignKey("BogoId");

                    b.HasOne("EbuyProject.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId");
                });

            modelBuilder.Entity("EbuyProject.Models.PurchasedProduct", b =>
                {
                    b.HasOne("EbuyProject.Models.Product", "Products")
                        .WithMany("PurchasedProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EbuyProject.Models.Transaction", "Transaction")
                        .WithMany("Product")
                        .HasForeignKey("TransactionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("EbuyProject.Models.ShipmentPrice", b =>
                {
                    b.HasOne("EbuyProject.Models.ShipmentArea", "ShipmentArea")
                        .WithMany("ShipmentPrices")
                        .HasForeignKey("ShipmentAreaId");

                    b.HasOne("EbuyProject.Models.ShipmentCompany", "ShipmentCompany")
                        .WithMany("ShipmentPrices")
                        .HasForeignKey("ShipmentCompanyId");

                    b.HasOne("EbuyProject.Models.ShipmentOptions", "ShipmentOption")
                        .WithMany("ShipmentPrices")
                        .HasForeignKey("ShipmentOptionId");
                });

            modelBuilder.Entity("EbuyProject.Models.Transaction", b =>
                {
                    b.HasOne("EbuyProject.Models.CreditCardTypes", "CreditCardTypes")
                        .WithMany("Transactions")
                        .HasForeignKey("CardId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("EbuyProject.Models.DeliveryModes", "DeliveryMode")
                        .WithMany("Transactions")
                        .HasForeignKey("ModeId");

                    b.HasOne("EbuyProject.Models.ShipmenDetails", "ShipmenDetails")
                        .WithMany("Transactions")
                        .HasForeignKey("ShipmenDetailsId");

                    b.HasOne("EbuyProject.Models.ShipmentOptions", "ShipmentOptions")
                        .WithMany("Transactions")
                        .HasForeignKey("ShipmentOptionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
