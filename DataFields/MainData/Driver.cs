using DataFields.TechnicalData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFields.MainData
{
    /// <summary>
    /// Данные водителя
    /// </summary>
    public class Driver : IInfoDateTimeCreate
    {
        /// <summary>
        /// Первичный ключ
        /// </summary>
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
        public DriverLicense DriverLicense { get; set; }

        /// <summary>
        /// Паспорт (Ссылка на класс)
        /// </summary>
        public DriverPassport? DriverPassport { get; set; }

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