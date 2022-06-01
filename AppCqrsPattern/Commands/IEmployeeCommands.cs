using AppCqrsPattern.Models;
namespace AppCqrsPattern.Commands
{
    public interface IEmployeeCommands
    {
        void SaveEmployeeData(Employee employee);
    }
}