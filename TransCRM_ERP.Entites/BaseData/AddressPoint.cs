using TransCRM_ERP.Entites.SecondaryData;
using System.ComponentModel.DataAnnotations;

namespace TransCRM_ERP.Entites.BaseData
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