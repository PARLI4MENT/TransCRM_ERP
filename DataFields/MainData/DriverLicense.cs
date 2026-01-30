using System.ComponentModel.DataAnnotations;

namespace DataFields.MainData
{
    /// <summary>
    /// Данные водительское удостоверение
    /// </summary>
    public class DriverLicense
    {
        /// <summary>
        /// Первичный ключ
        /// </summary>
        [Key]
        public Guid DriverLicenseID { get; private set; }

        /// <summary>
        /// Серия
        /// </summary>
        public required short SeriesLicence { get; set; }

        /// <summary>
        /// Номер
        /// </summary>
        public required int NumberLicence { get; set; }

        /// <summary>
        /// Дата выдачи
        /// </summary>
        public required DateOnly DateIssue { get; set; }

        /// <summary>
        /// Дата окончания действия
        /// </summary>
        public required DateOnly DateEnd { get; set; }
    }
}