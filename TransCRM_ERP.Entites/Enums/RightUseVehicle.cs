namespace TransCRM_ERP.Entites.Enums
{
    public enum RightUseVehicle : int
    {
        /// <summary>
        /// Собственность
        /// </summary>
        Own = 1,

        /// <summary>
        /// Безвозмездное пользование
        /// </summary>
        FreeUse,

        /// <summary>
        /// Совместная собственность супругов
        /// </summary>
        JointPropertySpouses,

        /// <summary>
        /// Аренда
        /// </summary>
        Rent,

        /// <summary>
        /// Лизинг
        /// </summary>
        Leasing,

        /// <summary>
        /// Экспедирование
        /// </summary>
        Forwarding
    }
}