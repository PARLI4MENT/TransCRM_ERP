using DataFields.SecondaryData;
using System.ComponentModel.DataAnnotations;

namespace DataFields.MainData
{
    public class AddressPoint : IAddressPoint
    {
        /// <summary>Первичный ключ</summary>
        [Key]
        public Guid ID { get; private set; }

        /// <summary>Адрес</summary>
        public string Address { get; set; }
    }
}