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
        public Guid DriverLicenseID { get; private set; }

        /// <summary>
        /// Серия
        /// </summary>
        public required short SeriesLicence { get; set; }

        /// <summary>
        /// Номер
        /// </summary>
        public int NumberLicence { get; set; }

        /// <summary>
        /// Дата выдачи
        /// </summary>
        public DateOnly DateIssue { get; set; }

        /// <summary>
        /// Дата окончания действия
        /// </summary>
        public DateOnly DateEnd { get; set; }
    }
}