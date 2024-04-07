namespace InterfaceSegregationPrinciple.Before
{
    internal interface IRepositoryWriter<T>
    {
        Task SaveAsync(T model);
        Task UpdateAsync(int id, T model);
    }
}
