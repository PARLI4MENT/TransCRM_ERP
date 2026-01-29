using DataFields.Enums;
using DataFields.SecondaryData;
using System.ComponentModel.DataAnnotations;

namespace DataFields.MainData
{
    public class Required
    {
        ///<summary>
        ///Первичный ключ
        ///</summary>
        public Guid RequiredID { get; private set; }

        ///<summary>
        ///Номер заявки
        ///</summary>
        public required string RequestNumb { get; set; }

        /// <summary>
        /// Дата Заявки
        /// </summary>
        public DateOnly RequestDate { get; set; }

        /// <summary>
        /// Номер заявки доп. == NULL
        /// </summary>
        public string RequestNumbAdd { get; set; }

        ///<summary>
        ///Начальная стоимость заявки
        ///</summary>
        public double RequestCost { get; set; }

        /// <summary>
        /// Тип перевозки
        /// </summary>
        public required TypeTransportation TypeTransportation { get; set; }

        /// <summary>
        /// Массив маршрута
        /// </summary>
        public IDrivingRoute[] DrivingRoutes { get; set; }

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
        public List<Waybill> Waybills { get; set; }
        
        /// <summary>
        /// Поле Авто
        /// </summary>
        public Autotransport Autotransport {  get; set; }
    }
}