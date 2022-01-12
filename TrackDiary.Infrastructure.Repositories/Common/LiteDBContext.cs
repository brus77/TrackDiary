using LiteDB;

namespace TrackDiary.Infrastructure.Repositories.Common
{
    internal static class LiteDBContext
    {
        public static LiteDatabase NewInstance() => new LiteDatabase(LiteDBConfiguration.DBFilePath);
    }
}
