using Microsoft.AspNetCore.Mvc;
using JWT_JSON_WEB_TOCKEN_.Models;
using JWT_JSON_WEB_TOCKEN_.Services;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JWT_JSON_WEB_TOCKEN_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IEmployeeService service;

        public EmployeeController(IEmployeeService service)
        {
            this.service = service;
        }


        // GET: api/Employee/GetEmployees   --->if we didn't use route it will take method name in url 
        // GET: api/Employee/GetEmployees
        [HttpGet]
        [Authorize(Roles = "Admin")]
        [Route("GetEmployees")]
        public IActionResult Get()
        {
            try
            {
                var model = service.GetEmployees();
                if (model != null)
                    return new ObjectResult(model);
                else
                    return StatusCode(StatusCodes.Status204NoContent);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        [Route("GetEmployeeById/{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                var model = service.GetEmployeeById(id);
                if (model != null)
                    return new ObjectResult(model);
                else
                    return StatusCode(StatusCodes.Status204NoContent);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }

        }

        // POST api/<EmployeeController>
        [HttpPost]
        [Route("AddEmployee")]
        public IActionResult Post([FromBody] Employee emp)
        {
            try
            {
                var model = service.AddEmployee(emp);
                if (model >= 1)
                    return StatusCode(StatusCodes.Status201Created);
                else
                    return StatusCode(StatusCodes.Status400BadRequest);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }


        // PUT api/<EmployeeController>/5
        [HttpPut]
        [Route("EditEmployee")]
        public IActionResult Put([FromBody] Employee emp)
        {
            try
            {
                var model = service.UpdateEmployee(emp);
                if (model >= 1)
                    return StatusCode(StatusCodes.Status200OK);
                else
                    return StatusCode(StatusCodes.Status400BadRequest);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }


        // DELETE api/<EmployeeController>/5
        [HttpDelete]
        [Route("DeleteEmployee/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                var model = service.DeleteEmployee(id);
                if (model >= 1)
                    return StatusCode(StatusCodes.Status200OK);
                else
                    return StatusCode(StatusCodes.Status400BadRequest);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }

    }
}
