using TrackDiary.Model.Common;

namespace TrackDiary.Model.Location
{
    public class Track : IAggregateRoot<StringIdentityType>
    {
        public Track()
        {

        }

        public StringIdentityType Id { get; set; }

        public string Name { get; set; }
        public Address Address { get; set; }
    }
}
