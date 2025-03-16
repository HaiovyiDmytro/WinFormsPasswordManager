using System.IO;

namespace PasswordManager.Services
{
    internal interface IDirectoryService
    {
        bool DirectoryExists(string? path);
        DirectoryInfo CreateDirectory(string path);
    }

    internal class DirectoryService : IDirectoryService
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