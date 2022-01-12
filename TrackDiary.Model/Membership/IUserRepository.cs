using TrackDiary.Model.Common;
using TrackDiary.Model.Membership;

namespace TrackDiary.Model.Membership
{
    public interface IUserRepository : IRepository<User, StringIdentityType>
    {
    }
}
