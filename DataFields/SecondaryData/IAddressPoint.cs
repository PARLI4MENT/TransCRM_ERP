namespace DataFields.SecondaryData
{
    public interface IAddressPoint
    {
        /// <summary>Первичный ключ</summary>
        public Guid ID { get; }

        /// <summary>Адрес</summary>
        public string Address { get; set; }
    }
}