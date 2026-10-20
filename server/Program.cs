using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.FileProviders;

namespace AspReactDist
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            var distPath = Path.GetFullPath(Path.Combine(app.Environment.ContentRootPath, "..", "client", "dist"));
            var fileProvider = new PhysicalFileProvider(distPath);

            app.UseDefaultFiles(new DefaultFilesOptions { FileProvider = fileProvider });
            app.UseStaticFiles(new StaticFileOptions { FileProvider = fileProvider });

            app.Run();
        }
    }
}
