using DataFields.SecondaryData;
using System.ComponentModel.DataAnnotations;

namespace DataFields.MainData
{
    /// <summary>
    /// Маршрут движения (простой А=>Б)
    /// </summary>
    public class DrivingRouteSimple : IDrivingRoute
    {
        [Key]
        public Guid ID { get; private set; }

        public required AddressPoint AddressLoading {  get; set; }
        public required DateTime DataLoading {  get; set; }
        public DateTime? DataLoadingFact { get; set; }

        public required AddressPoint AddressUnloading { get; set; }
        public required DateTime DateUnloading { get; set; }
        public DateTime? DateUnloadingFact { get; set; }

        public bool AssignmentStatusTN { get; set; } = false;

        public DateTime InfoDateTimeCreate { get; private set; } = DateTime.Now;
    }
}