using TrackDiary.Model.Common;
using TrackDiary.Model.Membership;

namespace TrackDiary.Model.Location
{
    public interface IUserRepository : IRepository<User, StringIdentityType>
    {
    }
}
