using Microsoft.AspNetCore.Mvc;

namespace ConfigurationSource.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MyConfigController : Controller
    {
        public IConfiguration Configuration { get; }
        public MyConfigController(IConfiguration configuration)
        {
            Configuration = configuration;
        }

    

        [HttpGet]
        public Dictionary<string, string> Get()
        {

          return  Configuration.GetSection("Demo")
                .GetChildren()
                .ToDictionary(x=> x.Key, x => x.Value);



        }
    }
}
