using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoanTrackerController : ControllerBase
    {
        public HOMELOANprojectContext db;
        public LoanTrackerController(HOMELOANprojectContext _db)
        {
            db = _db;
        }
        //public IActionResult GetAll()
        //{
        //    return Ok(db.LoanRequest);
        //}

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var x = db.LoanRequest.Where(x => x.ReqId == id).FirstOrDefault();
            return Ok(x);
        }

    }
}
