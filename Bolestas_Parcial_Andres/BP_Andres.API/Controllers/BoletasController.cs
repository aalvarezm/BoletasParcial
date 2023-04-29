using BP_Andres.API.Data;
using BP_Andres.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BP_Andres.API.Controllers
{
    [ApiController]
    [Route("/api/boletas")]
    public class BoletasController: ControllerBase
    {
        private readonly DataContext _context;

        public BoletasController(DataContext context)
        {
            _context = context;
        }

        //[HttpPost]
        //public async Task<ActionResult> PostAsync(Boleta boleta){

        //    _context.Boletas.Add(boleta);
        //    await _context.SaveChangesAsync();
        //    return Ok(boleta);

        //}

        [HttpGet]
        public async Task<ActionResult> GetAsync()
        {
            return Ok(await _context.Boletas.ToListAsync());
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> GetAsync(int id)
        {
            var boleta = await _context.Boletas.FirstOrDefaultAsync(x => x.Id == id);
            if(boleta == null)
            {
                return NotFound(); 
            }
            return Ok(boleta);
        }

    }
}
