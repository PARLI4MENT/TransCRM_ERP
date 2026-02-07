using TransCRM_ERP.Entites.MainData;
using TransCRM_ERP.Entites.SecondaryData;
using Microsoft.EntityFrameworkCore;

namespace cli_test_TransCRM_ERP
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            using (var db = new AppDbContext())
            {
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();

                db.Add(drv1);

                db.SaveChanges();
                db.Database.CloseConnection();
                Console.WriteLine("Done!");
            }

            //WipeCreateSeed(false);

            Console.ReadKey();
        }

        //public static bool WipeCreateSeed(bool onlyIfNotDatabase)
        //{
        //    using (var db = new AppDbContext())
        //    {
        //        if (onlyIfNotDatabase && (db.GetService<IDatabaseCreator>() as RelationalDatabaseCreator).Exists())
        //            return true;

        //        db.Database.EnsureDeleted();
        //        db.Database.EnsureCreated();

        //        if (!db.Requireds.Any())
        //        {
        //            WriteTestData(db);
        //            Console.WriteLine("Seeded database!");
        //        }

        //        db.Database.CloseConnection();
        //    }
        //    return true;
        //}

        //public static void WriteTestData(this AppDbContext db)
        //{
        //    var RequiredTest = new Required
        //    {
        //        RequestNumb = $"ReqTest{DateOnly.FromDateTime(DateTime.Now)}",
        //        RequestDate = DateOnly.FromDateTime(DateTime.Now),
        //        RequestCost = 12000d,
        //        TypeTransportation = DataFields.Enums.TypeTransportation.RegularTransportation,
        //        DrivingRoutes = new List<DrivingRoute> { DrivingRouteTest },
        //        RequestStatus = DataFields.Enums.RequestStatus.Completed,
        //        Autotransport = AutotransportTest,
        //        Driver = DriverTest,
        //        RequestCostFinal = 1
        //    };
        //}

        public static Required RequiredTest { get; set; } = new Required
        {
            RequestNumb = "adwaww",
            RequestDate = DateOnly.FromDateTime(DateTime.Now),
            RequestCost = 12000d,
            TypeTransportation = TransCRM_ERP.Entites.Enums.TypeTransportation.RegularTransportation,
            DrivingRoutes = new List<DrivingRoute>
            {

                new DrivingRouteHourly
                {
                    AddressLoading = AddressPoint,
                    DataLoading = DateTime.Now,
                    AddressUnloading = AddressPoint,
                    DateUnloading = DateTime.Now,
                    Required = RequiredTest
                },
                new DrivingRouteHourly
                {
                    AddressLoading = AddressPoint,
                    DataLoading = DateTime.Now,
                    AddressUnloading = AddressPoint,
                    DateUnloading = DateTime.Now,
                    Required = RequiredTest
                }
            },
            RequestStatus = TransCRM_ERP.Entites.Enums.RequestStatus.Completed,
            Autotransport = AutotransportTest,
            Driver = DriverTest,
            RequestCostFinal = 1
        };

        public static DrivingRouteHourly drv1 { get; set; } = new DrivingRouteHourly
        {
            AddressLoading = AddressPoint,
            DataLoading = DateTime.Now,
            AddressUnloading = AddressPoint,
            DateUnloading = DateTime.Now,

            Required = RequiredTest
        };

        public static AddressPoint AddressPoint { get; set; } = new AddressPoint
        {
            Address = "Test address!"
        };

        public static Autotransport AutotransportTest { get; set; } = new Autotransport
        {
            TypeTransport = TransCRM_ERP.Entites.Enums.TypeTransport.SingleCar,
            AutobodyType = TransCRM_ERP.Entites.Enums.AutobodyType.Manipulator,
            CarBrand = "Toyota",
            CarModel = "Toyoace",
            CarRegNumber = "O123AM",
            RegionNumber = 123,
            Lifting = 1.5f
        };

        public static Driver DriverTest { get; set; } = new Driver
        {
            Surname = "SurnameTest",
            Name = "NameTest",
            Lastname = "LastnameTest"
        };
    }
}