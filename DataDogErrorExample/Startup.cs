using StatsdClient;

namespace DataDogErrorExample;
public class Startup
{
    public Startup(IWebHostEnvironment env, IConfiguration configuration)
    {

        DogStatsd.Configure(
           new StatsdConfig
           {
               Prefix = "MyApp",
               StatsdServerName = "localhost"
           }
       );
    }

    public virtual void Configure(IApplicationBuilder app)
    {
    }
}