using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Three.Models;
using ThreeApi.Repositories;

namespace ThreeApi.Controllers
{
    [Route("v1/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private readonly IDepartmentRepository _departmentRepository;

        public DepartmentsController(IDepartmentRepository departmentRepository)
        {
            this._departmentRepository = departmentRepository;
        }

        [HttpGet] // v1/Departments verb:GET
        public async Task<ActionResult<IEnumerable<Department>>> GetAll()
        {
            var departments = await _departmentRepository.GetAll();
            if (!departments.Any())
            {
                return NoContent();
            }

            return Ok(departments);
        }

        [HttpPost] // v1/Departments verb:POST
        public async Task<ActionResult<Department>> Add([FromBody]Department depart)
        {
            var added = await _departmentRepository.Add(depart);

            return Ok(added);
        }
    }
}
