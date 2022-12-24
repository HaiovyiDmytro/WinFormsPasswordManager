using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using WinPassManager.Services;

using WPManager.Services;

namespace WPManager
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            Application.Run(ServiceProvider.GetRequiredService<loginForm>());
        }
        public static IServiceProvider? ServiceProvider { get; private set; }
        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) => {
                    _ = services.AddScoped<IDirectoryService, DirectoryService>();
                    _ = services.AddScoped<IFileService, FileService>();
                    _ = services.AddScoped<ISecretHasherService, SecretHasherService>();
                    _ = services.AddScoped<IINIFileService, INIFileService>();
                    _ = services.AddTransient<loginForm>();
                    _ = services.AddTransient<mainForm>();
                });
        }
    }
}