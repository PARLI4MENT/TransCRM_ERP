using TransCRM_ERP.Entites.BaseData;
using TransCRM_ERP.Entites.SecondaryData;
using Microsoft.EntityFrameworkCore;

namespace cli_test_TransCRM_ERP
{
    public class AppDbContext : DbContext
    {
        /// <summary>
        /// DbSet<inheritdoc cref = "TransCRM_ERP.Entites.BaseData.Required" />
        /// </ summary >
        public DbSet<Required> Requireds { get; set; }

        /// <summary>
        /// DbSet<inheritdoc cref="TransCRM_ERP.Entites.BaseData.WaybillSimple"/>
        /// </summary>
        public DbSet<Waybill> Waybills { get; set; }

        /// <summary>
        /// DbSet<inheritdoc cref = "TransCRM_ERP.Entites.BaseData.AddressPoint" />
        /// </ summary >
        public DbSet<AddressPoint> AddressPoints { get; set; }

        /// <summary>
        /// DbSet<inheritdoc cref="TransCRM_ERP.Entites.BaseData.Autotransport"/>
        /// </summary>
        public DbSet<Autotransport> Autotransports { get; set; }

        /// <summary>
        /// DbSet<inheritdoc cref="TransCRM_ERP.Entites.BaseData.Driver"/>
        /// </summary>
        public DbSet<Driver> Drivers { get; set; }

        /// <summary>
        /// DbSet<inheritdoc cref="TransCRM_ERP.Entites.BaseData.DriverLicense"/>
        /// </summary>
        public DbSet<DriverLicense> DriverLicenses { get; set; }

        /// <summary>
        /// DbSet<inheritdoc cref="TransCRM_ERP.Entites.SecondaryData.DrivingRoute"/>
        /// </summary>
        public DbSet<DrivingRoute> DrivingRoutes { get; set; }

        /// <summary>
        /// DbSet<inheritdoc cref = "TransCRM_ERP.Entites.BaseData.DrivingRouteHourly" />
        /// </ summary >
        //public DbSet<DrivingRouteHourly> DrivingRouteHourlies { get; set; }

        /// <summary>
        /// DbSet<inheritdoc cref = "TransCRM_ERP.Entites.BaseData.DrivingRouteSimple" />
        /// </ summary >
        //public DbSet<DrivingRouteSimple> DrivingRouteSimples { get; set; }

        /// <summary>
        /// DbSet<inheritdoc cref="TransCRM_ERP.Entites.BaseData.Passport"/>
        /// </summary>
        public DbSet<Passport> Passports { get; set; }

        public AppDbContext() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite($"Data Source={Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "sqliteDb.db")}");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DrivingRoute>()
                .HasKey(key => key.DrivingRouteID);

            modelBuilder.Entity<DrivingRoute>()
                .HasOne(d => d.Required)
                .WithMany(req => req.DrivingRoutes)
                .HasForeignKey(key => key.RequiredID);

            modelBuilder.Entity<DrivingRouteHourly>();
            modelBuilder.Entity<DrivingRouteSimple>();
        }
    }
}