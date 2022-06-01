using AppCqrsPattern.Models;
namespace AppCqrsPattern.Repositories
{
    public interface IEmployeeCommandsRepository
    {
        void SaveEmployee(Employee employee);
    }
}
