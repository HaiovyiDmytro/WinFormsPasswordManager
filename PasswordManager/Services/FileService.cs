using System.IO;

namespace PasswordManager.Services
{
    internal interface IFileService
    {
        bool FileExists(string? path);
        void CreateFile(string path);
        string ReadAllText(string path);
    }

    internal class FileService : IFileService
    {
        void IFileService.CreateFile(string path)
        {
            try
            {
                File.Create(path).Dispose();
            }
            catch
            {
                throw;
            }
        }

        bool IFileService.FileExists(string? path)
        {
            try
            {
                return File.Exists(path);
            }
            catch
            {
                throw;
            }
        }

        string IFileService.ReadAllText(string path)
        {
            try
            {
                return File.ReadAllText(path);
            }
            catch
            {
                throw;
            }
        }
    }
}