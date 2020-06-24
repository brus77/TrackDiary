using TrackDiary.Model.Common;

namespace TrackDiary.Model.InputDevices
{
    public class Sensor : IAggregateRoot<IntIdentityType>
    {
        public IntIdentityType Id { get; set; }
    }
}
