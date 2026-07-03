using DeveloperComeback.Interfaces;

namespace DeveloperComeback.Services
{
    public class EmployeeService
    {
        private readonly EmployeeValidator _validator;
        private readonly EmployeeLogger _logger;
        private readonly EmployeeReportExporter _exporter;

        private readonly IEmployeeRepository _repository;

        public EmployeeService(
            EmployeeValidator validator,
            EmployeeLogger logger,
            EmployeeReportExporter exporter,
            IEmployeeRepository repository)
        {
            _validator = validator;
            _logger = logger;
            _exporter = exporter;
            _repository = repository;
        }

        public void RegisterEmployee(Employee employee)
        {
            if (!_validator.Validate(employee))
            {
                return;
            }

            _repository.Save(employee);

            _logger.Log(employee);

            _exporter.Export(employee);
        }
    }
}