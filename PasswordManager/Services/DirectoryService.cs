using System.IO;

namespace PasswordManager.Services
{
    internal interface IDirectoryService
    {
        bool DirectoryExists(string? path);
        bool CreateDirectory(string path);
    }

    internal class DirectoryService : IDirectoryService
    {
        bool IDirectoryService.CreateDirectory(string path)
        {
            try
            {
                return Directory.CreateDirectory(path) is not null;
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