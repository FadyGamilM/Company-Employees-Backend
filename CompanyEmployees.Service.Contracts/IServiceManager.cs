using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyEmployees.Service.Contracts;

public interface IServiceManager
{
    // UOW for all the services
    ICompanyService CompanyService { get; }
    IEmployeeService EmployeeService { get; }
}
