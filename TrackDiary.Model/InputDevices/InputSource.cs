using TrackDiary.Model.Common;

namespace TrackDiary.Model.InputDevices
{
    public class InputSource : IAggregateRoot<IntIdentityType>
    {
        public IntIdentityType Id { get; set; }
    }
}