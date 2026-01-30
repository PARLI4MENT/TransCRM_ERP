using DataFields.Enums;
using DataFields.SecondaryData;
using DataFields.TechnicalData;
using System.ComponentModel.DataAnnotations;

namespace DataFields.MainData
{
    /// <summary>
    /// Таблица с Заявкой
    /// </summary>
    public class Required : IInfoDateTimeCreate
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
        public string? RequestNumbAdd { get; set; }

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
        public List<IDrivingRoute>? DrivingRoutes { get; set; }

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
        //public List<Waybill>? Waybills { get; set; }
        
        /// <summary>
        /// Поле Авто
        /// </summary>
        public Autotransport? Autotransport {  get; set; }

        /// <summary>
        /// Поле Водитель
        /// </summary>
        public Driver? Driver { get; set; }

        //  ДОДЕЛАТЬ!!!
        /// <summary>
        /// Конечная стоимость заявки (по умолчанию == RequestCost, если заявка почасовая по умножается на количество часов)
        /// </summary>
        public double? RequestCostFinal { get; set; }

        /// <summary>
        /// Комментарий к заявке
        /// </summary>
        public string? Comment { get; set; }

        public DateTime? InfoDateTimeCreate { get; private set; } = DateTime.Now;
    }
}