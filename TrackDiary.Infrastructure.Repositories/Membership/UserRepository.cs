using LiteDB;
using System;
using System.Collections.Generic;
using TrackDiary.Infrastructure.Repositories.Common;
using TrackDiary.Model.Common;
using TrackDiary.Model.Membership;

namespace TrackDiary.Infrastructure.Repositories.Membership
{
    public class UserRepository : IUserRepository
    {
        private LiteDatabase ldb = LiteDBContext.Instance();

        public User this[StringIdentityType id] {
            get {
                var col = ldb.GetCollection<User>("users");
                return col.Query().Where(x => x.Id == id).Single();
            }

            set {
                var col = ldb.GetCollection<User>("users");
                col.Insert(value);
            }
        }

        public User CreateNew()
        {
            var newItem = new User();
            newItem.Id = new StringIdentityType(Guid.NewGuid().ToString());
            var col = ldb.GetCollection<User>("users");
            col.Insert(newItem);
            return newItem;
        }

        public IEnumerable<User> GetAll()
        {
            var col = ldb.GetCollection<User>("users");
            return col.Query().ToEnumerable();
        }
    }
}
