using TrackDiary.Model.Common;

namespace TrackDiary.Model.InputDevices
{
    public abstract class Sensor : IAggregateRoot<IntIdentityType>
    {
        public IntIdentityType Id { get; set; }

        public abstract string Name { get; set; }
    }
}
