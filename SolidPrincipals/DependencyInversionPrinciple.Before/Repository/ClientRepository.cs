using DependencyInversionPrinciple.Before.Model;

namespace DependencyInversionPrinciple.Before.Repository
{
    public class ClientRepository
    {
        public Task SaveAsync(Client model)
        {
            Console.WriteLine("Item saved");
            return Task.CompletedTask;
        }
    }
}
