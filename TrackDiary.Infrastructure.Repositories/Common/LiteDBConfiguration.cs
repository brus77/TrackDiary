using System;
using System.IO;
using System.Reflection;

namespace TrackDiary.Infrastructure.Repositories.Common
{
    internal static class LiteDBConfiguration
    {
        public static string DBFilePath { get; private set;}
        
        static LiteDBConfiguration()
        {
            string codeBase = Assembly.GetExecutingAssembly().CodeBase;
            UriBuilder uri = new UriBuilder(codeBase);
            string path = Uri.UnescapeDataString(uri.Path);
            string assemblyDirectory = Path.GetDirectoryName(path);
            DBFilePath = Path.Combine(assemblyDirectory, "events.db"); 
        }
    }
}
