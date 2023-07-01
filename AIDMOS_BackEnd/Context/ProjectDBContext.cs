using System;
using System.Collections.Generic;
using AIDMOS_BackEnd.Models;
using Microsoft.EntityFrameworkCore;

namespace AIDMOS_BackEnd.Context;

public partial class ProjectDBContext : DbContext
{
    public ProjectDBContext()
    {
    }

    public ProjectDBContext(DbContextOptions<ProjectDBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AccContraentry> AccContraentries { get; set; }

    public virtual DbSet<AccGroup> AccGroups { get; set; }

    public virtual DbSet<AccJournalentry> AccJournalentries { get; set; }

    public virtual DbSet<AccJournalentrydetail> AccJournalentrydetails { get; set; }

    public virtual DbSet<AccLedger> AccLedgers { get; set; }

    public virtual DbSet<AccLedgerbalance> AccLedgerbalances { get; set; }

    public virtual DbSet<AccOtherchargesdebitcreditnotesetting> AccOtherchargesdebitcreditnotesettings { get; set; }

    public virtual DbSet<AccOtherchargessetting> AccOtherchargessettings { get; set; }

    public virtual DbSet<AccPaymententry> AccPaymententries { get; set; }

    public virtual DbSet<AccProductbalance> AccProductbalances { get; set; }

    public virtual DbSet<AccReceiptentry> AccReceiptentries { get; set; }

    public virtual DbSet<AccSchedule> AccSchedules { get; set; }

    public virtual DbSet<AccSetting> AccSettings { get; set; }

    public virtual DbSet<AccTransaction> AccTransactions { get; set; }

    public virtual DbSet<AccTransactiontype> AccTransactiontypes { get; set; }

    public virtual DbSet<Advertisement> Advertisements { get; set; }

    public virtual DbSet<Area> Areas { get; set; }

    public virtual DbSet<Business> Businesses { get; set; }

    public virtual DbSet<Company> Companies { get; set; }

    public virtual DbSet<Creditnote> Creditnotes { get; set; }

    public virtual DbSet<Creditnoteotherchargesdetail> Creditnoteotherchargesdetails { get; set; }

    public virtual DbSet<Debitnote> Debitnotes { get; set; }

    public virtual DbSet<Debitnoteotherchargesdetail> Debitnoteotherchargesdetails { get; set; }

    public virtual DbSet<Deliverynote> Deliverynotes { get; set; }

    public virtual DbSet<Deliverynotedetail> Deliverynotedetails { get; set; }

    public virtual DbSet<Deliverynoteotherchargesdetail> Deliverynoteotherchargesdetails { get; set; }

    public virtual DbSet<District> Districts { get; set; }

    public virtual DbSet<Financialyear> Financialyears { get; set; }

    public virtual DbSet<Location> Locations { get; set; }

    public virtual DbSet<Menu> Menus { get; set; }

    public virtual DbSet<Module> Modules { get; set; }

    public virtual DbSet<Modulemenu> Modulemenus { get; set; }

    public virtual DbSet<Notice> Notices { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductGstrate> ProductGstrates { get; set; }

    public virtual DbSet<Productlotwisestock> Productlotwisestocks { get; set; }

    public virtual DbSet<Purchase> Purchases { get; set; }

    public virtual DbSet<Purchasedetail> Purchasedetails { get; set; }

    public virtual DbSet<Purchaseotherchargesdetail> Purchaseotherchargesdetails { get; set; }

    public virtual DbSet<Purchasereturn> Purchasereturns { get; set; }

    public virtual DbSet<Purchasereturndetail> Purchasereturndetails { get; set; }

    public virtual DbSet<Purchasereturnotherchargesdetail> Purchasereturnotherchargesdetails { get; set; }

    public virtual DbSet<Receiptnote> Receiptnotes { get; set; }

    public virtual DbSet<Receiptnotedetail> Receiptnotedetails { get; set; }

    public virtual DbSet<Receiptnoteotherchargesdetail> Receiptnoteotherchargesdetails { get; set; }

    public virtual DbSet<Reminder> Reminders { get; set; }

    public virtual DbSet<Reminderfollowup> Reminderfollowups { get; set; }

    public virtual DbSet<Sale> Sales { get; set; }

    public virtual DbSet<Saledetail> Saledetails { get; set; }

    public virtual DbSet<Saleotherchargesdetail> Saleotherchargesdetails { get; set; }

    public virtual DbSet<Salereturn> Salereturns { get; set; }

    public virtual DbSet<Salereturndetail> Salereturndetails { get; set; }

    public virtual DbSet<Salereturnotherchargesdetail> Salereturnotherchargesdetails { get; set; }

    public virtual DbSet<State> States { get; set; }

    public virtual DbSet<Stocktransferhistory> Stocktransferhistories { get; set; }

    public virtual DbSet<Taluka> Talukas { get; set; }

    public virtual DbSet<Trialtable> Trialtables { get; set; }

    public virtual DbSet<Unit> Units { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<Usermodulemapping> Usermodulemappings { get; set; }

    public virtual DbSet<Village> Villages { get; set; }

    public virtual DbSet<WebContactmessage> WebContactmessages { get; set; }

    public virtual DbSet<Wholesaletoreatailtransfer> Wholesaletoreatailtransfers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-DA68IOP\\SQLEXPRESS;Initial Catalog=aidmos;Integrated Security=True;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AccContraentry>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_acc_contraentries1_1");

            entity.ToTable("acc_contraentries", tb => tb.HasTrigger("trSql_acc_contraentries"));

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AccGroup>(entity =>
        {
            entity.ToTable("acc_groups", tb => tb.HasTrigger("trSql_acc_groups"));

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Business).WithMany(p => p.AccGroups).HasConstraintName("FK_acc_groups_businesses");

            entity.HasOne(d => d.Schedule).WithMany(p => p.AccGroups).HasConstraintName("FK_acc_groups_acc_schedules");
        });

        modelBuilder.Entity<AccJournalentry>(entity =>
        {
            entity.ToTable("acc_journalentries", tb => tb.HasTrigger("trSql_acc_journalentries"));

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AccJournalentrydetail>(entity =>
        {
            entity.ToTable("acc_journalentrydetails", tb => tb.HasTrigger("trSql_acc_journalentrydetails"));

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AccLedger>(entity =>
        {
            entity.ToTable("acc_ledgers", tb => tb.HasTrigger("trSql_acc_ledgers"));

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AccLedgerbalance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_acc_ledgeropeningbalances");

            entity.ToTable("acc_ledgerbalances", tb => tb.HasTrigger("trSql_acc_ledgeropeningbalances"));

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Business).WithMany(p => p.AccLedgerbalances).HasConstraintName("FK_acc_ledgerbalances_businesses");

            entity.HasOne(d => d.Ledger).WithMany(p => p.AccLedgerbalances).HasConstraintName("FK_acc_ledgerbalances_acc_ledgers");
        });

        modelBuilder.Entity<AccOtherchargesdebitcreditnotesetting>(entity =>
        {
            entity.ToTable("acc_otherchargesdebitcreditnotesettings", tb => tb.HasTrigger("trSql_acc_otherchargesdebitcreditnotesettings"));

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AccOtherchargessetting>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_acc_otherchargessettings1");

            entity.ToTable("acc_otherchargessettings", tb => tb.HasTrigger("trSql_acc_otherchargessettings"));

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Purchaseledger).WithMany(p => p.AccOtherchargessettingPurchaseledgers).HasConstraintName("FK_acc_otherchargessettings_acc_ledgers");

            entity.HasOne(d => d.Saleledger).WithMany(p => p.AccOtherchargessettingSaleledgers).HasConstraintName("FK_acc_otherchargessettings_acc_ledgers1");
        });

        modelBuilder.Entity<AccPaymententry>(entity =>
        {
            entity.ToTable("acc_paymententries", tb => tb.HasTrigger("trSql_acc_paymententries"));

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AccProductbalance>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_acc_productbalances1");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AccReceiptentry>(entity =>
        {
            entity.ToTable("acc_receiptentries", tb => tb.HasTrigger("trSql_acc_receiptentries"));

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AccSchedule>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_acc_schedules1");

            entity.ToTable("acc_schedules", tb => tb.HasTrigger("trSql_acc_schedules"));

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AccSetting>(entity =>
        {
            entity.ToTable("acc_settings", tb => tb.HasTrigger("trSql_acc_settings"));

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AccTransaction>(entity =>
        {
            entity.ToTable("acc_transactions", tb => tb.HasTrigger("trSql_acc_transactions"));

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Business).WithMany(p => p.AccTransactions).HasConstraintName("FK_acc_transactions_businesses");

            entity.HasOne(d => d.Ledger).WithMany(p => p.AccTransactions).HasConstraintName("FK_acc_transactions_acc_ledgers");
        });

        modelBuilder.Entity<AccTransactiontype>(entity =>
        {
            entity.ToTable("acc_transactiontypes", tb => tb.HasTrigger("trSql_acc_transactiontypes"));

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Advertisement>(entity =>
        {
            entity.ToTable("advertisements", tb => tb.HasTrigger("trSql_advertisements"));

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Area>(entity =>
        {
            entity.ToTable("areas", tb => tb.HasTrigger("trSql_areas"));

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Village).WithMany(p => p.Areas).HasConstraintName("FK_areas_villages");
        });

        modelBuilder.Entity<Business>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_businesses1");

            entity.HasOne(d => d.Village).WithMany(p => p.Businesses).HasConstraintName("FK_businesses_villages");
        });

        modelBuilder.Entity<Company>(entity =>
        {
            entity.ToTable("companies", tb => tb.HasTrigger("trSql_companies"));

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Creditnote>(entity =>
        {
            entity.ToTable("creditnotes", tb => tb.HasTrigger("trSql_creditnotes"));

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Business).WithMany(p => p.Creditnotes).HasConstraintName("FK_creditnotes_businesses");

            entity.HasOne(d => d.Ledger).WithMany(p => p.Creditnotes).HasConstraintName("FK_creditnotes_acc_ledgers");

            entity.HasOne(d => d.Sale).WithMany(p => p.Creditnotes).HasConstraintName("FK_creditnotes_sales");
        });

        modelBuilder.Entity<Creditnoteotherchargesdetail>(entity =>
        {
            entity.ToTable("creditnoteotherchargesdetails", tb => tb.HasTrigger("trSql_creditnoteotherchargesdetails"));

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Creditnote).WithMany(p => p.Creditnoteotherchargesdetails).HasConstraintName("FK_creditnoteotherchargesdetails_creditnotes");
        });

        modelBuilder.Entity<Debitnote>(entity =>
        {
            entity.ToTable("debitnotes", tb => tb.HasTrigger("trSql_debitnotes"));

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Business).WithMany(p => p.Debitnotes).HasConstraintName("FK_debitnotes_businesses");

            entity.HasOne(d => d.Ledger).WithMany(p => p.Debitnotes).HasConstraintName("FK_debitnotes_acc_ledgers");

            entity.HasOne(d => d.Purchase).WithMany(p => p.Debitnotes).HasConstraintName("FK_debitnotes_purchases");
        });

        modelBuilder.Entity<Debitnoteotherchargesdetail>(entity =>
        {
            entity.ToTable("debitnoteotherchargesdetails", tb => tb.HasTrigger("trSql_debitnoteotherchargesdetails"));

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Debitnote).WithMany(p => p.Debitnoteotherchargesdetails).HasConstraintName("FK_debitnoteotherchargesdetails_debitnotes");
        });

        modelBuilder.Entity<Deliverynote>(entity =>
        {
            entity.ToTable("deliverynotes", tb => tb.HasTrigger("trSql_deliverynotes"));

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Business).WithMany(p => p.Deliverynotes).HasConstraintName("FK_deliverynotes_businesses");

            entity.HasOne(d => d.Ledger).WithMany(p => p.Deliverynotes).HasConstraintName("FK_deliverynotes_acc_ledgers");

            entity.HasOne(d => d.Sale).WithMany(p => p.Deliverynotes).HasConstraintName("FK_deliverynotes_sales");
        });

        modelBuilder.Entity<Deliverynotedetail>(entity =>
        {
            entity.ToTable("deliverynotedetails", tb => tb.HasTrigger("trSql_deliverynotedetails"));

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Deliverynote).WithMany(p => p.Deliverynotedetails).HasConstraintName("FK_deliverynotedetails_deliverynotes");

            entity.HasOne(d => d.Product).WithMany(p => p.Deliverynotedetails).HasConstraintName("FK_deliverynotedetails_products");
        });

        modelBuilder.Entity<Deliverynoteotherchargesdetail>(entity =>
        {
            entity.ToTable("deliverynoteotherchargesdetails", tb => tb.HasTrigger("trSql_deliverynoteotherchargesdetails"));

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Deliverynote).WithMany(p => p.Deliverynoteotherchargesdetails).HasConstraintName("FK_deliverynoteotherchargesdetails_deliverynotes");
        });

        modelBuilder.Entity<District>(entity =>
        {
            entity.ToTable("districts", tb => tb.HasTrigger("trSql_districts"));

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.HasOne(d => d.State).WithMany(p => p.Districts).HasConstraintName("FK_districts_states");
        });

        modelBuilder.Entity<Financialyear>(entity =>
        {
            entity.ToTable("financialyears", tb => tb.HasTrigger("trSql_financialyears"));

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Location>(entity =>
        {
            entity.ToTable("locations", tb => tb.HasTrigger("trSql_locations"));

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Business).WithMany(p => p.Locations).HasConstraintName("FK_locations_businesses");
        });

        modelBuilder.Entity<Menu>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_menus1");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Module>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_modules1");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Modulemenu>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_RoleMenuMapping");

            entity.ToTable("modulemenus", tb => tb.HasTrigger("trSql_ModuleMenus"));

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Menu).WithMany(p => p.Modulemenus).HasConstraintName("FK_modulemenus_menus");

            entity.HasOne(d => d.Module).WithMany(p => p.Modulemenus).HasConstraintName("FK_modulemenus_modules");
        });

        modelBuilder.Entity<Notice>(entity =>
        {
            entity.ToTable("notices", tb => tb.HasTrigger("trSql_notices"));

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_products1");

            entity.ToTable("products", tb => tb.HasTrigger("trSql_products"));

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Business).WithMany(p => p.Products).HasConstraintName("FK_products_businesses");

            entity.HasOne(d => d.Company).WithMany(p => p.Products).HasConstraintName("FK_products_companies");
        });

        modelBuilder.Entity<ProductGstrate>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Product).WithMany(p => p.ProductGstrates).HasConstraintName("FK_product_gstrates_products");
        });

        modelBuilder.Entity<Productlotwisestock>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_productlotwisestock1");

            entity.ToTable("productlotwisestock", tb => tb.HasTrigger("trSql_productlotwisestock"));

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Business).WithMany(p => p.Productlotwisestocks).HasConstraintName("FK_productlotwisestock_businesses");

            entity.HasOne(d => d.Pd).WithMany(p => p.Productlotwisestocks).HasConstraintName("FK_productlotwisestock_purchasedetails");

            entity.HasOne(d => d.Product).WithMany(p => p.Productlotwisestocks).HasConstraintName("FK_productlotwisestock_products");

            entity.HasOne(d => d.Purchase).WithMany(p => p.Productlotwisestocks).HasConstraintName("FK_productlotwisestock_purchases");

            entity.HasOne(d => d.Receiptnote).WithMany(p => p.Productlotwisestocks).HasConstraintName("FK_productlotwisestock_receiptnotes");

            entity.HasOne(d => d.Rnd).WithMany(p => p.Productlotwisestocks).HasConstraintName("FK_productlotwisestock_receiptnotedetails");
        });

        modelBuilder.Entity<Purchase>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_purchases1");

            entity.ToTable("purchases", tb => tb.HasTrigger("trSql_purchases"));

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Business).WithMany(p => p.Purchases).HasConstraintName("FK_purchases_businesses");

            entity.HasOne(d => d.Ledger).WithMany(p => p.Purchases).HasConstraintName("FK_purchases_acc_ledgers");

            entity.HasOne(d => d.Receiptnote).WithMany(p => p.Purchases).HasConstraintName("FK_purchases_receiptnotes");
        });

        modelBuilder.Entity<Purchasedetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_purchasedetails1");

            entity.ToTable("purchasedetails", tb => tb.HasTrigger("trSql_purchasedetails"));

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Product).WithMany(p => p.Purchasedetails).HasConstraintName("FK_purchasedetails_products");

            entity.HasOne(d => d.Purchase).WithMany(p => p.Purchasedetails).HasConstraintName("FK_purchasedetails_purchases");
        });

        modelBuilder.Entity<Purchaseotherchargesdetail>(entity =>
        {
            entity.ToTable("purchaseotherchargesdetails", tb => tb.HasTrigger("trSql_purchaseotherchargesdetails"));

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Purchase).WithMany(p => p.Purchaseotherchargesdetails).HasConstraintName("FK_purchaseotherchargesdetails_purchases");
        });

        modelBuilder.Entity<Purchasereturn>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_purchasereturns1_1");

            entity.ToTable("purchasereturns", tb => tb.HasTrigger("trSql_purchasereturns"));

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Purchasereturndetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_purchasereturndetails1");

            entity.ToTable("purchasereturndetails", tb => tb.HasTrigger("trSql_purchasereturndetails"));

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Purchasereturnotherchargesdetail>(entity =>
        {
            entity.ToTable("purchasereturnotherchargesdetails", tb => tb.HasTrigger("trSql_purchasereturnotherchargesdetails"));

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Receiptnote>(entity =>
        {
            entity.ToTable("receiptnotes", tb => tb.HasTrigger("trSql_receiptnotes"));

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Business).WithMany(p => p.Receiptnotes).HasConstraintName("FK_receiptnotes_businesses");

            entity.HasOne(d => d.Ledger).WithMany(p => p.Receiptnotes).HasConstraintName("FK_receiptnotes_acc_ledgers");

            entity.HasOne(d => d.Purchase).WithMany(p => p.Receiptnotes).HasConstraintName("FK_receiptnotes_purchases");
        });

        modelBuilder.Entity<Receiptnotedetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_receiptnotedetails1_1");

            entity.ToTable("receiptnotedetails", tb => tb.HasTrigger("trSql_receiptnotedetails"));

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Product).WithMany(p => p.Receiptnotedetails).HasConstraintName("FK_receiptnotedetails_products");

            entity.HasOne(d => d.Receiptnote).WithMany(p => p.Receiptnotedetails).HasConstraintName("FK_receiptnotedetails_receiptnotes");
        });

        modelBuilder.Entity<Receiptnoteotherchargesdetail>(entity =>
        {
            entity.ToTable("receiptnoteotherchargesdetails", tb => tb.HasTrigger("trSql_receiptnoteotherchargesdetails"));

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Receiptnote).WithMany(p => p.Receiptnoteotherchargesdetails).HasConstraintName("FK_receiptnoteotherchargesdetails_receiptnotes");
        });

        modelBuilder.Entity<Reminder>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Reminderfollowup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_reminderfollowups1");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Sale>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_sales1");

            entity.ToTable("sales", tb => tb.HasTrigger("trSql_sales"));

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Business).WithMany(p => p.Sales).HasConstraintName("FK_sales_businesses");

            entity.HasOne(d => d.Deliverynote).WithMany(p => p.Sales).HasConstraintName("FK_sales_debitnotes");

            entity.HasOne(d => d.Ledger).WithMany(p => p.Sales).HasConstraintName("FK_sales_acc_ledgers");
        });

        modelBuilder.Entity<Saledetail>(entity =>
        {
            entity.ToTable("saledetails", tb => tb.HasTrigger("trSql_saledetails"));

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Product).WithMany(p => p.Saledetails).HasConstraintName("FK_saledetails_products");

            entity.HasOne(d => d.Sale).WithMany(p => p.Saledetails).HasConstraintName("FK_saledetails_sales");
        });

        modelBuilder.Entity<Saleotherchargesdetail>(entity =>
        {
            entity.ToTable("saleotherchargesdetails", tb => tb.HasTrigger("trSql_saleotherchargesdetails"));

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Sale).WithMany(p => p.Saleotherchargesdetails).HasConstraintName("FK_saleotherchargesdetails_sales");
        });

        modelBuilder.Entity<Salereturn>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_salereturns1");

            entity.ToTable("salereturns", tb => tb.HasTrigger("trSql_salereturns"));

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Salereturndetail>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_salereturndetails1_1");

            entity.ToTable("salereturndetails", tb => tb.HasTrigger("trSql_salereturndetails"));

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Salereturnotherchargesdetail>(entity =>
        {
            entity.ToTable("salereturnotherchargesdetails", tb => tb.HasTrigger("trSql_salereturnotherchargesdetails"));

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<State>(entity =>
        {
            entity.ToTable("states", tb => tb.HasTrigger("trSql_states"));

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Stocktransferhistory>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Taluka>(entity =>
        {
            entity.ToTable("talukas", tb => tb.HasTrigger("trSql_talukas"));

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.HasOne(d => d.District).WithMany(p => p.Talukas).HasConstraintName("FK_talukas_districts");
        });

        modelBuilder.Entity<Trialtable>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Unit>(entity =>
        {
            entity.ToTable("units", tb => tb.HasTrigger("trSql_units"));

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_UserMaster");

            entity.ToTable("users", tb => tb.HasTrigger("trSql_UserMaster"));

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Business).WithMany(p => p.Users).HasConstraintName("FK_users_businesses");
        });

        modelBuilder.Entity<Usermodulemapping>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_rolemodulemapping");

            entity.ToTable("usermodulemapping", tb => tb.HasTrigger("trSql_usermodulemapping"));

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Fkmodule).WithMany(p => p.Usermodulemappings).HasConstraintName("FK_usermodulemapping_modules");

            entity.HasOne(d => d.Fkuser).WithMany(p => p.Usermodulemappings).HasConstraintName("FK_usermodulemapping_usermodulemapping");
        });

        modelBuilder.Entity<Village>(entity =>
        {
            entity.ToTable("villages", tb => tb.HasTrigger("trSql_villages"));

            entity.Property(e => e.Id).ValueGeneratedOnAdd();

            entity.HasOne(d => d.Business).WithMany(p => p.Villages).HasConstraintName("FK_villages_businesses");

            entity.HasOne(d => d.Taluka).WithMany(p => p.Villages).HasConstraintName("FK_villages_talukas");
        });

        modelBuilder.Entity<WebContactmessage>(entity =>
        {
            entity.ToTable("web_contactmessages", tb => tb.HasTrigger("trSql_web_contactmessages"));
        });

        modelBuilder.Entity<Wholesaletoreatailtransfer>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
