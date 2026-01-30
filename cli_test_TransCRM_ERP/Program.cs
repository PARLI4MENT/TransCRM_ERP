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
            TypeTransportation = DataFields.Enums.TypeTransportation.HourlyRate,
            RequestCost = 123,
            RequestDate = DateOnly.FromDateTime(DateTime.Now)
        };

        public static IDrivingRoute DrivingRoute { get; set; } = new DrivingRouteSimple
        {
            id
        };

        public static AddressPoint AddressPoint { get; set; } = new AddressPoint
        {
            ID = new Guid(),
        };
    }
}