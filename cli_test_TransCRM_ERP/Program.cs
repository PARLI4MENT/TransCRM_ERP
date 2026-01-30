using DataFields.MainData;
using DataFields.SecondaryData;
using Microsoft.EntityFrameworkCore;

namespace cli_test_TransCRM_ERP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var db = new AppDbContext())
            {
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();

                db.Requireds.Add(RequiredTest);
                db.SaveChanges();
                db.Database.CloseConnection();
                Console.WriteLine("Done!");
            }

            Console.ReadKey();
        }

        public static Required RequiredTest { get; set; } = new DataFields.MainData.Required
        {
            RequestNumb = "adwaww",
            RequestDate = DateOnly.FromDateTime(DateTime.Now),
            RequestCost = 12000d,
            TypeTransportation = DataFields.Enums.TypeTransportation.RegularTransportation,
        };

        public static IDrivingRoute DrivingRoute { get; set; } = new DrivingRouteSimple
        {
            AddressLoading = AddressPoint,
            DataLoading = DateTime.Now,
            AddressUnloading = AddressPoint,
            DateUnloading = new DateTime(1999, 1, 2)
        };

        public static AddressPoint AddressPoint { get; set; } = new AddressPoint { Address = "Test address!" };
    }
}