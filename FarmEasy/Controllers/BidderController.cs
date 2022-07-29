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
    public class BidderController : ControllerBase
    {
        Scheme_For_FarmersContext db = new Scheme_For_FarmersContext();
        [HttpPost]
        [Route("AddBid")]
        public IActionResult PostFarm(Bidder Bid)
        {
            if (ModelState.IsValid)
            {
                db.Bidders.Add(Bid);
                db.SaveChanges();
                return Created("Details Registered Successfully", Bid);
            }
            return BadRequest("Cannot Register");
        }
        [HttpGet]
        [Route("BidDetails")]
        public IActionResult GetBidder([FromQuery] string email)
        {
            var data = db.Bidders.Where(d => d.Email == email).ToList();
            return Ok(data);
        }
        [HttpGet]
        [Route("BidList")]
        public IActionResult GetBidder()
        {
            var data = db.Bidders.ToList();
            return Ok(data);
        }
        [HttpGet]
        [Route("BidDetails/{id}")]
        public IActionResult GetBidder(int id)
        {
            var data = db.Bidders.ToList();
            return Ok(data);
        }
        [HttpPut]
        [Route("EditBidder/{id}")]
        public IActionResult PutBid(int id)
        {
            Bidder bid = db.Bidders.Find(id);
            bid.Approved = true;
            db.SaveChanges();
            return Ok();
        }
    }
}
