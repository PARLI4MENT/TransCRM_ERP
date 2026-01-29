using DataFields.SecondaryData;

namespace DataFields.MainData
{
    ///<summary>
    ///Маршрут движения (почасовая)
    ///</summary>
    public class DrivingRouteHourly : IDrivingRoute
    {
        public Guid ID { get; private set; }

        public required AddressPoint AddressLoading { get; set; }
        public required DateTime DataLoading { get; set; }
        public DateTime? DataLoadingFact { get; set; }

        ///<summary>
        ///<inheritdoc cref="IDrivingRoute.AddressUnloading"/>
        /// (Всегда равен свойству AddressLoading)
        ///</summary>
        public required AddressPoint AddressUnloading { get { return AddressLoading; } set { AddressLoading = value; } }
        public required DateTime DateUnloading { get; set; }
        public DateTime? DateUnloadingFact { get; set; }

        public bool AssignmentStatusTN { get; set; } = false;

        public DateTime? InfoDateTimeCreate { get; private set; } = DateTime.Now;
    }
}