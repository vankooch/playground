namespace Ky.Iot.Api
{
    using System;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.Extensions.Hosting;

    public static class Program
    {
        public static int Main(string[] args)
        {
            try
            {
                Host.CreateDefaultBuilder(args)
                    .ConfigureWebHostDefaults(webBuilder =>
                    {
                        webBuilder.UseStartup<Startup>();
                    })
                    .Build()
                    .Run();

                return 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);

                return -1;
            }
        }
    }
}