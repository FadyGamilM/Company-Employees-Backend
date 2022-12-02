using Microsoft.AspNetCore.Mvc;
using CompanyEmployees.Service.Contracts;


namespace CompanyEmployees.Presentation.Controllers;

[ApiController]
[Route("api/companies")]
public class CompaniesController : ControllerBase
{
    // inject the service manager to access the service layer
    private readonly IServiceManager _serviceManager;
    public CompaniesController(IServiceManager serviceManager) => _serviceManager = serviceManager;

    [HttpGet]
    public IActionResult GetAll()
    {
        try
        {
            var companies = _serviceManager.CompanyService.GetAllCompanies();
            return Ok(companies);   
        }
        catch(Exception ex)
        {
            return StatusCode(500, ex.Message.ToString());
        }
    }
}
