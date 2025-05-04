using LendSpace.Data;
using LendSpace.Models.Enums;

namespace LendSpace.Services.Background
{
    public class Scheduler : BackgroundService
    {
        private readonly ILogger<Scheduler> _logger;
        private readonly IServiceScopeFactory _scopeFactory;

        public Scheduler(ILogger<Scheduler> logger, IServiceScopeFactory scopeFactory)
        {
            _logger = logger;
            _scopeFactory = scopeFactory;
        }

        public override Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Scheduler is starting.");
            return base.StartAsync(cancellationToken);
        }

        public override Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Scheduler is stopping.");
            return base.StopAsync(cancellationToken);
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("Scheduler is running.");

            while (!stoppingToken.IsCancellationRequested)
            {
                try
                {
                    var current = DateTime.Now;
                    _logger.LogInformation("Checking events at: {time}", current);

                    // Create a new scope and resolve ApplicationDbContext
                    using (var scope = _scopeFactory.CreateScope())
                    {
                        var _context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

                        // Check and update events using the scoped DbContext instance
                        await CheckAndUpdateEvents(current, _context, stoppingToken);
                    }

                    // Delay for a specific interval (e.g., one minute)
                    await Task.Delay(TimeSpan.FromMinutes(1), stoppingToken);
                }
                catch (TaskCanceledException)
                {
                    break;
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Error occurred while updating events.");
                    // Delay briefly before retrying on error
                    await Task.Delay(TimeSpan.FromSeconds(30), stoppingToken);
                }
            }

            _logger.LogInformation("Scheduler is shutting down gracefully.");
        }

        // Event Checker that now uses a scoped ApplicationDbContext parameter.
        private async Task CheckAndUpdateEvents(DateTime current, ApplicationDbContext context, CancellationToken token)
        {
            _logger.LogInformation("Updating events for date: {currentDate}", current);

            var today = DateOnly.FromDateTime(current);
            var events = context.Events.ToList();

            foreach (var ev in events)
            {
                if (today >= ev!.StartsAt && today <= ev.EndsAt)
                {
                    ev.Status = EventStatus.Ongoing;
                }
                else if (today < ev!.StartsAt)
                {
                    ev.Status = EventStatus.Incoming;
                }
                else
                {
                    ev.Status = EventStatus.Ended;
                }
                context.Events.Update(ev);
            }

            await context.SaveChangesAsync(token);
        }
    }
}