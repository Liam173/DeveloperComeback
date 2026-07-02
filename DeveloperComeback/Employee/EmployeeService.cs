namespace DeveloperComeback.Services
{
    public class EmployeeService
    {
        private readonly EmployeeValidator _validator;
        private readonly EmployeeRepository _repository;
        private readonly EmployeeLogger _logger;
        private readonly EmployeeReportExporter _exporter;

        public EmployeeService(
            EmployeeValidator validator,
            EmployeeRepository repository,
            EmployeeLogger logger,
            EmployeeReportExporter exporter)
        {
            _validator = validator;
            _repository = repository;
            _logger = logger;
            _exporter = exporter;
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