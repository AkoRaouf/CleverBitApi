using CleverBit.API.Model;
using CleverBit.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleverBit.API.Controllers
{
    [ApiController]
    public class RegionController : ControllerBase
    {
        private readonly CleverBitDbContext _dBContext;
        public RegionController()
        {
            _dBContext = new CleverBitDbContext();
        }

        [Route("api/region/{id}/employees")]
        public async Task<List<EmployeeListModel>> GetEmployeesByDepartmentID(int id)
        {
            return await _dBContext.Employees
                .Where(x => x.RegionID >= id).
                Select(y => new EmployeeListModel()
                {
                    Name = y.Name,
                    Surname = y.Surname,
                    RegionName = y.Region.Name,
                })
                .ToListAsync();
        }

        [HttpPost]
        [Route("api/region")]
        public async Task Save(RegionModel regionModel)
        {
            if (ModelState.IsValid)
            {
                var newRegion = new Region()
                {
                    Name = regionModel.Name,
                    ParentRegionID = regionModel.ParentRegionID
                };
                _dBContext.Regions.Add(newRegion);
                await _dBContext.SaveChangesAsync();
            }
        }
    }
}
