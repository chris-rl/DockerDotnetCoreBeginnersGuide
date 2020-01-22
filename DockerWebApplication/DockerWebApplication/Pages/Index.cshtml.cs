using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeetupLib;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace DockerWebApplication.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly GreetingService _greetingService;

        public IndexModel(ILogger<IndexModel> logger, GreetingService greetingService)
        {
            _logger = logger;
            _greetingService = greetingService;
        }

        public string Greetings => _greetingService.HelloCommunity();

        public void OnGet()
        {
        }
    }
}
