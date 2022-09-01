using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Loggin_Check.Pages
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
            _logger.LogTrace("This is trace log");
            _logger.LogDebug("This is debug");
            _logger.LogInformation("This is information");
            _logger.LogError("This is error");
            _logger.LogCritical("This is Log critical log");
            _logger.LogInformation(Logginid.DemoCode,"This is our first logged  message");
            _logger.LogError("The server is down {Time}", DateTime.UtcNow);

            //try
            //{

            //}catch(Exception e)
            //{
            //    _logger.LogCritical(e,"There was a bad exeception {Time}",DateTime.UtcNow);
            //}
        }

        public class Logginid
        {
            public const int DemoCode = 1001;
        }
    }
}
