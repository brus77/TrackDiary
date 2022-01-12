using LiteDB;
using System;
using System.Collections.Generic;
using System.Text;

namespace TrackDiary.Infrastructure.Repositories.Common
{
    internal static class LiteDBContext
    {
        public static LiteDatabase Instance => new LiteDatabase(LiteDBConfiguration.DBFilePath);
    }
}
