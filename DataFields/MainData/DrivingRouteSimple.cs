using TransCRM_ERP.Entites.SecondaryData;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TransCRM_ERP.Entites.MainData
{
    /// <summary>
    /// Маршрут движения (простой А=>Б)
    /// </summary>
    public class DrivingRouteSimple : DrivingRoute
    {
        public required AddressPoint AddressLoading {  get; set; }
        public required DateTime DataLoading {  get; set; }
        public DateTime? DataLoadingFact { get; set; }

        public required AddressPoint AddressUnloading { get; set; }
        public required DateTime DateUnloading { get; set; }
        public DateTime? DateUnloadingFact { get; set; }

        public bool AssignmentStatusTN { get; set; } = false;

        public Guid RequiredID {  get; set; }
        public Required Required {  get; set; }

        public DateTime? InfoDateTimeCreate { get; private set; } = DateTime.Now;
    }
}