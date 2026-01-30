using Microsoft.EntityFrameworkCore;

namespace cli_test_TransCRM_ERP
{
    public class AppDbContext : DbContext
    {
        /// <summary>
        /// DbSet<inheritdoc cref="DataFields.MainData.Required"/>
        /// </summary>
        public DbSet<DataFields.MainData.Required> Requireds { get; set; }
        ///// <summary>
        ///// DbSet<inheritdoc cref="DataFields.MainData.Waybill"/>
        ///// </summary>
        //public DbSet<DataFields.MainData.Waybill> Waybills { get; set; }

        ///// <summary>
        ///// DbSet <inheritdoc cref="DataFields.MainData.AddressPoint"/>
        ///// </summary>
        //public DbSet<DataFields.MainData.AddressPoint> AddressPoints { get; set; }
        ///// <summary>
        ///// DbSet<inheritdoc cref="DataFields.MainData.Autotransport"/>
        ///// </summary>
        //public DbSet<DataFields.MainData.Autotransport> Autotransports { get; set; }
        ///// <summary>
        ///// DbSet<inheritdoc cref="DataFields.MainData.Driver"/>
        ///// </summary>
        //public DbSet<DataFields.MainData.Driver> Drivers { get; set; }
        ///// <summary>
        ///// DbSet<inheritdoc cref="DataFields.MainData.DriverLicense"/>
        ///// </summary>
        //public DbSet<DataFields.MainData.DriverLicense> DriverLicenses { get; set; }
        ///// <summary>
        ///// DbSet<inheritdoc cref="DataFields.MainData.DrivingRouteHourly"/>
        ///// </summary>
        //public DbSet<DataFields.MainData.DrivingRouteHourly> DrivingRouteHourlies { get; set; }
        ///// <summary>
        ///// DbSet<inheritdoc cref="DataFields.MainData.DrivingRouteSimple"/>
        ///// </summary>
        //public DbSet<DataFields.MainData.DrivingRouteSimple> DrivingRouteSimples { get; set; }
        ///// <summary>
        ///// DbSet<inheritdoc cref="DataFields.MainData.Passport"/>
        ///// </summary>
        //public DbSet<DataFields.MainData.Passport> Passports { get; set; }

        public AppDbContext() =>  Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite($"Data Source={Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "sqliteDb.db")}");
    }
}