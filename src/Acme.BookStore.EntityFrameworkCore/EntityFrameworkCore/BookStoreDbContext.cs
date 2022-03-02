using Acme.BookStore.Books;
using Acme.BookStore.Departments;
using Acme.BookStore.Parties;
using Acme.BookStore.UserAccounts;
using Acme.BookStore.UserProfiles;
using Acme.BookStore.UserTransactions;
using Acme.BookStore.UserTypes;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.BackgroundJobs.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.Identity;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.IdentityServer.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.TenantManagement;
using Volo.Abp.TenantManagement.EntityFrameworkCore;

namespace Acme.BookStore.EntityFrameworkCore;

[ReplaceDbContext(typeof(IIdentityDbContext))]
[ReplaceDbContext(typeof(ITenantManagementDbContext))]
[ConnectionStringName("Default")]
public class BookStoreDbContext :
    AbpDbContext<BookStoreDbContext>,
    IIdentityDbContext,
    ITenantManagementDbContext
{
    /* Add DbSet properties for your Aggregate Roots / Entities here. */

  

    #region Entities from the modules

    /* Notice: We only implemented IIdentityDbContext and ITenantManagementDbContext
     * and replaced them for this DbContext. This allows you to perform JOIN
     * queries for the entities of these modules over the repositories easily. You
     * typically don't need that for other modules. But, if you need, you can
     * implement the DbContext interface of the needed module and use ReplaceDbContext
     * attribute just like IIdentityDbContext and ITenantManagementDbContext.
     *
     * More info: Replacing a DbContext of a module ensures that the related module
     * uses this DbContext on runtime. Otherwise, it will use its own DbContext class.
     */

    //Identity
    public DbSet<IdentityUser> Users { get; set; }
    public DbSet<IdentityRole> Roles { get; set; }
    public DbSet<IdentityClaimType> ClaimTypes { get; set; }
    public DbSet<OrganizationUnit> OrganizationUnits { get; set; }
    public DbSet<IdentitySecurityLog> SecurityLogs { get; set; }
    public DbSet<IdentityLinkUser> LinkUsers { get; set; }

    // Tenant Management
    public DbSet<Tenant> Tenants { get; set; }
    public DbSet<TenantConnectionString> TenantConnectionStrings { get; set; }
    public DbSet<Book> Books { get; set; }

    public DbSet<UserType> UserTypes { get; set; }

    public DbSet<Party> Parties { get; set; }

    public DbSet<Department> Departments { get; set; }

    public DbSet<UserProfile> UserProfiles { get; set; }

    public DbSet<UserAccount> UserAccounts { get; set; }

    public DbSet<UserTransaction> UserTransactions { get; set; }
    #endregion

    public BookStoreDbContext(DbContextOptions<BookStoreDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        /* Include modules to your migration db context */

        builder.ConfigurePermissionManagement();
        builder.ConfigureSettingManagement();
        builder.ConfigureBackgroundJobs();
        builder.ConfigureAuditLogging();
        builder.ConfigureIdentity();
        builder.ConfigureIdentityServer();
        builder.ConfigureFeatureManagement();
        builder.ConfigureTenantManagement();

        /* Configure your own tables/entities inside here */

        //builder.Entity<YourEntity>(b =>
        //{
        //    b.ToTable(BookStoreConsts.DbTablePrefix + "YourEntities", BookStoreConsts.DbSchema);
        //    b.ConfigureByConvention(); //auto configure for the base class props
        //    //...
        //});

        builder.Entity<UserType>(b =>
        {
            b.ToTable(BookStoreConsts.DbTablePrefix + "UserTypes", BookStoreConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props

            b.Property(x => x.Name).IsRequired().HasMaxLength(100);
            b.Property(x => x.Code).IsRequired().HasMaxLength(100);
           // b.HasIndex(x => x.Name).IsUnique();

        });

        builder.Entity<Party>(b =>
        {
            b.ToTable(BookStoreConsts.DbTablePrefix + "Parties", BookStoreConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props

            b.Property(x => x.Name).IsRequired().HasMaxLength(100);
            b.Property(x => x.Code).IsRequired().HasMaxLength(12);
           
            // b.HasIndex(x => x.Name).IsUnique();

        });

        builder.Entity<UserProfile>(b =>
        {
            b.ToTable(BookStoreConsts.DbTablePrefix + "UserProfiles", BookStoreConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props

            b.Property(x => x.Name).IsRequired().HasMaxLength(100);
            b.Property(x => x.Age).IsRequired().HasMaxLength(3);
            b.Property(x => x.Address).IsRequired().HasMaxLength(100);

            b.HasIndex(x => x.Name).IsUnique();
          

        });
        builder.Entity<UserAccount>(b =>
        {
            b.ToTable(BookStoreConsts.DbTablePrefix + "UserAccounts", BookStoreConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props

            b.Property(x => x.BankName).IsRequired().HasMaxLength(100);
            b.Property(x => x.ActNumber).IsRequired().HasMaxLength(18);
            b.Property(x => x.UserName).IsRequired().HasMaxLength(100);

            b.HasIndex(x => x.BankName).IsUnique();
            b.HasOne(b => b.UserProfile).WithMany(a => a.UserAccounts).HasForeignKey(z => z.UserID).IsRequired();
            b.HasOne(b => b.UserTransaction).WithMany(a => a.UserAccounts).HasForeignKey(z => z.UserTransactionID).IsRequired();
        });
        builder.Entity<UserTransaction>(b =>
        {
            b.ToTable(BookStoreConsts.DbTablePrefix + "UserTransactions", BookStoreConsts.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props
            //b.HasOne(b => b.UserProfile).WithMany(a => a.UserAccounts).HasForeignKey(z => z.UserID).IsRequired();

        });
    }
}
