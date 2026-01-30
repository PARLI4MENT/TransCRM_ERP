using DataFields.Enums;
using DataFields.SecondaryData;
using System.ComponentModel.DataAnnotations;

namespace DataFields.MainData
{
    /// <summary>
    /// <inheritdoc cref="IWaybill"/> => Простая
    /// </summary>
    public class Waybill : IWaybill
    {
        [Key]
        public Guid WaybillID { get; private set; }

        public required Guid RequiredID { get; set; }
        public required TypeTransportation TypeTransportation { get; set; }
        public required string WaybillNumb { get; set; }
        public DateOnly? WaybillDate { get; set; }
        public float? Tons { get; set; }
        public uint? Pieces { get; set; }
        public IDrivingRoute? DrivingRoute { get; set; }
        public float? TonsLoadingFact { get; set; } = 0f;
        public uint? PiecesLoadingFact { get; set; }
        public float? TonsUnloadingFact { get; set; } = 0f;
        public uint? PiecesUnloadingFact { get; set; }

        public string? Comment { get; set; }
        public DateTime? InfoDateTimeCreate { get; private set; } = DateTime.Now;
    }
}