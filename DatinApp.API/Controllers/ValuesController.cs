using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatinApp.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatinApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly DataContext _context;
        public ValuesController(DataContext context)
        {
            _context = context;
        }
        // Get api/values
        [HttpGet]
        // public ActionResult<IEnumerable<string>> Get()
        // {
        //     return new string[] { "value1", "value2" };
        // }

        public async Task<IActionResult> GetValues()
        {
            var values = await _context.Values.ToListAsync();
            return Ok(values);
        }
        //Get api/values/5
        [HttpGet("{id}")]
        // public ActionResult<string> Get(int id)
        // {
        //     return "value";
        // }

        public async Task<IActionResult> GetValue(int id)
        {
            var value =await  _context.Values.FirstOrDefaultAsync(x => x.Id == id);
            return Ok(value);
        }
        // Put api/values/5
        public void Put(int id, [FromBody] string value)
        {

        }

        //Delete api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }

    }
}