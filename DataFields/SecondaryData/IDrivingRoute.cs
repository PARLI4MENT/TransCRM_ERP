using DataFields.MainData;
using DataFields.TechnicalData;
using System.ComponentModel.DataAnnotations;

namespace DataFields.SecondaryData
{
    public interface IDrivingRoute : IInfoDateTimeCreate
    {
        /// <summary>
        /// Первичный ключ
        /// </summary>
        [Key]
        public Guid ID { get; }

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
    }
}