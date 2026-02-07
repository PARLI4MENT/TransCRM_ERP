using TransCRM_ERP.Entites.TechnicalData;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransCRM_ERP.Entites.MainData
{
    /// <summary>
    /// Данные водителя
    /// </summary>
    public class Driver : InfoDateTimeCreate
    {
        /// <summary>
        /// Первичный ключ
        /// </summary>
        [Key]
        public Guid DriverID { get; private set; }

        /// <summary>
        /// Фамилия
        /// </summary>
        public required string Surname { get; set; }

        /// <summary>
        /// Имя
        /// </summary>
        public required string Name { get; set; }

        /// <summary>
        /// Отчество (Необязательно)
        /// </summary>
        public required string Lastname { get; set; }

        /// <summary>
        /// Водительские права (Ссылка на класс)
        /// </summary>
        public DriverLicense? DriverLicense { get; set; }

        /// <summary>
        /// Паспорт (Ссылка на класс)
        /// </summary>
        public Passport? DriverPassport { get; set; }

        /// <summary>
        /// Номер телефона
        /// </summary>
        public long PhoneNumber { get; set; }

        /// <summary>
        /// Гражданство
        /// </summary>
        public string? Citizenship {  get; set; }

        public DateTime? InfoDateTimeCreate => throw new NotImplementedException();
    }
}