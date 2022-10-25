using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Options;
using WebAppConfig.Models;

namespace WebAppConfig.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IConfiguration _configuration;
        private readonly AppConfiguration _appConfiguration;

        public IndexModel(
            IConfiguration configuration,
            IOptions<AppConfiguration> appConfiguration)
        {
            _configuration = configuration;
            _appConfiguration = appConfiguration.Value;
        }

        public void OnGet()
        {
            //ViewData["variable1"] = _configuration["variable1"];
            //ViewData["variable2"] = _configuration["variable2"];
            //ViewData["variable3"] = _configuration["variable3"];

            //ViewData["variable1"] = _configuration["Variables:variable1"];
            //ViewData["variable2"] = _configuration["Variables:variable2"];
            //ViewData["variable3"] = _configuration["Variables:variable3"];

            ViewData["variable1"] = _appConfiguration.variable1;
            ViewData["variable2"] = _appConfiguration.variable2;
            ViewData["variable3"] = _appConfiguration.variable3;
        }
    }
}