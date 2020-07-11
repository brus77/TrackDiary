using System.Collections.Generic;
using TrackDiary.Model.Common;
using TrackDiary.Model.Location;
using TrackDiary.Model.Membership;

namespace TrackDiary.Infrastructure.Repositories.Location
{
    public class UserRepository : IUserRepository
    {
        public User this[StringIdentityType id] { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public IEnumerable<User> GetAll()
        {
            throw new System.NotImplementedException();
        }
    }
}
