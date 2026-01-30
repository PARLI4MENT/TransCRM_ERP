using System.ComponentModel.DataAnnotations;

namespace DataFields.MainData
{
    /// <summary>
    /// Паспорт
    /// </summary>
    public class Passport
    {
        /// <summary>
        /// Первичный ключ
        /// </summary>
        [Key]
        public Guid PassportID { get; private set; }

        /// <summary>
        /// Серия
        /// </summary>
        public required short SeriesPassport {  get; set; }
        
        /// <summary>
        /// Номер
        /// </summary>
        public required short NumberPassport { get; set; }

        /// <summary>
        /// Дата выдачи
        /// </summary>
        public required DateOnly DateIssue { get; set; }

        /// <summary>
        /// Код подразделения
        /// </summary>
        public required int DepartmentCode { get; set; }

        /// <summary>
        /// Кем выдан
        /// </summary>
        public required string IssuedBy { get; set; }

        /// <summary>
        /// Пол
        /// </summary>
        public required string Gender { get; set; }

        /// <summary>
        /// Дата рождения
        /// </summary>
        public required DateOnly Birthdate { get; set; }

        /// <summary>
        /// Место рождения
        /// </summary>
        public required string Birthplace { get; set; }
    }
}