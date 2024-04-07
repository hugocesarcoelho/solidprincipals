namespace InterfaceSegregationPrinciple.Before
{
    internal interface IRepositoryReader<T>
    {
        Task<T> GetByIdAsync(int id);
    }
}
