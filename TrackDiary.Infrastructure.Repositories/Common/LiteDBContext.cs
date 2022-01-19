using LiteDB;
using TrackDiary.Model.Common;

namespace TrackDiary.Infrastructure.Repositories.Common
{
    internal static class LiteDBContext
    {
        static LiteDBContext()
        {
             _instance = new LiteDatabase($"Filename={LiteDBConfiguration.DBFilePath};");
            BsonMapper.Global.RegisterType<StringIdentityType>
                (   serialize: (stringIdentity) =>  { return new BsonValue(stringIdentity.IdValue); },
                    deserialize: (bsonValue) => { return new StringIdentityType(bsonValue.AsString); }
                );
            BsonMapper.Global.RegisterType<IntIdentityType>
                (   serialize: (intIdentity) => { return new BsonValue(intIdentity.IdValue); },
                    deserialize: (bsonValue) => { return new IntIdentityType(bsonValue.AsInt32); }
                );
        }

        private static LiteDatabase _instance;
        public static LiteDatabase Instance() => _instance;
    }
}
