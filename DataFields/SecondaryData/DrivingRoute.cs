using TransCRM_ERP.Entites.MainData;
using TransCRM_ERP.Entites.TechnicalData;
using System.ComponentModel.DataAnnotations;

namespace TransCRM_ERP.Entites.SecondaryData
{
    ///<summary>
    ///Маршрут движения (abstract)
    ///</summary>
    public abstract class DrivingRoute : InfoDateTimeCreate
    {
        /// <summary>
        /// Первичный ключ
        /// </summary>
        [Key]
        public Guid DrivingRouteID { get; private set; }

        /// <summary>
        /// Адрес пункта погрузки
        /// </summary>
        public AddressPoint AddressLoading { get; set; }

        /// <summary>
        /// Дата погрузки
        /// </summary>
        public DateTime DataLoading { get; set; }

        /// <summary>
        /// Дата погрузки факт (прибытие)
        /// </summary>
        public DateTime? DataLoadingFact { get; set; }

        /// <summary>
        /// Адрес пункта выгрузки
        /// </summary>
        public AddressPoint AddressUnloading { get; set; }

        /// <summary>
        /// Дата выгрузки == погрузке
        /// </summary>
        public DateTime DateUnloading { get; set; }

        /// <summary>
        /// Дата выгрузки факт (убытие)
        /// </summary>
        public DateTime? DateUnloadingFact { get; set; }

        /// <summary>
        /// Статус присвоения к ТН (по умолчанию == false)
        /// </summary>
        public bool AssignmentStatusTN { get; set; }

        /// <summary>
        /// Внешний ключ => Таблица с Заявкой
        /// </summary>
        public Guid RequiredID { get; set; }

        /// <summary>
        /// Обратное свойство => Таблица с Заявкой
        /// </summary>
        public Required Required { get; set; }
    }
}