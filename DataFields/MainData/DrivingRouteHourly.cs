using DataFields.SecondaryData;

namespace DataFields.MainData
{
    ///<summary>
    ///Маршрут движения (почасовая)
    ///</summary>
    public class DrivingRouteHourly : IDrivingRoute
    {
        public Guid ID { get; private set; }

        public AddressPoint AddressLoading { get; set; }
        public DateTime DataLoading { get; set; }

        /// <summary>
        /// Дата погрузки факт (прибытие)
        /// </summary>
        public DateTime DataLoadingFact { get; set; }

        ///<summary>
        ///<inheritdoc cref="IDrivingRoute.AddressUnloading"/>
        /// (Всегда равен свойству AddressLoading)
        ///</summary>
        public AddressPoint AddressUnloading
        {
            get { return AddressLoading; }
            set { AddressLoading = value; }
        }

        public DateTime DateUnloading { get; set; }
        public DateTime DateUnloadingFact { get; set; }
        public bool AssignmentStatusTN { get; set; }

        public DateTime InfoDateTimeCreate { get; private set; } = DateTime.Now;
    }
}