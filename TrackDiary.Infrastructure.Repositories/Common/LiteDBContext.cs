using LiteDB;

namespace TrackDiary.Infrastructure.Repositories.Common
{
    internal static class LiteDBContext
    {
        private static LiteDatabase _instance = new LiteDatabase(LiteDBConfiguration.DBFilePath);
        public static LiteDatabase Instance() => _instance;
    }
}
