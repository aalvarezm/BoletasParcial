using BP_Andres.Shared.Entities;

namespace BP_Andres.API.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;


        public SeedDb(DataContext context)
        {
            _context = context;
        }

        public async Task SeedDbAsync()
        {
            
            await _context.Database.EnsureCreatedAsync();
            await LlenarBoletaAsync();

        }

        public async Task LlenarBoletaAsync()
        {

            if (!_context.Boletas.Any())
            {
                
                Random r = new Random();

                for (int i = 0; i < 50000; i++)
                {
                    _context.Add(new Boleta
                    {

                        FechaUso = null,
                        FueUsada = false,
                        PuertaDeEntrada = null!,
                        NumeroBoleta = r.Next(1,50000).ToString()

                    });

                }
                await _context.SaveChangesAsync();

            }

        }
    }
}
