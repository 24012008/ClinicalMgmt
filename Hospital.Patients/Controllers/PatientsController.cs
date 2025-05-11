using Hospital.Patients.DBContext;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Hospital.Patients.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientsController : ControllerBase
    {
        [HttpGet(Name = "GetPatients")]
        public IEnumerable<Patient> Get()
        {
            return null;
        }
    }
}
