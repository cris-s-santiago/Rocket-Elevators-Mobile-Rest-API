using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestAPI.Models;

namespace RestAPI.Controllers
{  
    [Route("api/[controller]")]
    [ApiController]
    public class QuotesController
    {
              private readonly RestAPIContext _context;

        public QuotesController(RestAPIContext context)
        {
            _context = context;
        }
    //-----------get all the elevators-----------------//
      [HttpGet]
        public async Task<ActionResult<IEnumerable<Quote>>> GetQuotes()
        {
            return await _context.quotes.ToListAsync();
        }
//------------------- Retrieving a list of Elevators that are not in operation at the time of the request -------------------\\

       
    }
}