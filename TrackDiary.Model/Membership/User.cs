using TrackDiary.Model.Common;

namespace TrackDiary.Model.Membership
{
    public class User : IAggregateRoot<StringIdentityType>
    {
        public StringIdentityType Id { get; set; }
        public string UserName { get; set; }
    }
}
