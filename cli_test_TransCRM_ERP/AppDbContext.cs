using TransCRM_ERP.Entites.MainData;
using TransCRM_ERP.Entites.SecondaryData;
using Microsoft.EntityFrameworkCore;

namespace cli_test_TransCRM_ERP
{
    public class AppDbContext : DbContext
    {
        /// <summary>
        /// DbSet<inheritdoc cref = "TransCRM_ERP.Entites.MainData.Required" />
        /// </ summary >
        public DbSet<Required> Requireds { get; set; }

        /// <summary>
        /// DbSet<inheritdoc cref="TransCRM_ERP.Entites.MainData.WaybillSimple"/>
        /// </summary>
        public DbSet<Waybill> Waybills { get; set; }

        /// <summary>
        /// DbSet<inheritdoc cref = "TransCRM_ERP.Entites.MainData.AddressPoint" />
        /// </ summary >
        public DbSet<AddressPoint> AddressPoints { get; set; }

        /// <summary>
        /// DbSet<inheritdoc cref="TransCRM_ERP.Entites.MainData.Autotransport"/>
        /// </summary>
        public DbSet<Autotransport> Autotransports { get; set; }

        /// <summary>
        /// DbSet<inheritdoc cref="TransCRM_ERP.Entites.MainData.Driver"/>
        /// </summary>
        public DbSet<Driver> Drivers { get; set; }

        /// <summary>
        /// DbSet<inheritdoc cref="TransCRM_ERP.Entites.MainData.DriverLicense"/>
        /// </summary>
        public DbSet<DriverLicense> DriverLicenses { get; set; }

        /// <summary>
        /// DbSet<inheritdoc cref="TransCRM_ERP.Entites.SecondaryData.DrivingRoute"/>
        /// </summary>
        public DbSet<DrivingRoute> DrivingRoutes { get; set; }

        /// <summary>
        /// DbSet<inheritdoc cref = "TransCRM_ERP.Entites.MainData.DrivingRouteHourly" />
        /// </ summary >
        //public DbSet<DrivingRouteHourly> DrivingRouteHourlies { get; set; }

        /// <summary>
        /// DbSet<inheritdoc cref = "TransCRM_ERP.Entites.MainData.DrivingRouteSimple" />
        /// </ summary >
        //public DbSet<DrivingRouteSimple> DrivingRouteSimples { get; set; }

        /// <summary>
        /// DbSet<inheritdoc cref="TransCRM_ERP.Entites.MainData.Passport"/>
        /// </summary>
        public DbSet<Passport> Passports { get; set; }

        public AppDbContext() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite($"Data Source={Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "sqliteDb.db")}");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<DrivingRoute>()
            //    .HasDiscriminator<string>("DrivingRouteSimple")
            //    .HasValue<DrivingRouteSimple>("Simple");

            //modelBuilder.Entity<DrivingRoute>()
            //    .HasDiscriminator<string>("DrivingRouteHourly")
            //    .HasValue<DrivingRouteHourly>("Hourly");

            //modelBuilder.Entity<DrivingRoute>()
            //    .HasOne(w => w.Required)
            //    .WithMany(req => req.DrivingRoutes)
            //    .HasForeignKey(key => key.RequiredID);

            modelBuilder.Entity<DrivingRoute>()
                .HasKey(key => key.DrivingRouteID);

            modelBuilder.Entity<DrivingRoute>()
                .HasOne(d => d.Required)
                .WithMany(req => req.DrivingRoutes)
                .HasForeignKey(key => key.RequiredID);

            modelBuilder.Entity<DrivingRouteHourly>();
            modelBuilder.Entity<DrivingRouteSimple>();

            //modelBuilder.Entity<Waybill>()
            //    .HasOne(w => w.Required)
            //    .WithMany(r => r.Waybills)
            //    .HasForeignKey(k => k.RequiredID);
        }
    }
}