using System.Runtime.InteropServices;
using System.Text;

namespace WinPassManager.Services
{
    public interface IINIFileService
    {
        void IniWriteValue(string Section, string Key, string Value, string INIPath);

        string IniReadValue(string Section, string Key, string INIPath);
    }

    public class INIFileService : IINIFileService
    {
        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        private static extern long WritePrivateProfileString(
            string section, string key, string val, string filePath);

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        private static extern int GetPrivateProfileString(
            string section, string key, string def, StringBuilder retVal, int size, string filePath);

        public void IniWriteValue(string Section, string Key, string Value, string INIPath)
        {
            _ = WritePrivateProfileString(Section, Key, Value, INIPath);
        }

        public string IniReadValue(string Section, string Key, string INIPath)
        {
            StringBuilder temp = new(255);
            _ = GetPrivateProfileString(Section, Key, "", temp, 255, INIPath);
            return temp.ToString();
        }
    }
}