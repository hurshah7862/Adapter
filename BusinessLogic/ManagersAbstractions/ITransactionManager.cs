using BusinessLogic.ManagersAbstractions;
using BusinessLogic.Models;


namespace BusinessLogic.Managers
{
    internal interface ITransactionManager : IManager<Transaction>
    {
        Task<IEnumerable<Transaction>> GetBySourceDatabase(int SourceDatabaseId);
        Task<IEnumerable<Transaction>> GetByTargetDatabase(int TargetDatabaseId);
        Task<IEnumerable<Transaction>> GetByUser(int UserId);
        Task<IEnumerable<Transaction>> GetAllQueried();
    }
}
