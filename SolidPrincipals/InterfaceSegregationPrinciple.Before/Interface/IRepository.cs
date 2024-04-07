namespace InterfaceSegregationPrinciple.Before.Interface
{
    internal interface IRepository<T>
    {
        Task SaveAsync(T model);
        Task UpdateAsync(int id, T model);
        Task<T> GetByIdAsync(int id);
        Task DeleteAsync(int id);
    }
}
