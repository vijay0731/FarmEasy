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
    public class CropController : ControllerBase
    {
        Scheme_For_FarmersContext db = new Scheme_For_FarmersContext();
        [HttpGet]
        [Route("CropList/{id}")]
        public IActionResult GetCrop(int id)
        {
            var data = from crop in db.Crops where crop.FarmerId == id where crop.Status=="Unsold" select crop;
            return Ok(data);
        }
        [HttpGet]
        [Route("SoldCrops/{id}")]
        public IActionResult GetSold (int id)
        {
            var data = db.Crops.Where(d => d.FarmerId == id).Where(d => d.Status == "sold").ToList();
            return Ok(data);
        }
        [HttpPut]
        [Route("SellCrop/{id}")]
        public IActionResult PutSell(int id, Crop crop)
        {
            if (ModelState.IsValid)
            {
                Crop old_crop = db.Crops.Find(id);
                old_crop.Status = crop.Status;
                old_crop.BasePrice = crop.BasePrice;
                db.SaveChanges();
                return Ok();
            }
            return BadRequest("Error while putting sell request");
        }
        [HttpPut]
        [Route("PlaceBid/{id}")]
        public IActionResult PutBid(int id, Crop crop)
        {
            if (ModelState.IsValid)
            {
                Crop old_crop = db.Crops.Find(id);
                old_crop = crop;
                db.SaveChanges();
                return Ok();
            }
            return BadRequest("Cannot place bid");
        }
    }
}
