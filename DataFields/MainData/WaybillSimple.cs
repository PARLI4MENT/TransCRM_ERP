using TransCRM_ERP.Entites.Enums;
using TransCRM_ERP.Entites.SecondaryData;
using System.ComponentModel.DataAnnotations;

namespace TransCRM_ERP.Entites.MainData
{
    /// <summary>
    /// <inheritdoc cref="IWaybill"/> => Простая
    /// </summary>
    public class WaybillSimple : Waybill
    {
        [Key]
        public Guid WaybillID { get; private set; }

        public required TypeTransportation TypeTransportation { get; set; }
        public required string WaybillNumb { get; set; }
        public DateOnly? WaybillDate { get; set; }
        public float? Tons { get; set; }
        public uint? Pieces { get; set; }
        public List<DrivingRoute>? DrivingRoute { get; set; }
        public float? TonsLoadingFact { get; set; } = 0f;
        public uint? PiecesLoadingFact { get; set; }
        public float? TonsUnloadingFact { get; set; } = 0f;
        public uint? PiecesUnloadingFact { get; set; }

        /// <summary>
        /// Таблица с Заявкой => Внешний ключ
        /// </summary>
        public required Guid RequiredID { get; set; }
        /// <summary>
        /// Таблица с Заявкой => Обратное свойство
        /// </summary>
        public Required Required { get; set; }

        public string? Comment { get; set; }
    }
}