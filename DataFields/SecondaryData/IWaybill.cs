using DataFields.Enums;
using DataFields.MainData;
using DataFields.TechnicalData;
using System.ComponentModel;

namespace DataFields.SecondaryData
{
    /// <summary>
    /// Транспортная накладная
    /// </summary>
    public interface IWaybill : IInfoDateTimeCreate
    {
        /// <summary>
        /// Первичный ключ
        /// </summary>
        public Guid ID { get; }

        /// <summary>
        /// ID Заявки
        /// </summary>
        public string RequestID { get; set; }

        /// <summary>
        /// Тип перевозки
        /// </summary>
        public TypeTransportation TypeTransportation { get; set; }

        /// <summary>
        /// Номер ТН
        /// </summary>
        public string WaybillNumb { get; set; }

        /// <summary>
        /// Дата ТН (Дата документа)
        /// </summary>
        public DateOnly WaybillDate { get; set; }

        /// <summary>
        /// Тоннаж
        /// </summary>
        public float Tons { get; set; }

        /// <summary>
        /// Кол-во грузовых мест
        /// </summary>
        public uint? Pieces { get; set; }

        /// <summary>
        /// Маршрут
        /// </summary>
        public IDrivingRoute DrivingRoute { get; set; }

        /* ПОКА НЕ НУЖНО
        /// <summary>
        /// Поле Водитель (Автоприсваивание из Заявки)
        /// </summary>
        ///public Driver Driver { get; set; }

        ///<summary>
        ///Поле Авто (Автоприсваивание из Заявки)
        ///</summary>
        ///public Autotransport Autotransport { get; set; }
        */

        ///<summary>
        ///Тоннаж погрузка (факт) 0 == без факта взвешивания
        ///</summary>
        public float TonsLoadingFact { get; set; }

        /// <summary>
        /// Кол-во мест погрузка (факт)
        /// </summary>
        public uint PiecesLoadingFact { get; set; }

        /// <summary>
        /// Тоннаж разгрузка (факт) 0 == без факта взвешивания
        /// </summary>
        public float TonsUnloadingFact { get; set; }

        /// <summary>
        /// Кол-во мест разгрузка (факт)
        /// </summary>
        public uint PiecesUnloadingFact { get; set; }

        /// <summary>
        /// Комментарий
        /// </summary>
        public string? Comment { get; set; }
    }
}