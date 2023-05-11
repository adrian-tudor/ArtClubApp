using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ArtClubApp.Data;
using ArtClubApp.Models;
using ArtClubApp;

public class Program
{
    public static void Main(string[] args)
    {
        CreateHostBuilder(args).Build().Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });
}