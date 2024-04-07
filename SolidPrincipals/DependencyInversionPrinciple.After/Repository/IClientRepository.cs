using DependencyInversionPrinciple.Before.Model;

namespace DependencyInversionPrinciple.After.Repository
{
    public interface IClientRepository
    {
        Task SaveAsync(Client model);
    }
}
