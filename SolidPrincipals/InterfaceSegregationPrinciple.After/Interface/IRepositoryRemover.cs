namespace InterfaceSegregationPrinciple.Before
{
    internal interface IRepositoryRemover<T>
    {
        Task DeleteAsync(int id);
    }
}
