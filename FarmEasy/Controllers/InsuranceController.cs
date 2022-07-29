using FarmEasy.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmEasy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InsuranceController : ControllerBase
    {
        Scheme_For_FarmersContext db = new Scheme_For_FarmersContext();
        [HttpGet]
        [Route("InsuList")]
        public IActionResult GetInsu()
        {
            var data = from insu in db.Insurances where insu.Claim == true select insu;
            return Ok(data);
        }
        [HttpGet]
        [Route("InsuList/{id}")]
        public IActionResult GetInsu(int id)
        {
            var data = from insu in db.Insurances where insu.FarmerId == id where insu.Claim==false select insu;
            return Ok(data);
        }
        [HttpPost]
        [Route("AddInsu")]
        public IActionResult PostInsu(Insurance Insu)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    db.Insurances.Add(Insu);
                    db.SaveChanges();
                }
                catch
                {
                    return BadRequest("Cannot Add Record");
                }
            }
            return Created("Record Added Successfully", Insu);
        }
        [HttpPut]
        [Route("ClaimInsu/{id}")]
        public IActionResult PutClaim(int id, Insurance Insu)
        {
            if (ModelState.IsValid)
            {
                Insurance Old_Insu = db.Insurances.Find(id);
                Old_Insu = Insu;
                db.SaveChanges();
            }
            return Ok();
        }
        [HttpPut]
        [Route("ApproveClaim/{id}")]
        public IActionResult PutApprove(int id, Insurance Insu)
        {
            Insurance Old_Insu = db.Insurances.Find(id);
            Old_Insu = Insu;
            db.SaveChanges();
            return Ok();
        }
    }
}
