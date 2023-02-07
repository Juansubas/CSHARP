namespace DMS.DERCO.WorkerService
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly IConfiguration _configuration;

        private string _frecuencia;
        private int _tiempo;
        private int _milisegundos;

        public Worker(ILogger<Worker> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                try
                {
                    _frecuencia = _configuration("Ejecucion:Frecuencia");
                    _tiempo = Convert.ToInt32(_configuration("Ejecucion:Tiempo"));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }

                switch (_frecuencia)
                {
                    case "H":
                        _milisegundos = _tiempo * 60 * 60 * 1000;
                        break;
                    case "M":
                        _milisegundos = _tiempo * 60 * 1000;
                        break;
                    case "S":
                        _milisegundos = _tiempo * 1000;
                        break;
                    default:
                        _tiempo = 60 * 1000;
                        break;
                }

                //Otra forma más efectiva

                _milisegundos = _frecuencia switch
                {
                    "H" => _tiempo * 60 * 60 * 1000,
                    "M" => _tiempo * 60 * 1000,
                    "S" => _tiempo * 1000,
                    _ => 60 * 1000
                }; ;
                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}