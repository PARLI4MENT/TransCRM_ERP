using DataFields.SecondaryData;

namespace DataFields.MainData
{
    /// <summary>
    /// Маршрут движения (простой А=>Б)
    /// </summary>
    public class DrivingRouteSimple : IDrivingRoute
    {
        public Guid ID { get; private set; }

        public AddressPoint AddressLoading {  get; set; }
        public DateTime DataLoading {  get; set; }

        /// <summary>
        /// Дата погрузки факт (прибытие)
        /// </summary>
        public DateTime DataLoadingFact { get; set; }
        public AddressPoint AddressUnloading { get; set; }
        public DateTime DateUnloading { get; set; }
        public DateTime DateUnloadingFact { get; set; }
        public bool AssignmentStatusTN { get; set; }

        public DateTime InfoDateTimeCreate { get; private set; } = DateTime.Now;
    }
}