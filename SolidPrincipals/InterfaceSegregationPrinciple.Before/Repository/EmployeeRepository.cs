using InterfaceSegregationPrinciple.Before.Interface;
using InterfaceSegregationPrinciple.Before.Model;

namespace InterfaceSegregationPrinciple.Before.Repository
{
    public class EmployeeRepository : IRepository<Employee>
    {
        public async Task<Employee> GetByIdAsync(int id)
        {
            return new Employee();
        }


        // non used methods - breaks the LSP

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task SaveAsync(Employee model)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(int id, Employee model)
        {
            throw new NotImplementedException();
        }
    }
}
