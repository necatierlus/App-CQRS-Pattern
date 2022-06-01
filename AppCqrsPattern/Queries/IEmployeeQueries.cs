using AppCqrsPattern.Dtos;
namespace AppCqrsPattern.Queries
{
    public interface IEmployeeQueries
    {
        EmployeeDTO FindByID(int employeeID);
    }
}