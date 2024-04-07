using InterfaceSegregationPrinciple.Before.Model;

namespace InterfaceSegregationPrinciple.Before.Repository
{
    public class ClientRepository : IRepository<Client>
    {
        public Task DeleteAsync(int id)
        {
            Console.WriteLine("Item deleted");
            return Task.CompletedTask;
        }

        public async Task<Client> GetByIdAsync(int id)
        {
            return new Client();
        }

        public Task SaveAsync(Client model)
        {
            Console.WriteLine("Item saved");
            return Task.CompletedTask;
        }

        public Task UpdateAsync(int id, Client model)
        {
            Console.WriteLine("Item updated");
            return Task.CompletedTask;
        }
    }
}
