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
    public class FarmerController : ControllerBase
    {
        Scheme_For_FarmersContext db = new Scheme_For_FarmersContext();
        [HttpPost]
        [Route("AddFarm")]
        public IActionResult PostFarm(Farmer farm)
        {
            if (ModelState.IsValid)
            {
                db.Farmers.Add(farm);
                db.SaveChanges();
                return Created("Details Registered Successfully", farm);
            }
            return BadRequest("Cannot Register");
        }
        //[HttpPost]
        //[Route("SellCrop/{id}")]
        //public IActionResult PostCrop(int id, Crop crop)
        //{
        //    Farmer farm = db.Farmers.Find(id);
        //    farm.Crops.Add(crop);
        //    db.SaveChanges();
        //    return Created("Added Successfully", crop);
        //}
        [HttpGet]
        [Route("FarmList")]
        public IActionResult GetFarm()
        {
            var data = db.Farmers.Where(f => f.Approved == false).ToList();
            return Ok(data);
        }
        //[HttpGet]
        //[Route("FarmDetails/{id}")]
        //public IActionResult GetFarm(int id)
        //{
        //    var data = from farm in db.Farmers where farm.FarmerId == id select farm;
        //    return Ok(data);
        //}
        [HttpPut]
        [Route("EditFarm/{id}")]
        public IActionResult PutFarm(int id)
        {
            Farmer farm = db.Farmers.Find(id);
            farm.Approved = true;
            db.SaveChanges();
            return Ok();
        }
        [HttpGet]
        [Route("FarmDetails")]
        public IActionResult GetFarm([FromQuery] string Email)
        {
            var data = db.Farmers.Where(d => d.Email == Email).ToList();
            return Ok(data);
        }
        //[HttpGet]
        //[Route("FarmDetails/{id}")]
        //public IActionResult GetFarm(int id)
        //{
        //    Farmer farm = db.Farmers.Find(id);
        //    return Ok(farm);
        //}
    }
}
