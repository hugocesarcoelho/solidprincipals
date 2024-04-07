using InterfaceSegregationPrinciple.Before.Model;

namespace InterfaceSegregationPrinciple.Before.Repository
{
    public class EmployeeRepository : IRepositoryReader<Employee>
    {
        public async Task<Employee> GetByIdAsync(int id)
        {
            return new Employee();
        }
    }
}
