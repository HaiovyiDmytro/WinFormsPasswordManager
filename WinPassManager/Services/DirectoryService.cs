using System.IO;

namespace WPManager.Services
{
    public interface IDirectoryService
    {
        bool DirectoryExists(string? path);
        DirectoryInfo CreateDirectory(string path);
    }

    public class DirectoryService : IDirectoryService
    {
        DirectoryInfo IDirectoryService.CreateDirectory(string path)
        {
            try
            {
                return Directory.CreateDirectory(path);
            }
            catch
            {
                throw;
            }
        }

        bool IDirectoryService.DirectoryExists(string? path)
        {
            try
            {
                return Directory.Exists(path);
            }
            catch
            {
                throw;
            }
        }
    }
}