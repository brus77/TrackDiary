using System;
using System.Collections.Generic;
using TrackDiary.Infrastructure.Repositories.Common;
using TrackDiary.Model.Common;
using TrackDiary.Model.Membership;

namespace TrackDiary.Infrastructure.Repositories.Membership
{
    public class UserRepository : IUserRepository
    {
        public User this[StringIdentityType id] { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public User CreateNew()
        {
            using (var ldb = LiteDBContext.Instance)
            {
                var newItem = new User();
                newItem.Id = new StringIdentityType();
                newItem.Id.IdValue = Guid.NewGuid().ToString();
                var col = ldb.GetCollection<User>("users");
                col.Insert(newItem);
                return newItem;
            }
        }

        public IEnumerable<User> GetAll()
        {
            using (var ldb = LiteDBContext.Instance)
            {
                var col = ldb.GetCollection<User>("users");
                return col.Query().ToEnumerable();
            }
        }
    }
}
