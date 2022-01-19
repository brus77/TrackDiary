using TrackDiary.Model.Common;

namespace TrackDiary.Model.InputDevices
{
    public class Sensor : IAggregateRoot<StringIdentityType>
    {
        public Sensor()
        {

        }

        public StringIdentityType Id { get; set; }

        public string Name { get; set; }
    }
}
