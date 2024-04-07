using DependencyInversionPrinciple.After.Repository;
using DependencyInversionPrinciple.Before.Model;

namespace DependencyInversionPrinciple.Before
{
    public class ClientService
    {
        private readonly IClientRepository _clientRepository;

        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public async Task Save(Client model)
        {
            await _clientRepository.SaveAsync(model);
        }
    }
}
