using Swapi.Core.Dtos;
using Swapi.Core.Interfaces;

namespace Swapi.Service
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly IConfiguration _configuration;
        private readonly ILogService _logService;
        private readonly IStartshipRepository _startshipRepository;
        private readonly IStartshipService _startshipService;

        private string frecuencia;
        private int tiempo;
        private int milisegundos = 1000;

        public Worker(ILogger<Worker> logger, IConfiguration configuration, ILogService logService, IStartshipRepository startshipRepository, IStartshipService startshipService)
        {
            _logger = logger;
            _configuration = configuration;
            _logService = logService;
            _startshipRepository = startshipRepository;
            _startshipService = startshipService;   
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Worker Iniciado: {time}", DateTimeOffset.Now);
                try
                {
                    frecuencia = _configuration["Ejecucion:Frecuencia"] ?? "10";
                    tiempo = Convert.ToInt32(_configuration["Ejecucion:Tiempo"]);

                    milisegundos = frecuencia switch
                    {
                        "H" => tiempo * 60 * 60 * 1000,
                        "M" => tiempo * 60 * 1000,
                        "S" => tiempo * 60 * 1000,
                        _ => 60 * 1000
                    };

                    var id = new Random().Next(1, 36);
                    var response = await _startshipService.RequestStartship<StartshipDto>(id);
                    _startshipRepository.SaveStartshipHelper(id, response);
                }
                catch (Exception)
                {

                    throw;
                }
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}