using DataFields.SecondaryData;
using System.ComponentModel.DataAnnotations;

namespace DataFields.MainData
{
    /// <summary>
    /// <inheritdoc cref="IAddressPoint"/>
    /// </summary>
    public class AddressPoint : IAddressPoint
    {
        /// <summary>Первичный ключ</summary>
        [Key]
        public Guid AddressPointID { get; private set; }

        /// <summary>Адрес</summary>
        public required string Address { get; set; }
    }
}