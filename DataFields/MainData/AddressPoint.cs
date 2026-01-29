using DataFields.SecondaryData;

namespace DataFields.MainData
{
    public class AddressPoint : IAddressPoint
    {
        /// <summary>Первичный ключ</summary>
        public Guid ID { get; private set; }

        /// <summary>Адрес</summary>
        public string Address { get; set; }
    }
}