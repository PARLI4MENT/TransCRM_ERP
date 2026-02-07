using TransCRM_ERP.Entites.Enums;
using TransCRM_ERP.Entites.SecondaryData;
using TransCRM_ERP.Entites.TechnicalData;
using System.ComponentModel.DataAnnotations;

namespace TransCRM_ERP.Entites.MainData
{
    /// <summary>
    /// Таблица с Заявкой
    /// </summary>
    public class Required : InfoDateTimeCreate
    {
        ///<summary>
        ///Первичный ключ
        ///</summary>
        [Key]
        public Guid RequiredID { get; private set; }

        ///<summary>
        ///Номер заявки
        ///</summary>
        public required string RequestNumb { get; set; }

        /// <summary>
        /// Дата Заявки
        /// </summary>
        public required DateOnly RequestDate { get; set; }

        /// <summary>
        /// Номер заявки доп. == NULL
        /// </summary>
        public string RequestNumbAdd { get; set; }

        ///<summary>
        ///Начальная стоимость заявки
        ///</summary>
        public required double RequestCost { get; set; }

        /// <summary>
        /// Тип перевозки
        /// </summary>
        public required TypeTransportation TypeTransportation { get; set; }

        /// <summary>
        /// Массив маршрута
        /// </summary>
        public ICollection<DrivingRoute> DrivingRoutes { get; set; } = new List<DrivingRoute>();

        /// <summary>
        /// Статус заявки (по умолчанию = Новая перевозка)
        /// </summary>
        /// <remarks>
        /// Автоматически инициализируется значением RequestStatus.New
        /// </remarks>
        public RequestStatus RequestStatus { get; set; } = RequestStatus.New;

        /// <summary>
        /// Транспортные накладные
        /// </summary>
        public ICollection<Waybill> Waybills { get; set; } = new List<Waybill>();
        
        /// <summary>
        /// Поле Авто
        /// </summary>
        public Autotransport Autotransport {  get; set; }

        /// <summary>
        /// Поле Водитель
        /// </summary>
        public Driver Driver { get; set; }

        //  ДОДЕЛАТЬ!!!
        /// <summary>
        /// Конечная стоимость заявки (RequestCost * RequestCostCount)
        /// </summary>
        public double RequestCostFinal { get; set; }

        /// <summary>
        /// Комментарий к заявке
        /// </summary>
        public string Comment { get; set; }
    }
}