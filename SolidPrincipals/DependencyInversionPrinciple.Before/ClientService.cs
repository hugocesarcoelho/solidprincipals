using DependencyInversionPrinciple.Before.Model;
using DependencyInversionPrinciple.Before.Repository;

namespace DependencyInversionPrinciple.Before
{
    public class ClientService
    {
        private readonly ClientRepository _clientRepository;

        public ClientService()
        {
            _clientRepository = new ClientRepository();
        }

        public async Task Save(Client model)
        {
            await _clientRepository.SaveAsync(model);
        }
    }
}
