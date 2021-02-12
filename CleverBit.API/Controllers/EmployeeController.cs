using CleverBit.API.Model;
using CleverBit.Core;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CleverBit.API.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly CleverBitDbContext _dBContext;
        public EmployeeController()
        {
            _dBContext = new CleverBitDbContext();
        }

        [HttpPost]
        [Route("api/employee")]
        public async Task Save(EmployeeModel employeeModel)
        {
            if (ModelState.IsValid)
            {
                var newEmployee = new Employee()
                {
                    Name = employeeModel.Name,
                    Surname = employeeModel.Surname,
                    RegionID = employeeModel.RegionID
                };
                _dBContext.Employees.Add(newEmployee);
                await _dBContext.SaveChangesAsync();
            }
        }
    }
}
