namespace DataFields.SecondaryData
{
    /// <summary>
    /// Адрес
    /// </summary>
    public interface IAddressPoint
    {
        /// <summary>Первичный ключ</summary>
        public Guid AddressPointID { get; }

        /// <summary>Адрес</summary>
        public string Address { get; set; }
    }
}