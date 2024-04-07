namespace InterfaceSegregationPrinciple.Before
{
    internal interface IRepository<T> : IRepositoryReader<T>, IRepositoryWriter<T>, IRepositoryRemover<T>
    {
    }
}
