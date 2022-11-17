using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NetCoreWebNlog.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
            _logger.LogTrace("1.Trace");
            _logger.LogDebug("2.Debug");
            _logger.LogInformation("3.Information");
            _logger.LogWarning("4.Warning");
            _logger.LogError("5.Error");
            _logger.LogCritical("6.Critical");
        }
    }
}