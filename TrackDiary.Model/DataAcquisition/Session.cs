using TrackDiary.Model.Common;

namespace TrackDiary.Model.DataAcquisition
{
    public class Session : IAggregateRoot<IntIdentityType>
    {
        public IntIdentityType Id { get; set; }
    }
}