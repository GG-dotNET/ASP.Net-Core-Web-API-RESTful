using Entities.Models;

namespace Contracts;

public interface IEmployeeRepository
{
    IEnumerable<Employee> GetEmployees(Guid companyId, bool trackChanges);
    void CreateEmployeeForCompany(Guid companyId, Employee employee);
}