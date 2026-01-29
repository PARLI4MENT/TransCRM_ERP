using DataFields.Enums;
using DataFields.SecondaryData;
using DataFields.TechnicalData;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataFields.MainData
{
    /// <summary>
    /// <inheritdoc cref="IWaybill"/> => Простая
    /// </summary>
    //[NotMapped] // Запрет на создание таблицы
    public class Waybill : IWaybill
    {
        public Guid ID { get; private set; }
        public required string RequestID { get; set; }
        public required TypeTransportation TypeTransportation { get; set; }
        public required string WaybillNumb { get; set; }
        public DateOnly WaybillDate {  get; set; }
        public float Tons { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public uint? Pieces { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IDrivingRoute DrivingRoute { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public float TonsLoadingFact { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public uint PiecesLoadingFact { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public float TonsUnloadingFact { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public uint PiecesUnloadingFact { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string? Comment { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public DateTime InfoDateTimeCreate { get; private set; } = DateTime.Now;
    }
}