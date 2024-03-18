namespace RepairService.Context.Models
{
    public enum StatusType
    {
        /// <summary>
        /// В ожидании
        /// </summary>
        notComplete,
        /// <summary>
        /// В работе
        /// </summary>
        work,
        /// <summary>
        /// Выполнено
        /// </summary>
        complete,
    }
}