namespace ScoreAPI;

public static class Program
{
    public static void Main(string[] args)
    {
        CreateHostBuilder(args)
            .Build()
            .Run();
    }

    private static IHostBuilder CreateHostBuilder(string[] args)
    {
        return Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                var config = new ConfigurationBuilder()
                    .AddCommandLine(args)
                    .Build();

                webBuilder
                    .UseKestrel(options => options.AddServerHeader = false)
                    .UseConfiguration(config)
                    .UseContentRoot(Directory.GetCurrentDirectory())
                    .UseStartup<Startup>();
            });
    }
}
