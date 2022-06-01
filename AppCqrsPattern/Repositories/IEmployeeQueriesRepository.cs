using AppCqrsPattern.Models;
namespace AppCqrsPattern.Repositories
{
    public interface IEmployeeQueriesRepository
    {
        Employee GetByID(int employeeID);
    }
}