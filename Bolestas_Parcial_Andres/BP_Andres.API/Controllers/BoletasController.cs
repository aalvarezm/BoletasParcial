using BP_Andres.API.Data;
using BP_Andres.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net.Sockets;

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


        [HttpGet]
        public async Task<ActionResult> GetAsync()
        {
            return Ok(await _context.Boletas.ToListAsync());
        }

        [HttpGet("{NumeroBoleta}")]
        public async Task<ActionResult> GetAsync(string NumeroBoleta)
        {
            var boleta = await _context.Boletas.FirstOrDefaultAsync(x => x.NumeroBoleta == NumeroBoleta);
            if (boleta == null)
            {
                return NotFound();
            }
            return Ok(boleta);
        }

        [HttpPut]
        public async Task<ActionResult> PutAsync(Boleta boleta)
        {
            try
            {
                _context.Update(boleta);

                await _context.SaveChangesAsync();

                return Ok(boleta);
            }
            catch (Exception exception)
            {
                return BadRequest(exception.Message);
            }
        }

    }
}
