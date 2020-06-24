using TrackDiary.Model.Common;

namespace TrackDiary.Model.DataAcquisition
{
    public class Event : IAggregateRoot<IntIdentityType>
    {
        public IntIdentityType Id { get; set; }
    }
}