using TrackDiary.Model.Common;

namespace TrackDiary.Model.InputDevices
{
    public interface ISensorRepository : IRepository<Sensor, StringIdentityType>
    {
    }
}
