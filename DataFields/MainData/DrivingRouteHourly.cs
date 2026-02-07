using TransCRM_ERP.Entites.SecondaryData;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TransCRM_ERP.Entites.MainData
{
    ///<summary>
    ///Маршрут движения (почасовая)
    ///</summary>
    public class DrivingRouteHourly : DrivingRoute
    {
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

        public Guid RequiredID { get; set; }
        public Required Required { get; set; }
        
        public DateTime? InfoDateTimeCreate { get; private set; } = DateTime.Now;
    }
}