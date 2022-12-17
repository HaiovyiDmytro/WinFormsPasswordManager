using System.IO;

namespace WPManager.Services
{
    public interface IFileService
    {
        bool FileExists(string? path);
    }

    public class FileService : IFileService
    {
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
    }
}