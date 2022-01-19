using TrackDiary.Infrastructure.Repositories.Common;
using TrackDiary.Model.Common;
using TrackDiary.Model.InputDevices;

namespace TrackDiary.Infrastructure.Repositories.InputDevices
{
    public class SensorRepository : BaseRepository<Sensor, StringIdentityType>, ISensorRepository
    {
    }
}
